--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html ---

TaleWorlds.MountAndBlade.SpawnPathData Struct Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [SnapMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aa40a7f255572f88d2dfdad67a024c086) {     [DontSnap](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aa40a7f255572f88d2dfdad67a024c086a89bd161c5a5099ec4cba6d9a7f3ba515) = 0 ,     [SnapToTerrain](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aa40a7f255572f88d2dfdad67a024c086abd51caac7ddaee19fdf05c8e5f5d9c75) = 1 ,     [SnapToWaterLevel](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aa40a7f255572f88d2dfdad67a024c086ac2a7ed572ecdbf46ca0f534a4340601e) = 2   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| SpawnPathData | [Invert](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a8ae9320c9dc7e91c3295664e6405dc30) () |
| float | [ClampPathOffset](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a1fbf943cbebafe3f186cd7f1f33269ec) (float pathOffsetRatio) |
|  | Clamps the given path offset ratio so its sum with the path's pivot ratio stays in normalized range [0,1]. |
| float | [GetOffsetOverflow](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a35030002cb7c03c20aa0005b5691e608) (float pathOffset) |
|  | Returns the overflowing path ratio when the given offset is added on top of the pivot ratio of the spawn path. |
| void | [GetSpawnPathFrameFacingTarget](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a999935bf94a7e279c15eaaee8c470734) (float baseOffset, float targetOffset, bool useTangentDirection, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) spawnPathPosition, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) spawnPathDirection, bool decideDirectionDynamically=false, float dynamicDistancePercentage=0.2f) |
|  | Returns a 2D spawn path frame (with position and direction) with respect to the given base path offset and a target path offset. |
| void | [GetSpawnPathFrameFacingPivot](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a66bd78b4f4ca063211ac24f012376f34) (float pathOffset, bool useTangentDirection, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) spawnPathPosition, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) spawnPathDirection) |
|  | Returns a 2D spawn path frame (position and direction) towards spawn path's pivot. |
| void | [GetSpawnPathFrameFacingTangentDirection](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a22bb1d0e2dbb7ede81b84509da60c947) (float baseOffset, int tangentDirection, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) spawnPathPosition, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) spawnPathDirection) |
|  | Returns a 2D spawn path frame (with position and direction) with respect to the given base path offset and having a direction that is tangent to the spawn path at the base offset position. |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static SpawnPathData | [Create](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a4f520b2f324059abab897b6e9457bdbb) ([Scene](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a058a3a5e84298e84c22b44a955729e82) scene, [Path](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#af400a41d0eb8492814ae1aa81a596b1b) path, float pivotRatio=0f, bool isInverted=false, [SnapMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aa40a7f255572f88d2dfdad67a024c086) snapType=[SnapMethod.DontSnap](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aa40a7f255572f88d2dfdad67a024c086a89bd161c5a5099ec4cba6d9a7f3ba515)) |
|  | Creates a new spawn path data. |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly Scene | [Scene](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a058a3a5e84298e84c22b44a955729e82) |
| readonly Path | [Path](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#af400a41d0eb8492814ae1aa81a596b1b) |
| readonly bool | [IsInverted](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a14064da798d34c4968fb19dde36630dc) |
|  | If path is inverted the last node becomes first node and first becomes last. |
| readonly float | [PivotRatio](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#acfb264e13f5d6c75be3278b80077113a) |
|  | Normalized Pivot offset used for spawning on this path. |
| readonly [SnapMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aa40a7f255572f88d2dfdad67a024c086) | [SnapType](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a71fedc8335f1a183187c954b98a39ccd) |
|  | Determines how the spawn path will be snapped on the underlying surface when computing snap frames. |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [SpawnPathEpsilon](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aeec178f97f1c56493430f83f8aa47121) = 0.01f |
| static readonly SpawnPathData | [Invalid](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#ad0b965b485e248372ae1f96ff6813462) = new SpawnPathData(null) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsValid](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a15e9417849c9ef95436f08ecc8150066) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aa40a7f255572f88d2dfdad67a024c086)SnapMethod
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.SpawnPathData.SnapMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aa40a7f255572f88d2dfdad67a024c086) |

| Enumerator | |
| --- | --- |
| DontSnap |  |
| SnapToTerrain |  |
| SnapToWaterLevel |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a8ae9320c9dc7e91c3295664e6405dc30)Invert()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SpawnPathData TaleWorlds.MountAndBlade.SpawnPathData.Invert | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a1fbf943cbebafe3f186cd7f1f33269ec)ClampPathOffset()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.SpawnPathData.ClampPathOffset | ( | float | *pathOffsetRatio* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | pathOffsetRatio | Unclamped ratio to be added on top of the path's pivot ratio |

Returns
:   The clamped ratio which can safely be added on the path's pivot ratio without exceeding the normalized range [0,1]

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a35030002cb7c03c20aa0005b5691e608)GetOffsetOverflow()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.SpawnPathData.GetOffsetOverflow | ( | float | *pathOffset* | ) |  |

Returns
:   If overflow occurs at the beginning of spawn path this returns a negative value for the overflow ratio If it occurs at the end of the spawn path this returns a positive overflow ratio

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a999935bf94a7e279c15eaaee8c470734)GetSpawnPathFrameFacingTarget()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SpawnPathData.GetSpawnPathFrameFacingTarget | ( | float | *baseOffset*, |
|  |  | float | *targetOffset*, |
|  |  | bool | *useTangentDirection*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *spawnPathPosition*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *spawnPathDirection*, |
|  |  | bool | *decideDirectionDynamically* = false, |
|  |  | float | *dynamicDistancePercentage* = 0::2f ) |

Parameters
:   |  |  |
    | --- | --- |
    | baseOffset | Normalized base offset on the spawn path (in range [-1,1]). Relative to path's pivot. |
    | targetOffset | Normalized offset used to determine spawn frame direction (in range [-1,1]). Relative to path's pivot |
    | useTangentDirection | If set, spawn path direction is set to tangent direction towards the target. |
    | spawnPathPosition | Output spawn path position |
    | spawnPathDirection | Output spawn path direction |
    | decideDirectionDynamically | If set, spawn path direction will be decided dynamically with respect to navmesh path distance and euclidean distance between base path position and target path position. If navmesh path distance is significantly greater, path tangent direction is used. otherwise unit direction vector from base position to target position will be used. This requires useTangentDirection to be set to false. |
    | dynamicDistancePercentage | Percentage threshold which determines when to chose tangent direction or target direction. If navmesh path is longer than the euclidean distance By this percentage tangent direction will be outputted as spawn path direction |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a66bd78b4f4ca063211ac24f012376f34)GetSpawnPathFrameFacingPivot()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SpawnPathData.GetSpawnPathFrameFacingPivot | ( | float | *pathOffset*, |
|  |  | bool | *useTangentDirection*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *spawnPathPosition*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *spawnPathDirection* ) |

Parameters
:   |  |  |
    | --- | --- |
    | pathOffset | Normalized offset on the spawn path (in range [-1,1]). Relative to path's pivot. |
    | useTangentDirection | If set, spawn path direction is set to tangent direction towards the pivot. Otherwise direction towards the pivot is returned |
    | spawnPathPosition | Output spawn path position |
    | spawnPathDirection | Output spawn path direction |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a22bb1d0e2dbb7ede81b84509da60c947)GetSpawnPathFrameFacingTangentDirection()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.SpawnPathData.GetSpawnPathFrameFacingTangentDirection | ( | float | *baseOffset*, |
|  |  | int | *tangentDirection*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *spawnPathPosition*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *spawnPathDirection* ) |

Parameters
:   |  |  |
    | --- | --- |
    | baseOffset |  |
    | tangentDirection | Direction of the tangent. If positive, the tangent along the positive direction is returned as direction Otherwise the tangent direction along the negative direction is returned |
    | spawnPathPosition | Output spawn path position |
    | spawnPathDirection | Output spawn path direction |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a4f520b2f324059abab897b6e9457bdbb)Create()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | SpawnPathData TaleWorlds.MountAndBlade.SpawnPathData.Create | ( | [Scene](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a058a3a5e84298e84c22b44a955729e82) | *scene*, | |  |  | [Path](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#af400a41d0eb8492814ae1aa81a596b1b) | *path*, | |  |  | float | *pivotRatio* = 0f, | |  |  | bool | *isInverted* = false, | |  |  | [SnapMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aa40a7f255572f88d2dfdad67a024c086) | *snapType* = [SnapMethod::DontSnap](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aa40a7f255572f88d2dfdad67a024c086a89bd161c5a5099ec4cba6d9a7f3ba515) ) | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aeec178f97f1c56493430f83f8aa47121)SpawnPathEpsilon
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.SpawnPathData.SpawnPathEpsilon = 0.01f | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#ad0b965b485e248372ae1f96ff6813462)Invalid
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly SpawnPathData TaleWorlds.MountAndBlade.SpawnPathData.Invalid = new SpawnPathData(null) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a058a3a5e84298e84c22b44a955729e82)Scene
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Scene TaleWorlds.MountAndBlade.SpawnPathData.Scene |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#af400a41d0eb8492814ae1aa81a596b1b)Path
----------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly Path TaleWorlds.MountAndBlade.SpawnPathData.Path |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a14064da798d34c4968fb19dde36630dc)IsInverted
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly bool TaleWorlds.MountAndBlade.SpawnPathData.IsInverted |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#acfb264e13f5d6c75be3278b80077113a)PivotRatio
----------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly float TaleWorlds.MountAndBlade.SpawnPathData.PivotRatio |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a71fedc8335f1a183187c954b98a39ccd)SnapType
--------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [SnapMethod](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#aa40a7f255572f88d2dfdad67a024c086) TaleWorlds.MountAndBlade.SpawnPathData.SnapType |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_spawn_path_data.html#a15e9417849c9ef95436f08ecc8150066)IsValid
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.SpawnPathData.IsValid | | get |

