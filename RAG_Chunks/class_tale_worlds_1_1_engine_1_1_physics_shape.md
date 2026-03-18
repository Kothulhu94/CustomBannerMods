--- SOURCE: class_tale_worlds_1_1_engine_1_1_physics_shape.html ---

TaleWorlds.Engine.PhysicsShape Class ReferencesealedInherits [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| PhysicsShape | [CreateCopy](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a725f95ef95d0a9ff5537180ca3a545ab) () |
| int | [SphereCount](class_tale_worlds_1_1_engine_1_1_physics_shape.html#ac0c78c5dd283bcdb0549b9c49312a3cf) () |
| void | [GetSphere](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a368526ab72772bad7a5d93009c80dfc8) (ref [SphereData](struct_tale_worlds_1_1_engine_1_1_sphere_data.html) data, int index) |
| void | [GetSphere](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a7123c416f646f708006043a6cd34ff99) (ref [SphereData](struct_tale_worlds_1_1_engine_1_1_sphere_data.html) data, out [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) material, int index) |
| [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) | [GetDominantMaterialForTriangleMesh](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a8a3db463a0ec2d24caa923103f90eb71) (int meshIndex) |
| string | [GetName](class_tale_worlds_1_1_engine_1_1_physics_shape.html#ac65016e799cf62e86c9eefbf959df724) () |
| int | [TriangleMeshCount](class_tale_worlds_1_1_engine_1_1_physics_shape.html#acf70ee52c70021b97bd0a559a495e667) () |
| int | [TriangleCountInTriangleMesh](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a52c49c09b948808eff08ceae346478c2) (int meshIndex) |
| void | [GetTriangle](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a0b422cbc825b555ed93dd436ccca21e2) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] triangle, int meshIndex, int triangleIndex) |
| void | [Prepare](class_tale_worlds_1_1_engine_1_1_physics_shape.html#af65e78172a3c611460ce4d166f67c606) () |
| int | [CapsuleCount](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a10c338bfd9414cb241577bbca2d1dad7) () |
| void | [AddCapsule](class_tale_worlds_1_1_engine_1_1_physics_shape.html#acb8384a6013d041277c4b67f94328458) ([CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) data) |
| void | [InitDescription](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a4f34f8270b3390bac39c64bb85ec1460) () |
| void | [AddSphere](class_tale_worlds_1_1_engine_1_1_physics_shape.html#aed30e7e501fc19dcd7bdf8a7b11f3b3a) ([SphereData](struct_tale_worlds_1_1_engine_1_1_sphere_data.html) data) |
| void | [SetCapsule](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a51dd6f379c9afe4bd678020920f7b70e) ([CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) data, int index) |
| void | [GetCapsule](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a976d8b9100b04d3e226e9d52b89a1e5d) (ref [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) data, int index) |
| void | [GetCapsule](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a337a6e19d5f8318269c027a384ca6bbd) (ref [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) data, out [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) material, int index) |
| void | [GetBoundingBox](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a605417cd15bc92468e348e95cb30c463) (out [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) boundingBox) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetBoundingBoxCenter](class_tale_worlds_1_1_engine_1_1_physics_shape.html#aa60b2d7c759330b4d648a369d4cdeae7) () |
| void | [Transform](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a5afbd30c7b176b6d5585420fa7bf7986) (ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [Clear](class_tale_worlds_1_1_engine_1_1_physics_shape.html#ab1866be29daf3c9d7f61654615dab1f5) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static PhysicsShape | [GetFromResource](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a4c311adefffa283712af9b7255245d37) (string bodyName, bool mayReturnNull=false) |
| static void | [AddPreloadQueueWithName](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a49df66d21cc8d1edfd2401a2b699ad27) (string bodyName, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) scale) |
| static void | [ProcessPreloadQueue](class_tale_worlds_1_1_engine_1_1_physics_shape.html#afe769d72e811030459c01f900ebd6906) () |
| static void | [UnloadDynamicBodies](class_tale_worlds_1_1_engine_1_1_physics_shape.html#af6973ed15a4af2ff0ce6a4eea3ccf127) () |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Member Functions inherited from [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html) | |
|  | [Resource](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13) () |
| void | [CheckResourceParameter](class_tale_worlds_1_1_engine_1_1_resource.html#acb4f0c2d802a8a8530c3813f8c7e9c5d) ([Resource](class_tale_worlds_1_1_engine_1_1_resource.html#a933e187fe65b6aebb90f58f2f44f8e13) param, string paramName="") |
|  | Check if the parameter 'param' is null or invalid and throws an exception containing 'paramName' as further information. |
| Properties inherited from [TaleWorlds.Engine.Resource](class_tale_worlds_1_1_engine_1_1_resource.html) | |
| bool | [IsValid](class_tale_worlds_1_1_engine_1_1_resource.html#ad0c94ab0bd3bcdd26b02ac6117e7662f) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a4c311adefffa283712af9b7255245d37)GetFromResource()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | PhysicsShape TaleWorlds.Engine.PhysicsShape.GetFromResource | ( | string | *bodyName*, | |  |  | bool | *mayReturnNull* = false ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a49df66d21cc8d1edfd2401a2b699ad27)AddPreloadQueueWithName()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Engine.PhysicsShape.AddPreloadQueueWithName | ( | string | *bodyName*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *scale* ) | | static |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#afe769d72e811030459c01f900ebd6906)ProcessPreloadQueue()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.PhysicsShape.ProcessPreloadQueue | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#af6973ed15a4af2ff0ce6a4eea3ccf127)UnloadDynamicBodies()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.Engine.PhysicsShape.UnloadDynamicBodies | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a725f95ef95d0a9ff5537180ca3a545ab)CreateCopy()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| PhysicsShape TaleWorlds.Engine.PhysicsShape.CreateCopy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#ac0c78c5dd283bcdb0549b9c49312a3cf)SphereCount()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.PhysicsShape.SphereCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a368526ab72772bad7a5d93009c80dfc8)GetSphere() [1/2]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.PhysicsShape.GetSphere | ( | ref [SphereData](struct_tale_worlds_1_1_engine_1_1_sphere_data.html) | *data*, |
|  |  | int | *index* ) |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a7123c416f646f708006043a6cd34ff99)GetSphere() [2/2]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.PhysicsShape.GetSphere | ( | ref [SphereData](struct_tale_worlds_1_1_engine_1_1_sphere_data.html) | *data*, |
|  |  | out [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) | *material*, |
|  |  | int | *index* ) |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a8a3db463a0ec2d24caa923103f90eb71)GetDominantMaterialForTriangleMesh()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) TaleWorlds.Engine.PhysicsShape.GetDominantMaterialForTriangleMesh | ( | int | *meshIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#ac65016e799cf62e86c9eefbf959df724)GetName()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.PhysicsShape.GetName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#acf70ee52c70021b97bd0a559a495e667)TriangleMeshCount()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.PhysicsShape.TriangleMeshCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a52c49c09b948808eff08ceae346478c2)TriangleCountInTriangleMesh()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.PhysicsShape.TriangleCountInTriangleMesh | ( | int | *meshIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a0b422cbc825b555ed93dd436ccca21e2)GetTriangle()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.PhysicsShape.GetTriangle | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)[] | *triangle*, |
|  |  | int | *meshIndex*, |
|  |  | int | *triangleIndex* ) |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#af65e78172a3c611460ce4d166f67c606)Prepare()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.PhysicsShape.Prepare | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a10c338bfd9414cb241577bbca2d1dad7)CapsuleCount()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.PhysicsShape.CapsuleCount | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#acb8384a6013d041277c4b67f94328458)AddCapsule()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.PhysicsShape.AddCapsule | ( | [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) | *data* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a4f34f8270b3390bac39c64bb85ec1460)InitDescription()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.PhysicsShape.InitDescription | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#aed30e7e501fc19dcd7bdf8a7b11f3b3a)AddSphere()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.PhysicsShape.AddSphere | ( | [SphereData](struct_tale_worlds_1_1_engine_1_1_sphere_data.html) | *data* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a51dd6f379c9afe4bd678020920f7b70e)SetCapsule()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.PhysicsShape.SetCapsule | ( | [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) | *data*, |
|  |  | int | *index* ) |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a976d8b9100b04d3e226e9d52b89a1e5d)GetCapsule() [1/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.PhysicsShape.GetCapsule | ( | ref [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) | *data*, |
|  |  | int | *index* ) |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a337a6e19d5f8318269c027a384ca6bbd)GetCapsule() [2/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.PhysicsShape.GetCapsule | ( | ref [CapsuleData](struct_tale_worlds_1_1_engine_1_1_capsule_data.html) | *data*, |
|  |  | out [PhysicsMaterial](struct_tale_worlds_1_1_engine_1_1_physics_material.html) | *material*, |
|  |  | int | *index* ) |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a605417cd15bc92468e348e95cb30c463)GetBoundingBox()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.PhysicsShape.GetBoundingBox | ( | out [BoundingBox](struct_tale_worlds_1_1_engine_1_1_bounding_box.html) | *boundingBox* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#aa60b2d7c759330b4d648a369d4cdeae7)GetBoundingBoxCenter()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.PhysicsShape.GetBoundingBoxCenter | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#a5afbd30c7b176b6d5585420fa7bf7986)Transform()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.PhysicsShape.Transform | ( | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_physics_shape.html#ab1866be29daf3c9d7f61654615dab1f5)Clear()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.PhysicsShape.Clear | ( |  | ) |  |

