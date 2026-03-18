--- SOURCE: struct_tale_worlds_1_1_engine_1_1_world_position.html ---

TaleWorlds.Engine.WorldPosition Struct Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [WorldPositionEnforcedCache](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9) {     [None](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9a6adf97f83acf6453d4a6a4b1070f3754) ,     [NavMeshVec3](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9a21687bf7563176a8efe749501472f7e8) ,     [GroundVec3](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9acecad1ff82381b318877015063162e6c)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html#aa5c9918d22f1fb24d95f2515fb423188) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
|  | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html#abde4301bb2b86eef7ddee28d0c243b74) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, UIntPtr navMesh, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, bool hasValidZ) |
| void | [SetVec3](struct_tale_worlds_1_1_engine_1_1_world_position.html#a42d4cf3085793deeef216b770f35a591) (UIntPtr navMesh, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, bool hasValidZ) |
| UIntPtr | [GetNavMesh](struct_tale_worlds_1_1_engine_1_1_world_position.html#a507b48cc7b587715414826cd13f0010f) () |
| UIntPtr | [GetNavMeshMT](struct_tale_worlds_1_1_engine_1_1_world_position.html#a1626546343bdbc913bbf85fc5f43e424) () |
| UIntPtr | [GetNearestNavMesh](struct_tale_worlds_1_1_engine_1_1_world_position.html#a8010cb9af3f2becf8e66300fe2322a14) () |
| float | [GetNavMeshZ](struct_tale_worlds_1_1_engine_1_1_world_position.html#ae428e8207147ef305c5cca6b03903a88) () |
| float | [GetNavMeshZMT](struct_tale_worlds_1_1_engine_1_1_world_position.html#adda7366d38ee8d58b8207fd28d5fd326) () |
| float | [GetGroundZ](struct_tale_worlds_1_1_engine_1_1_world_position.html#ae5501b580c113259015d222b1077bac6) () |
| float | [GetGroundZMT](struct_tale_worlds_1_1_engine_1_1_world_position.html#a1e906c92abe670fb4731b37ce70808c2) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetNavMeshVec3](struct_tale_worlds_1_1_engine_1_1_world_position.html#a011720fb193d33fc2a88d50c7c26c1fe) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetNavMeshVec3MT](struct_tale_worlds_1_1_engine_1_1_world_position.html#a74e3adf9bb5e11d337a4ba6f89a79c6f) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetGroundVec3](struct_tale_worlds_1_1_engine_1_1_world_position.html#a77922fd5e79c6356209aeb67dbcd5e8a) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetGroundVec3MT](struct_tale_worlds_1_1_engine_1_1_world_position.html#ace3e0b474e79b3440869f5368e3c0282) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetVec3WithoutValidity](struct_tale_worlds_1_1_engine_1_1_world_position.html#a01ff04acbb52f1e32e9dfd846d288e2c) () |
| void | [SetVec2MT](struct_tale_worlds_1_1_engine_1_1_world_position.html#a1177b553474f0bb3bb05a7ab2c3904ac) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) value) |
| void | [SetVec2](struct_tale_worlds_1_1_engine_1_1_world_position.html#a7d0c14284e472aced88001b68027c088) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) value) |
| float | [DistanceSquaredWithLimit](struct_tale_worlds_1_1_engine_1_1_world_position.html#affecbf6a13ca487918d2370b3ceba029) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetPoint, float limitSquared) |

|  |  |
| --- | --- |
| Public Attributes | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Normal](struct_tale_worlds_1_1_engine_1_1_world_position.html#ac0ebac5651d265aa340f8badc6f84165) |
| [ZValidityState](namespace_tale_worlds_1_1_engine.html#a22b9c14acf7765f0e456616005cb91c7) | [State](struct_tale_worlds_1_1_engine_1_1_world_position.html#a06291c631f86684be53455b46083fece) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html#aa5c9918d22f1fb24d95f2515fb423188) | [Invalid](struct_tale_worlds_1_1_engine_1_1_world_position.html#a4b77e3d5dafdd36de2873f0626237525) = new [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html#aa5c9918d22f1fb24d95f2515fb423188)(UIntPtr.Zero, UIntPtr.Zero, [Vec3.Invalid](struct_tale_worlds_1_1_library_1_1_vec3.html#ab975cc2200f9444a5c6678c3a31c10c5), false) |

|  |  |
| --- | --- |
| Properties | |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [AsVec2](struct_tale_worlds_1_1_engine_1_1_world_position.html#a7831a7d0c60d14077e91689ed1723243) `[get]` |
| float | [X](struct_tale_worlds_1_1_engine_1_1_world_position.html#a3905eba356c62206c4d74c4792599e73) `[get]` |
| float | [Y](struct_tale_worlds_1_1_engine_1_1_world_position.html#ad83a9e5f35b7e4cdcf95158d87ed8614) `[get]` |
| bool | [IsValid](struct_tale_worlds_1_1_engine_1_1_world_position.html#a34e568cc602f66604b74911e4ac8d159) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9)WorldPositionEnforcedCache
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.Engine.WorldPosition.WorldPositionEnforcedCache](struct_tale_worlds_1_1_engine_1_1_world_position.html#a329057f863819c6dea70ecaf11784df9) |

| Enumerator | |
| --- | --- |
| None |  |
| NavMeshVec3 |  |
| GroundVec3 |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#aa5c9918d22f1fb24d95f2515fb423188)WorldPosition() [1/2]
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Engine.WorldPosition.WorldPosition | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#abde4301bb2b86eef7ddee28d0c243b74)WorldPosition() [2/2]
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Engine.WorldPosition.WorldPosition | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, |
|  |  | UIntPtr | *navMesh*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | bool | *hasValidZ* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a42d4cf3085793deeef216b770f35a591)SetVec3()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.WorldPosition.SetVec3 | ( | UIntPtr | *navMesh*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, |
|  |  | bool | *hasValidZ* ) |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a507b48cc7b587715414826cd13f0010f)GetNavMesh()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| UIntPtr TaleWorlds.Engine.WorldPosition.GetNavMesh | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a1626546343bdbc913bbf85fc5f43e424)GetNavMeshMT()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| UIntPtr TaleWorlds.Engine.WorldPosition.GetNavMeshMT | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a8010cb9af3f2becf8e66300fe2322a14)GetNearestNavMesh()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| UIntPtr TaleWorlds.Engine.WorldPosition.GetNearestNavMesh | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#ae428e8207147ef305c5cca6b03903a88)GetNavMeshZ()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.WorldPosition.GetNavMeshZ | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#adda7366d38ee8d58b8207fd28d5fd326)GetNavMeshZMT()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.WorldPosition.GetNavMeshZMT | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#ae5501b580c113259015d222b1077bac6)GetGroundZ()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.WorldPosition.GetGroundZ | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a1e906c92abe670fb4731b37ce70808c2)GetGroundZMT()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.WorldPosition.GetGroundZMT | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a011720fb193d33fc2a88d50c7c26c1fe)GetNavMeshVec3()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.WorldPosition.GetNavMeshVec3 | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a74e3adf9bb5e11d337a4ba6f89a79c6f)GetNavMeshVec3MT()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.WorldPosition.GetNavMeshVec3MT | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a77922fd5e79c6356209aeb67dbcd5e8a)GetGroundVec3()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.WorldPosition.GetGroundVec3 | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#ace3e0b474e79b3440869f5368e3c0282)GetGroundVec3MT()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.WorldPosition.GetGroundVec3MT | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a01ff04acbb52f1e32e9dfd846d288e2c)GetVec3WithoutValidity()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.WorldPosition.GetVec3WithoutValidity | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a1177b553474f0bb3bb05a7ab2c3904ac)SetVec2MT()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WorldPosition.SetVec2MT | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *value* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a7d0c14284e472aced88001b68027c088)SetVec2()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.WorldPosition.SetVec2 | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *value* | ) |  |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#affecbf6a13ca487918d2370b3ceba029)DistanceSquaredWithLimit()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.Engine.WorldPosition.DistanceSquaredWithLimit | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetPoint*, |
|  |  | float | *limitSquared* ) |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#ac0ebac5651d265aa340f8badc6f84165)Normal
--------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Engine.WorldPosition.Normal |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a06291c631f86684be53455b46083fece)State
-------------------------------------------------------------------------------------------------

|  |
| --- |
| [ZValidityState](namespace_tale_worlds_1_1_engine.html#a22b9c14acf7765f0e456616005cb91c7) TaleWorlds.Engine.WorldPosition.State |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a4b77e3d5dafdd36de2873f0626237525)Invalid
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html#aa5c9918d22f1fb24d95f2515fb423188) TaleWorlds.Engine.WorldPosition.Invalid = new [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html#aa5c9918d22f1fb24d95f2515fb423188)(UIntPtr.Zero, UIntPtr.Zero, [Vec3.Invalid](struct_tale_worlds_1_1_library_1_1_vec3.html#ab975cc2200f9444a5c6678c3a31c10c5), false) | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a7831a7d0c60d14077e91689ed1723243)AsVec2
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Engine.WorldPosition.AsVec2 | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a3905eba356c62206c4d74c4792599e73)X
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Engine.WorldPosition.X | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#ad83a9e5f35b7e4cdcf95158d87ed8614)Y
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Engine.WorldPosition.Y | | get |

[◆](struct_tale_worlds_1_1_engine_1_1_world_position.html#a34e568cc602f66604b74911e4ac8d159)IsValid
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Engine.WorldPosition.IsValid | | get |

