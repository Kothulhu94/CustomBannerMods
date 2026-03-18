--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html ---

TaleWorlds.MountAndBlade.MBSceneUtilities Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static MBList< [Path](class_tale_worlds_1_1_engine_1_1_path.html) > | [GetAllSpawnPaths](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a3f1c1ac1c2e08c1bfde1cd2435a41a91) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
| static MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | [GetSoftBoundaryPoints](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a116312c9ec6979298f36608673fc188e) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
| static MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | [GetHardBoundaryPoints](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a667a0981d3bb3aad8cd5985cbb844a31) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene) |
| static MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | [GetSceneLimitPoints](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#ae6f3e882e5a17090f1d728f50656fa65) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) scene, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) sceneLimitMin, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) sceneLimitMax) |
| static MBList<(string tag, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > boundaryPoints, bool insideAllowance)> | [GetDeploymentBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a143612c4de7c3157208080439e15f394) ([BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) battleSide) |
| static void | [GetAxisAlignedBoundaryRectangle](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#ad356cc5585fdf2546809faec0dfc25a9) (List< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > boundaryPoints, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) boundsMin, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) boundsMax) |
| static void | [FindConvexHull](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#aba3aad24014a66c29fbca7e09d43b112) (ref MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > boundary) |
| static void | [RadialSortBoundary](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a871d0b4324efe32ba60a133082f84e06) (ref MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > boundary) |
| static void | [RadialSortBoundary](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#aa24e47aedf24b403ce714c89cf43ea03) (ref MBList< [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > boundary) |
| static bool | [IsConvexAndRadiallySorted](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a0ff16b3483b38af7178d22c55546b74a) (MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > boundary) |
| static bool | [IsPointInsideBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a4b0799852002ca670da8eb1843e6aaab) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) point, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > boundaries, float acceptanceThreshold=0.05f) |
| static float | [FindClosestPointToBoundaries](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a7fe49b4b8ba40fd04c186b36e60fb61a) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > boundaries, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) closestPoint) |
| static float | [FindClosestPointToBoundariesReturnDistanceSquared](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#ac2291fac363d8422cf8fd560bb8ae956) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > boundaries, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) closestPoint, out bool isPositionInsideBoundaries) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MaxNumberOfSpawnPaths](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a778666b78d81a4555cc4f7950894a890) = 32 |
| const string | [SpawnPathPrefix](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a98df60aa8eaca03c5f608e199d9ce3fc) = "spawn\_path\_" |
| const string | [SoftBorderVertexTag](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#ab139d12ee1206224f079061db228ad89) = "walk\_area\_vertex" |
| const string | [HardBorderVertexTag](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a373f2bb46059bec46853dc0708a72149) = "walk\_area\_vertex\_hard" |
| const string | [SoftBoundaryName](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#ac31cbecd48e2388c6c0c75584a4764a4) = "walk\_area" |
| const string | [SceneBoundaryName](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a68bf7a5972ba771270f9820d6fe17c88) = "scene\_boundary" |
| const float | [SceneToHardBoundaryMargin](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#ab82178371c532d0ac8bd4e897e4e197e) = 100f |
| const string | [DefenderDeploymentReferencePositionTag](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a2d858772f8ff2575a1a5812267ded988) = "defender\_infantry" |
| const string | [AttackerDeploymentReferencePositionTag](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a27735c15b760583a0d2751c61e0aa093) = "attacker\_infantry" |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a3f1c1ac1c2e08c1bfde1cd2435a41a91)GetAllSpawnPaths()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBList< [Path](class_tale_worlds_1_1_engine_1_1_path.html) > TaleWorlds.MountAndBlade.MBSceneUtilities.GetAllSpawnPaths | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a116312c9ec6979298f36608673fc188e)GetSoftBoundaryPoints()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > TaleWorlds.MountAndBlade.MBSceneUtilities.GetSoftBoundaryPoints | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a667a0981d3bb3aad8cd5985cbb844a31)GetHardBoundaryPoints()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > TaleWorlds.MountAndBlade.MBSceneUtilities.GetHardBoundaryPoints | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#ae6f3e882e5a17090f1d728f50656fa65)GetSceneLimitPoints()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > TaleWorlds.MountAndBlade.MBSceneUtilities.GetSceneLimitPoints | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *scene*, | |  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *sceneLimitMin*, | |  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *sceneLimitMax* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a143612c4de7c3157208080439e15f394)GetDeploymentBoundaries()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | MBList<(string tag, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > boundaryPoints, bool insideAllowance)> TaleWorlds.MountAndBlade.MBSceneUtilities.GetDeploymentBoundaries | ( | [BattleSideEnum](namespace_tale_worlds_1_1_core.html#a82af3de3b1acc9c86fb6beea2909cf8c) | *battleSide* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#ad356cc5585fdf2546809faec0dfc25a9)GetAxisAlignedBoundaryRectangle()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBSceneUtilities.GetAxisAlignedBoundaryRectangle | ( | List< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | *boundaryPoints*, | |  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *boundsMin*, | |  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *boundsMax* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#aba3aad24014a66c29fbca7e09d43b112)FindConvexHull()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBSceneUtilities.FindConvexHull | ( | ref MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | *boundary* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a871d0b4324efe32ba60a133082f84e06)RadialSortBoundary() [1/2]
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBSceneUtilities.RadialSortBoundary | ( | ref MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | *boundary* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#aa24e47aedf24b403ce714c89cf43ea03)RadialSortBoundary() [2/2]
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBSceneUtilities.RadialSortBoundary | ( | ref MBList< [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > | *boundary* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a0ff16b3483b38af7178d22c55546b74a)IsConvexAndRadiallySorted()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBSceneUtilities.IsConvexAndRadiallySorted | ( | MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | *boundary* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a4b0799852002ca670da8eb1843e6aaab)IsPointInsideBoundaries()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.MBSceneUtilities.IsPointInsideBoundaries | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *point*, | |  |  | MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | *boundaries*, | |  |  | float | *acceptanceThreshold* = 0::05f ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a7fe49b4b8ba40fd04c186b36e60fb61a)FindClosestPointToBoundaries()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBSceneUtilities.FindClosestPointToBoundaries | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, | |  |  | MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | *boundaries*, | |  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *closestPoint* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#ac2291fac363d8422cf8fd560bb8ae956)FindClosestPointToBoundariesReturnDistanceSquared()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBSceneUtilities.FindClosestPointToBoundariesReturnDistanceSquared | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position*, | |  |  | MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | *boundaries*, | |  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *closestPoint*, | |  |  | out bool | *isPositionInsideBoundaries* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a778666b78d81a4555cc4f7950894a890)MaxNumberOfSpawnPaths
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.MountAndBlade.MBSceneUtilities.MaxNumberOfSpawnPaths = 32 | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a98df60aa8eaca03c5f608e199d9ce3fc)SpawnPathPrefix
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.MBSceneUtilities.SpawnPathPrefix = "spawn\_path\_" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#ab139d12ee1206224f079061db228ad89)SoftBorderVertexTag
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.MBSceneUtilities.SoftBorderVertexTag = "walk\_area\_vertex" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a373f2bb46059bec46853dc0708a72149)HardBorderVertexTag
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.MBSceneUtilities.HardBorderVertexTag = "walk\_area\_vertex\_hard" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#ac31cbecd48e2388c6c0c75584a4764a4)SoftBoundaryName
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.MBSceneUtilities.SoftBoundaryName = "walk\_area" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a68bf7a5972ba771270f9820d6fe17c88)SceneBoundaryName
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.MBSceneUtilities.SceneBoundaryName = "scene\_boundary" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#ab82178371c532d0ac8bd4e897e4e197e)SceneToHardBoundaryMargin
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.MountAndBlade.MBSceneUtilities.SceneToHardBoundaryMargin = 100f | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a2d858772f8ff2575a1a5812267ded988)DefenderDeploymentReferencePositionTag
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.MBSceneUtilities.DefenderDeploymentReferencePositionTag = "defender\_infantry" | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_scene_utilities.html#a27735c15b760583a0d2751c61e0aa093)AttackerDeploymentReferencePositionTag
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const string TaleWorlds.MountAndBlade.MBSceneUtilities.AttackerDeploymentReferencePositionTag = "attacker\_infantry" | | static |

