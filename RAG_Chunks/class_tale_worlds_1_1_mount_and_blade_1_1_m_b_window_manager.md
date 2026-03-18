--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html ---

TaleWorlds.MountAndBlade.MBWindowManager Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static float | [WorldToScreen](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#ae35c25bc059ec4d0e4e883a2d85889d2) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) camera, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldSpacePosition, ref float screenX, ref float screenY, ref float w) |
|  | Returns coordinates of a position, projected onto the screen space, inside the game window, does not calculate for usable area. |
| static float | [WorldToScreenInsideUsableArea](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#a7251824e09b337a5e216019e02ff9432) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) camera, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldSpacePosition, ref float screenX, ref float screenY, ref float w) |
|  | Returns coordinates of a position, projected onto the screen space, inside the usable area. e.g 0,0 is the top left corner but if the Usable area starts at (100,100), this method will return (-100,-100). |
| static float | [WorldToScreenWithFixedZ](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#a873879412c49b8132a2c22a0be965e48) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) camera, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) cameraPosition, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldSpacePosition, ref float screenX, ref float screenY, ref float w) |
| static void | [ScreenToWorld](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#a0c8fb96827dbd2c36b517323c925c4bf) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) camera, float screenX, float screenY, float w, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) worldSpacePosition) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetScreenResolution](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#a294d58c8e3bb81c4acfeb5bd42847d49) () |
| static void | [PreDisplay](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#a2234df4eb7ee286e7bd5579a06fc015e) () |
| static void | [DontChangeCursorPos](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#a6b35018b2b198f25aba6e0a391a6a3a5) () |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#ae35c25bc059ec4d0e4e883a2d85889d2)WorldToScreen()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBWindowManager.WorldToScreen | ( | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *camera*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldSpacePosition*, | |  |  | ref float | *screenX*, | |  |  | ref float | *screenY*, | |  |  | ref float | *w* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#a7251824e09b337a5e216019e02ff9432)WorldToScreenInsideUsableArea()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBWindowManager.WorldToScreenInsideUsableArea | ( | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *camera*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldSpacePosition*, | |  |  | ref float | *screenX*, | |  |  | ref float | *screenY*, | |  |  | ref float | *w* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#a873879412c49b8132a2c22a0be965e48)WorldToScreenWithFixedZ()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.MountAndBlade.MBWindowManager.WorldToScreenWithFixedZ | ( | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *camera*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *cameraPosition*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldSpacePosition*, | |  |  | ref float | *screenX*, | |  |  | ref float | *screenY*, | |  |  | ref float | *w* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#a0c8fb96827dbd2c36b517323c925c4bf)ScreenToWorld()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBWindowManager.ScreenToWorld | ( | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *camera*, | |  |  | float | *screenX*, | |  |  | float | *screenY*, | |  |  | float | *w*, | |  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *worldSpacePosition* ) | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#a294d58c8e3bb81c4acfeb5bd42847d49)GetScreenResolution()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.MBWindowManager.GetScreenResolution | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#a2234df4eb7ee286e7bd5579a06fc015e)PreDisplay()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBWindowManager.PreDisplay | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_m_b_window_manager.html#a6b35018b2b198f25aba6e0a391a6a3a5)DontChangeCursorPos()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.MBWindowManager.DontChangeCursorPos | ( |  | ) |  | | static |

