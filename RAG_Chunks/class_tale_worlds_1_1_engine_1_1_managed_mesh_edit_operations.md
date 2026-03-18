--- SOURCE: class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html ---

TaleWorlds.Engine.ManagedMeshEditOperations Class ReferencesealedInherits NativeObject.

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [Weld](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#ad9d2581086761b2268cdb25f463451a3) () |
| int | [AddVertex](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a567960434c1891ecc00b6d376d65e7bd) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) vertexPos) |
| int | [AddFaceCorner](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a554dfc14ebd7fe4428b57a9603b9e810) (int vertexIndex, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv0, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) normal) |
| int | [AddFaceCorner](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a11d47edee271c0afcd72bb15816908e0) (int vertexIndex, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv0, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) normal) |
| int | [AddFace](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a367ee21ed374c8943d7352e40875ddbc) (int patchNode0, int patchNode1, int patchNode2) |
| void | [AddTriangle](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#abf8ae94731dde1b429230a2bd90d5140) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p2, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p3, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv2, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv3, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color) |
| void | [AddTriangle](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a3f196be257c117929dda3db22941b986) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p2, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p3, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) n1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) n2, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) n3, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv2, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv3, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) c1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) c2, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) c3) |
| void | [AddRectangle3](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#aac1a22ab5afa0515efbff3cd2eecc7e0) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) o, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) size, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv\_origin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uvSize, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color) |
| void | [AddRectangleWithInverseUV](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a7ab7a6ec8619c52474f2b6a97bb336df) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) o, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) size, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uv\_origin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uvSize, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color) |
| void | [AddRect](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a7217a6875ccd3a12ba121f1406dfc377) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) originBegin, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) originEnd, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uvBegin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uvEnd, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color) |
| void | [AddRectWithZUp](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a9dc302b79a1fea6104109fa44d34f2e2) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) originBegin, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) originEnd, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uvBegin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uvEnd, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color) |
| void | [InvertFacesWindingOrder](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a3caac8fbf9d89f052fb034d942032f3a) () |
| void | [ScaleVertices](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a11acef77fc0601fba43506e6e7ec9e1b) (float newScale) |
| void | [MoveVerticesAlongNormal](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a500dd861cfafd490f52c57665621034b) (float moveAmount) |
| void | [ScaleVertices](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a8a108920487cea4c405c8b64c629382d) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) newScale, bool keepUvX=false, float maxUvSize=1.0f) |
| void | [TranslateVertices](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a9b3d7174d4d8bc6c3f0a99ba0e7b654a) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) newOrigin) |
| void | [AddMeshAux](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#afbd0a32d943ab2ae1f5d9939083623e8) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, sbyte boneNo, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color, bool transformNormal, bool heightGradient, bool addSkinData, bool useDoublePrecision=true) |
| int | [ComputeTangents](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a5bd76f66de71588e66b40b2e1054a88b) (bool checkFixedNormals) |
| void | [GenerateGrid](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#ae3a5db8801b24dbd94c0486248996487) ([Vec2i](struct_tale_worlds_1_1_library_1_1_vec2i.html) numEdges, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) edgeScale) |
| void | [RescaleMesh2d](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a5c13709f2008fd837b6ae6613b04e38d) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) scaleSizeMin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) scaleSizeMax) |
| void | [RescaleMesh2dRepeatX](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a9af660242b28817b14f17d6ae27fb5bf) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) scaleSizeMin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) scaleSizeMax, float frameThickness=0.0f, int frameSide=0) |
| void | [RescaleMesh2dRepeatY](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a97b6945ade0f950bb7ca31376f24b8ea) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) scaleSizeMin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) scaleSizeMax, float frameThickness=0.0f, int frameSide=0) |
| void | [RescaleMesh2dRepeatXWithTiling](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#adaed98f0fc57e7190c9de8bb1a8c6c60) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) scaleSizeMin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) scaleSizeMax, float frameThickness=0.0f, int frameSide=0, float xyRatio=0.0f) |
| void | [RescaleMesh2dRepeatYWithTiling](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#aba261c4d932529131380a28757dc0ab3) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) scaleSizeMin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) scaleSizeMax, float frameThickness=0.0f, int frameSide=0, float xyRatio=0.0f) |
| void | [RescaleMesh2dWithoutChangingUV](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a4dd78f751c7c7dd8ff6a60c465b02fb1) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) scaleSizeMin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) scaleSizeMax, float remaining) |
| void | [AddLine](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#adaba9454bf45db8d627d8ace641bc266) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) start, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) end, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color, float lineWidth=0.004f) |
| void | [ComputeCornerNormals](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#aef1861a76e4680d30899c41daba0bd45) (bool checkFixedNormals=false, bool smoothCornerNormals=true) |
| void | [ComputeCornerNormalsWithSmoothingData](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#aeeafdf111a2c075cd785c5367865aeef) () |
| void | [AddMesh](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a468e44542390c9c79ff3f5a15bc0994c) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [AddMeshWithSkinData](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a66db92ac61d0778d8ded68091404d403) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, sbyte boneIndex) |
| void | [AddMeshWithColor](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a00b948f3ec9153d78a370ba186990984) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) vertexColor, bool useDoublePrecision=true) |
| void | [AddMeshToBone](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a20b45ff4d614d5d3033582968ad9e3f0) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, sbyte boneIndex) |
| void | [AddMeshWithFixedNormals](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a0e6d1f971480dbc24186976f849b6419) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [AddMeshWithFixedNormalsWithHeightGradientColor](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#ad95a31a9a49068d6e7580f60a4cd1b9f) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [AddSkinnedMeshWithColor](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#affef83fbeba9a07098557d5ce4600550) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) mesh, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) vertexColor, bool useDoublePrecision=true) |
| void | [SetCornerVertexColor](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a1150ddc6ef86e562de4b7fda3e98d09b) (int cornerNo, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) vertexColor) |
| void | [SetCornerUV](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a343c0bc56c3289b847622738de7aa27e) (int cornerNo, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) newUV, int uvNumber=0) |
| void | [ReserveVertices](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a2190e2fafdf5fd79a9871007b6c238af) (int count) |
| void | [ReserveFaceCorners](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a72876337ab1f6f4e6d9384146383d3fc) (int count) |
| void | [ReserveFaces](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a24ead239bed8310f5c9f14a2d6fb5b26) (int count) |
| int | [RemoveDuplicatedCorners](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a5b9cb0f80d8c3da23496e0ff5233afca) () |
| void | [TransformVerticesToParent](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a715eb3b9fe6f36360896d58ab5d0bb50) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [TransformVerticesToLocal](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a116f9f5195e331bfe0adb769c7c1a711) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [SetVertexColor](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a691a74a1a8ae8035c0269ec04d97f881) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetVertexColor](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#afb27ccd8aefea4d930b8185e9cf225e6) (int faceCornerIndex) |
| void | [SetVertexColorAlpha](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#aa16d41594ce40e58b3624b5ae49e45f3) (float newAlpha) |
| float | [GetVertexColorAlpha](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a4953907413914f11b2d7094d2c295806) () |
| void | [EnsureTransformedVertices](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#ac38737cead3a7f7a8a0bec466df60c90) () |
| void | [ApplyCPUSkinning](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#aabf9d0d20028098f6bf52e453a6e38f2) ([Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) skeleton) |
| void | [UpdateOverlappedVertexNormals](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#ae27c51bd0916c924880df9e6f3b07bdc) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) attachedToMesh, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) attachFrame, float mergeRadiusSQ=0.0025f) |
| void | [ClearAll](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#af19e055c6df540813ee3440bb4f9bd7b) () |
| void | [SetTangentsOfFaceCorner](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#af264ce7a295c68f100e9dba6c396521e) (int faceCornerIndex, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) tangent, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) binormal) |
| void | [SetPositionOfVertex](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#ad7819ba6465ed5f8e12ab0bfcbfa74f3) (int vertexIndex, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetPositionOfVertex](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a7b816702fb85d5cfdc74ea56a27580a8) (int vertexIndex) |
| void | [RemoveFace](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#adfdd258bf496503719ac1ffc0792d40c) (int faceIndex) |
| void | [FinalizeEditing](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#abf431882b68e5c6d46f7402dce420afe) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static ManagedMeshEditOperations | [Create](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a33dc0de52d677ea117d5f069a0483c66) ([Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) meshToEdit) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a33dc0de52d677ea117d5f069a0483c66)Create()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | ManagedMeshEditOperations TaleWorlds.Engine.ManagedMeshEditOperations.Create | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *meshToEdit* | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#ad9d2581086761b2268cdb25f463451a3)Weld()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.Weld | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a567960434c1891ecc00b6d376d65e7bd)AddVertex()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.ManagedMeshEditOperations.AddVertex | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *vertexPos* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a554dfc14ebd7fe4428b57a9603b9e810)AddFaceCorner() [1/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.ManagedMeshEditOperations.AddFaceCorner | ( | int | *vertexIndex*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv0*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *normal* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a11d47edee271c0afcd72bb15816908e0)AddFaceCorner() [2/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.ManagedMeshEditOperations.AddFaceCorner | ( | int | *vertexIndex*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv0*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv1*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *normal* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a367ee21ed374c8943d7352e40875ddbc)AddFace()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.ManagedMeshEditOperations.AddFace | ( | int | *patchNode0*, |
|  |  | int | *patchNode1*, |
|  |  | int | *patchNode2* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#abf8ae94731dde1b429230a2bd90d5140)AddTriangle() [1/2]
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddTriangle | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p1*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p2*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p3*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv1*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv2*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv3*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a3f196be257c117929dda3db22941b986)AddTriangle() [2/2]
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddTriangle | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p1*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p2*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p3*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *n1*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *n2*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *n3*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv1*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv2*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv3*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *c1*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *c2*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *c3* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#aac1a22ab5afa0515efbff3cd2eecc7e0)AddRectangle3()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddRectangle3 | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *o*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *size*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv\_origin*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uvSize*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a7ab7a6ec8619c52474f2b6a97bb336df)AddRectangleWithInverseUV()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddRectangleWithInverseUV | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *o*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *size*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uv\_origin*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uvSize*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a7217a6875ccd3a12ba121f1406dfc377)AddRect()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddRect | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *originBegin*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *originEnd*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uvBegin*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uvEnd*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a9dc302b79a1fea6104109fa44d34f2e2)AddRectWithZUp()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddRectWithZUp | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *originBegin*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *originEnd*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uvBegin*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uvEnd*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a3caac8fbf9d89f052fb034d942032f3a)InvertFacesWindingOrder()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.InvertFacesWindingOrder | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a11acef77fc0601fba43506e6e7ec9e1b)ScaleVertices() [1/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.ScaleVertices | ( | float | *newScale* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a500dd861cfafd490f52c57665621034b)MoveVerticesAlongNormal()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.MoveVerticesAlongNormal | ( | float | *moveAmount* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a8a108920487cea4c405c8b64c629382d)ScaleVertices() [2/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.ScaleVertices | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *newScale*, |
|  |  | bool | *keepUvX* = false, |
|  |  | float | *maxUvSize* = 1::0f ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a9b3d7174d4d8bc6c3f0a99ba0e7b654a)TranslateVertices()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.TranslateVertices | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *newOrigin* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#afbd0a32d943ab2ae1f5d9939083623e8)AddMeshAux()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddMeshAux | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | sbyte | *boneNo*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color*, |
|  |  | bool | *transformNormal*, |
|  |  | bool | *heightGradient*, |
|  |  | bool | *addSkinData*, |
|  |  | bool | *useDoublePrecision* = true ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a5bd76f66de71588e66b40b2e1054a88b)ComputeTangents()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.ManagedMeshEditOperations.ComputeTangents | ( | bool | *checkFixedNormals* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#ae3a5db8801b24dbd94c0486248996487)GenerateGrid()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.GenerateGrid | ( | [Vec2i](struct_tale_worlds_1_1_library_1_1_vec2i.html) | *numEdges*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *edgeScale* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a5c13709f2008fd837b6ae6613b04e38d)RescaleMesh2d()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.RescaleMesh2d | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *scaleSizeMin*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *scaleSizeMax* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a9af660242b28817b14f17d6ae27fb5bf)RescaleMesh2dRepeatX()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.RescaleMesh2dRepeatX | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *scaleSizeMin*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *scaleSizeMax*, |
|  |  | float | *frameThickness* = 0::0f, |
|  |  | int | *frameSide* = 0 ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a97b6945ade0f950bb7ca31376f24b8ea)RescaleMesh2dRepeatY()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.RescaleMesh2dRepeatY | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *scaleSizeMin*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *scaleSizeMax*, |
|  |  | float | *frameThickness* = 0::0f, |
|  |  | int | *frameSide* = 0 ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#adaed98f0fc57e7190c9de8bb1a8c6c60)RescaleMesh2dRepeatXWithTiling()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.RescaleMesh2dRepeatXWithTiling | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *scaleSizeMin*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *scaleSizeMax*, |
|  |  | float | *frameThickness* = 0::0f, |
|  |  | int | *frameSide* = 0, |
|  |  | float | *xyRatio* = 0::0f ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#aba261c4d932529131380a28757dc0ab3)RescaleMesh2dRepeatYWithTiling()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.RescaleMesh2dRepeatYWithTiling | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *scaleSizeMin*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *scaleSizeMax*, |
|  |  | float | *frameThickness* = 0::0f, |
|  |  | int | *frameSide* = 0, |
|  |  | float | *xyRatio* = 0::0f ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a4dd78f751c7c7dd8ff6a60c465b02fb1)RescaleMesh2dWithoutChangingUV()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.RescaleMesh2dWithoutChangingUV | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *scaleSizeMin*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *scaleSizeMax*, |
|  |  | float | *remaining* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#adaba9454bf45db8d627d8ace641bc266)AddLine()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddLine | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *start*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *end*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color*, |
|  |  | float | *lineWidth* = 0::004f ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#aef1861a76e4680d30899c41daba0bd45)ComputeCornerNormals()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.ComputeCornerNormals | ( | bool | *checkFixedNormals* = false, |
|  |  | bool | *smoothCornerNormals* = true ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#aeeafdf111a2c075cd785c5367865aeef)ComputeCornerNormalsWithSmoothingData()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.ComputeCornerNormalsWithSmoothingData | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a468e44542390c9c79ff3f5a15bc0994c)AddMesh()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddMesh | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a66db92ac61d0778d8ded68091404d403)AddMeshWithSkinData()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddMeshWithSkinData | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | sbyte | *boneIndex* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a00b948f3ec9153d78a370ba186990984)AddMeshWithColor()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddMeshWithColor | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *vertexColor*, |
|  |  | bool | *useDoublePrecision* = true ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a20b45ff4d614d5d3033582968ad9e3f0)AddMeshToBone()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddMeshToBone | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | sbyte | *boneIndex* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a0e6d1f971480dbc24186976f849b6419)AddMeshWithFixedNormals()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddMeshWithFixedNormals | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#ad95a31a9a49068d6e7580f60a4cd1b9f)AddMeshWithFixedNormalsWithHeightGradientColor()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddMeshWithFixedNormalsWithHeightGradientColor | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#affef83fbeba9a07098557d5ce4600550)AddSkinnedMeshWithColor()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.AddSkinnedMeshWithColor | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *mesh*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *vertexColor*, |
|  |  | bool | *useDoublePrecision* = true ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a1150ddc6ef86e562de4b7fda3e98d09b)SetCornerVertexColor()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.SetCornerVertexColor | ( | int | *cornerNo*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *vertexColor* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a343c0bc56c3289b847622738de7aa27e)SetCornerUV()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.SetCornerUV | ( | int | *cornerNo*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *newUV*, |
|  |  | int | *uvNumber* = 0 ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a2190e2fafdf5fd79a9871007b6c238af)ReserveVertices()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.ReserveVertices | ( | int | *count* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a72876337ab1f6f4e6d9384146383d3fc)ReserveFaceCorners()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.ReserveFaceCorners | ( | int | *count* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a24ead239bed8310f5c9f14a2d6fb5b26)ReserveFaces()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.ReserveFaces | ( | int | *count* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a5b9cb0f80d8c3da23496e0ff5233afca)RemoveDuplicatedCorners()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.ManagedMeshEditOperations.RemoveDuplicatedCorners | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a715eb3b9fe6f36360896d58ab5d0bb50)TransformVerticesToParent()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.TransformVerticesToParent | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a116f9f5195e331bfe0adb769c7c1a711)TransformVerticesToLocal()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.TransformVerticesToLocal | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a691a74a1a8ae8035c0269ec04d97f881)SetVertexColor()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.SetVertexColor | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#afb27ccd8aefea4d930b8185e9cf225e6)GetVertexColor()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.ManagedMeshEditOperations.GetVertexColor | ( | int | *faceCornerIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#aa16d41594ce40e58b3624b5ae49e45f3)SetVertexColorAlpha()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.SetVertexColorAlpha | ( | float | *newAlpha* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a4953907413914f11b2d7094d2c295806)GetVertexColorAlpha()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.ManagedMeshEditOperations.GetVertexColorAlpha | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#ac38737cead3a7f7a8a0bec466df60c90)EnsureTransformedVertices()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.EnsureTransformedVertices | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#aabf9d0d20028098f6bf52e453a6e38f2)ApplyCPUSkinning()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.ApplyCPUSkinning | ( | [Skeleton](class_tale_worlds_1_1_engine_1_1_skeleton.html) | *skeleton* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#ae27c51bd0916c924880df9e6f3b07bdc)UpdateOverlappedVertexNormals()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.UpdateOverlappedVertexNormals | ( | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | *attachedToMesh*, |
|  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *attachFrame*, |
|  |  | float | *mergeRadiusSQ* = 0::0025f ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#af19e055c6df540813ee3440bb4f9bd7b)ClearAll()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.ClearAll | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#af264ce7a295c68f100e9dba6c396521e)SetTangentsOfFaceCorner()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.SetTangentsOfFaceCorner | ( | int | *faceCornerIndex*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *tangent*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *binormal* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#ad7819ba6465ed5f8e12ab0bfcbfa74f3)SetPositionOfVertex()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.SetPositionOfVertex | ( | int | *vertexIndex*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#a7b816702fb85d5cfdc74ea56a27580a8)GetPositionOfVertex()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.ManagedMeshEditOperations.GetPositionOfVertex | ( | int | *vertexIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#adfdd258bf496503719ac1ffc0792d40c)RemoveFace()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.RemoveFace | ( | int | *faceIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_managed_mesh_edit_operations.html#abf431882b68e5c6d46f7402dce420afe)FinalizeEditing()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.ManagedMeshEditOperations.FinalizeEditing | ( |  | ) |  |

