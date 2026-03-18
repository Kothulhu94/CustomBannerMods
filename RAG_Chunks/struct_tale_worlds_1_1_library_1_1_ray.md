--- SOURCE: struct_tale_worlds_1_1_library_1_1_ray.html ---

TaleWorlds.Library.Ray Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Ray](struct_tale_worlds_1_1_library_1_1_ray.html#a637dc615c79f7f4a2b3126bda4603071) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) origin, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction, float maxDistance=float.MaxValue) |
|  | [Ray](struct_tale_worlds_1_1_library_1_1_ray.html#af743adb2375508af19ec8bfa17588d32) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) origin, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction, bool useDirectionLenForMaxDistance) |
| void | [Reset](struct_tale_worlds_1_1_library_1_1_ray.html#a8cdfaa17c660700c47e52d308a2848bf) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) origin, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction, float maxDistance=float.MaxValue) |

|  |  |
| --- | --- |
| Properties | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Origin](struct_tale_worlds_1_1_library_1_1_ray.html#a7ebcf98b5e1e8429b6a79fbaa26b1d19) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Direction](struct_tale_worlds_1_1_library_1_1_ray.html#a1196f251b9b7ba737db1f110f50fff19) `[get]` |
| float | [MaxDistance](struct_tale_worlds_1_1_library_1_1_ray.html#a9326752b05337779aadff5638d8fe7ba) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [EndPoint](struct_tale_worlds_1_1_library_1_1_ray.html#a7266f768bd1a823587e8e6035846f987) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_library_1_1_ray.html#a637dc615c79f7f4a2b3126bda4603071)Ray() [1/2]
---------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Ray.Ray | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *origin*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction*, |
|  |  | float | *maxDistance* = float::MaxValue ) |

[◆](struct_tale_worlds_1_1_library_1_1_ray.html#af743adb2375508af19ec8bfa17588d32)Ray() [2/2]
---------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Ray.Ray | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *origin*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction*, |
|  |  | bool | *useDirectionLenForMaxDistance* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_library_1_1_ray.html#a8cdfaa17c660700c47e52d308a2848bf)Reset()
-----------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.Ray.Reset | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *origin*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction*, |
|  |  | float | *maxDistance* = float::MaxValue ) |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_library_1_1_ray.html#a7ebcf98b5e1e8429b6a79fbaa26b1d19)Origin
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Ray.Origin | | get |

[◆](struct_tale_worlds_1_1_library_1_1_ray.html#a1196f251b9b7ba737db1f110f50fff19)Direction
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Ray.Direction | | get |

[◆](struct_tale_worlds_1_1_library_1_1_ray.html#a9326752b05337779aadff5638d8fe7ba)MaxDistance
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Ray.MaxDistance | | get |

[◆](struct_tale_worlds_1_1_library_1_1_ray.html#a7266f768bd1a823587e8e6035846f987)EndPoint
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Ray.EndPoint | | get |

