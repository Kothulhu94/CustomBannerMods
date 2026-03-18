--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_movement_path.html ---

TaleWorlds.MountAndBlade.MovementPath Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MovementPath](class_tale_worlds_1_1_mount_and_blade_1_1_movement_path.html#af52dd5d53210581f8dd286f2c42fd0ca) ([NavigationData](struct_tale_worlds_1_1_mount_and_blade_1_1_navigation_data.html) navigationData, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) initialDirection, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) finalDirection) |
|  | [MovementPath](class_tale_worlds_1_1_mount_and_blade_1_1_movement_path.html#a6c5273f69729ad87cf36446da08f1414) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) currentPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) orderPosition, float agentRadius, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) previousDirection, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) finalDirection) |
| void | [TickDebug](class_tale_worlds_1_1_mount_and_blade_1_1_movement_path.html#a1145bcbc3ae205d8fe27a82e0a1a7ea2) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) position) |

|  |  |
| --- | --- |
| Properties | |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [InitialDirection](class_tale_worlds_1_1_mount_and_blade_1_1_movement_path.html#ad6b32ed10ccf970d1ab16d156a5e0d3a) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [FinalDirection](class_tale_worlds_1_1_mount_and_blade_1_1_movement_path.html#aa70f6986f0b86be7a3b75e5de8e06b27) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Destination](class_tale_worlds_1_1_mount_and_blade_1_1_movement_path.html#a01bc30c90a9d43ac4dbccb1763cc5954) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_movement_path.html#af52dd5d53210581f8dd286f2c42fd0ca)MovementPath() [1/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MovementPath.MovementPath | ( | [NavigationData](struct_tale_worlds_1_1_mount_and_blade_1_1_navigation_data.html) | *navigationData*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *initialDirection*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *finalDirection* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_movement_path.html#a6c5273f69729ad87cf36446da08f1414)MovementPath() [2/2]
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.MovementPath.MovementPath | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *currentPosition*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *orderPosition*, |
|  |  | float | *agentRadius*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *previousDirection*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *finalDirection* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_movement_path.html#a1145bcbc3ae205d8fe27a82e0a1a7ea2)TickDebug()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.MovementPath.TickDebug | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *position* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_movement_path.html#ad6b32ed10ccf970d1ab16d156a5e0d3a)InitialDirection
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.MovementPath.InitialDirection | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_movement_path.html#aa70f6986f0b86be7a3b75e5de8e06b27)FinalDirection
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.MovementPath.FinalDirection | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_movement_path.html#a01bc30c90a9d43ac4dbccb1763cc5954)Destination
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.MovementPath.Destination | | get |

