--- SOURCE: class_tale_worlds_1_1_engine_1_1_mesh_builder.html ---

TaleWorlds.Engine.MeshBuilder Class Reference|  |  |
| --- | --- |
| Classes | |
| struct | [FaceCorner](struct_tale_worlds_1_1_engine_1_1_mesh_builder_1_1_face_corner.html) |
| struct | [Face](struct_tale_worlds_1_1_engine_1_1_mesh_builder_1_1_face.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MeshBuilder](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#adf6b7035a66fa4acfe51d51026083586) () |
| int | [AddFaceCorner](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#aeb541b07283a5e2d29cd909b80b6079f) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) normal, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) uvCoord, uint color) |
| int | [AddFace](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#a59739b6dfae0ac7fe80614f14429f43f) (int patchNode0, int patchNode1, int patchNode2) |
| void | [Clear](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#a00d7c4b6b7ec214f515c659139ab3c85) () |
| [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | [Finalize](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#a734990d530b9618e8db77cf6343c4134) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | [CreateUnitMesh](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#a73f72f6073810aa26447e4ab14ed16a1) () |
| static [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | [CreateTilingWindowMesh](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#aea5c0e8bb5f67fd215b3ca171d322787) (string baseMeshName, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) meshSizeMin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) meshSizeMax, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) borderThickness, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) bgBorderThickness) |
| static [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) | [CreateTilingButtonMesh](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#ad6ae05f8152f2d748eb8116ef572e572) (string baseMeshName, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) meshSizeMin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) meshSizeMax, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) borderThickness) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#adf6b7035a66fa4acfe51d51026083586)MeshBuilder()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Engine.MeshBuilder.MeshBuilder | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#aeb541b07283a5e2d29cd909b80b6079f)AddFaceCorner()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.MeshBuilder.AddFaceCorner | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *normal*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *uvCoord*, |
|  |  | uint | *color* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#a59739b6dfae0ac7fe80614f14429f43f)AddFace()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.Engine.MeshBuilder.AddFace | ( | int | *patchNode0*, |
|  |  | int | *patchNode1*, |
|  |  | int | *patchNode2* ) |

[◆](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#a00d7c4b6b7ec214f515c659139ab3c85)Clear()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.MeshBuilder.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#a734990d530b9618e8db77cf6343c4134)Finalize()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) TaleWorlds.Engine.MeshBuilder.Finalize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#a73f72f6073810aa26447e4ab14ed16a1)CreateUnitMesh()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) TaleWorlds.Engine.MeshBuilder.CreateUnitMesh | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#aea5c0e8bb5f67fd215b3ca171d322787)CreateTilingWindowMesh()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) TaleWorlds.Engine.MeshBuilder.CreateTilingWindowMesh | ( | string | *baseMeshName*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *meshSizeMin*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *meshSizeMax*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *borderThickness*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *bgBorderThickness* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_mesh_builder.html#ad6ae05f8152f2d748eb8116ef572e572)CreateTilingButtonMesh()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Mesh](class_tale_worlds_1_1_engine_1_1_mesh.html) TaleWorlds.Engine.MeshBuilder.CreateTilingButtonMesh | ( | string | *baseMeshName*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *meshSizeMin*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *meshSizeMax*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *borderThickness* ) | | static |

