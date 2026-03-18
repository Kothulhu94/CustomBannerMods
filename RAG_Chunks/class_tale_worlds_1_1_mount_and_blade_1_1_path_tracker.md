--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html ---

TaleWorlds.MountAndBlade.PathTracker Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PathTracker](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#a3c5a4bf8a7edf5c97c6d35f822aefbcd) ([Path](class_tale_worlds_1_1_engine_1_1_path.html) path, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) initialScaleOfEntity) |
| void | [UpdateVersion](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#ae866008eb2a04b45a166cc3aaab41c6a) () |
| bool | [PathExists](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#ac6d3cd06f2c544748afdb3cca8034c0f) () |
| void | [Advance](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#a38ea37b82f7e0e39785c8c28222eee6b) (float deltaDistance) |
| float | [GetPathLength](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#af6af24868fd43decdfa190ec8e40956b) () |
| void | [CurrentFrameAndColor](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#a420c6dede3a11a9ffd7f5b07cfaba957) (out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color) |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#af6e38b7aec0f3dc810dc9b19a3bf4615) () |

|  |  |
| --- | --- |
| Properties | |
| float | [TotalDistanceTraveled](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#a1164384f5de96f05d8299c2db38a2ce3) `[get, set]` |
| bool | [HasChanged](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#ac0cc30aaed2aac9420af311677322910) `[get]` |
| bool | [IsValid](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#a1763fb71a7817ba0c13f86f113f5be11) `[get]` |
| bool | [HasReachedEnd](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#ad35ae7e8e7820339ebe1c2a33678c3b7) `[get]` |
| float | [PathTraveledPercentage](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#ad6a48f78cecf3ecb661e5e84fc81e283) `[get]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [CurrentFrame](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#aac20388d34422294ea1ca223674e4773) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#a3c5a4bf8a7edf5c97c6d35f822aefbcd)PathTracker()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.PathTracker.PathTracker | ( | [Path](class_tale_worlds_1_1_engine_1_1_path.html) | *path*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *initialScaleOfEntity* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#ae866008eb2a04b45a166cc3aaab41c6a)UpdateVersion()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.PathTracker.UpdateVersion | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#ac6d3cd06f2c544748afdb3cca8034c0f)PathExists()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.PathTracker.PathExists | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#a38ea37b82f7e0e39785c8c28222eee6b)Advance()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.PathTracker.Advance | ( | float | *deltaDistance* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#af6af24868fd43decdfa190ec8e40956b)GetPathLength()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.MountAndBlade.PathTracker.GetPathLength | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#a420c6dede3a11a9ffd7f5b07cfaba957)CurrentFrameAndColor()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.PathTracker.CurrentFrameAndColor | ( | out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#af6e38b7aec0f3dc810dc9b19a3bf4615)Reset()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.PathTracker.Reset | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#a1164384f5de96f05d8299c2db38a2ce3)TotalDistanceTraveled
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.PathTracker.TotalDistanceTraveled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#ac0cc30aaed2aac9420af311677322910)HasChanged
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.PathTracker.HasChanged | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#a1763fb71a7817ba0c13f86f113f5be11)IsValid
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.PathTracker.IsValid | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#ad35ae7e8e7820339ebe1c2a33678c3b7)HasReachedEnd
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.PathTracker.HasReachedEnd | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#ad6a48f78cecf3ecb661e5e84fc81e283)PathTraveledPercentage
------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.PathTracker.PathTraveledPercentage | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_path_tracker.html#aac20388d34422294ea1ca223674e4773)CurrentFrame
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.PathTracker.CurrentFrame | | get |

