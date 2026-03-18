--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html ---

TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [OrderFlag](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a704c6bd2e475ff1cb52f0007a2eb7cbd) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission, [MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html) missionScreen, float flagScale=10f) |
| void | [Tick](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#ae573be881222bbdccdbbf2238b2a10a2) (float dt) |
| void | [SetArrowVisibility](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a7d5f1dc3baf1b746410e7e518b3d5905) (bool isVisible, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) arrowDirection) |
| virtual bool | [IsPositionOnValidGround](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a233215088169f0dc5c5c05e283066baa) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) worldPosition) |
| void | [SetWidthVisibility](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#aded5c20537fe8a7100b9e9c86d0f3433) (bool isVisible, float width) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [IsOrderPositionValid](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#afbdbcf5e75e3d73917b8e8c9bd05f628) ([WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) orderPosition) |

|  |  |
| --- | --- |
| Public Attributes | |
| bool | [IsTroop](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a47e8ced4f3d3da08603378e841a94018) = true |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetFlagPosition](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a973179f175c57e4a9e4e9351c33d1c0c) (out bool isOnValidGround, bool checkForTargetEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetCollisionPoint) |
| virtual void | [UpdateFrame](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a1b2d4d26c0611631ddc293e12f6d0e8f) (out bool isOnValidGround, bool checkForTargetEntity, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) targetCollisionPoint) |

|  |  |
| --- | --- |
| Protected Attributes | |
| readonly IEnumerable< [IOrderableWithInteractionArea](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable_with_interaction_area.html) > | [\_orderablesWithInteractionArea](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a280c411346684ac5755e4fe8a898fa17) |
| readonly [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | [\_mission](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#aa885afe8ed99382d22a9970f70503eba) |
| readonly [MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html) | [\_missionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a428d76d9aead1df343022480fe1bb832) |

|  |  |
| --- | --- |
| Properties | |
| [IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html) | [FocusedOrderableObject](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#ad84a3910fbb2698080f4b68af422c0c6) `[get]` |
| int | [LatestUpdateFrameNo](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a3e7fccd6a6313666eaecfa0e0b241d6c) `[get]` |
|  | Represents the frame number of the latest frame update call. Use it to compare with current frame number to not update flag more than once in a frame. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Position](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a57732d2fc1040bc0c22d12e0f623e25e) `[get]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [Frame](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a2943e2e09b76723dc90b1b1e06223156) `[get]` |
| bool | [IsVisible](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a2e619f4d5211bffc9f4deccaed2e0561) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a704c6bd2e475ff1cb52f0007a2eb7cbd)OrderFlag()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.OrderFlag | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission*, |
|  |  | [MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html) | *missionScreen*, |
|  |  | float | *flagScale* = 10f ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#ae573be881222bbdccdbbf2238b2a10a2)Tick()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.Tick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a7d5f1dc3baf1b746410e7e518b3d5905)SetArrowVisibility()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.SetArrowVisibility | ( | bool | *isVisible*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *arrowDirection* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a973179f175c57e4a9e4e9351c33d1c0c)GetFlagPosition()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.GetFlagPosition | ( | out bool | *isOnValidGround*, | |  |  | bool | *checkForTargetEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetCollisionPoint* ) | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a1b2d4d26c0611631ddc293e12f6d0e8f)UpdateFrame()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.UpdateFrame | ( | out bool | *isOnValidGround*, | |  |  | bool | *checkForTargetEntity*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *targetCollisionPoint* ) | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a233215088169f0dc5c5c05e283066baa)IsPositionOnValidGround()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual bool TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.IsPositionOnValidGround | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *worldPosition* | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#afbdbcf5e75e3d73917b8e8c9bd05f628)IsOrderPositionValid()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.IsOrderPositionValid | ( | [WorldPosition](struct_tale_worlds_1_1_engine_1_1_world_position.html) | *orderPosition* | ) |  | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#aded5c20537fe8a7100b9e9c86d0f3433)SetWidthVisibility()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.SetWidthVisibility | ( | bool | *isVisible*, |
|  |  | float | *width* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a47e8ced4f3d3da08603378e841a94018)IsTroop
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.IsTroop = true |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a280c411346684ac5755e4fe8a898fa17)\_orderablesWithInteractionArea
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly IEnumerable<[IOrderableWithInteractionArea](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable_with_interaction_area.html)> TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.\_orderablesWithInteractionArea | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#aa885afe8ed99382d22a9970f70503eba)\_mission
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.\_mission | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a428d76d9aead1df343022480fe1bb832)\_missionScreen
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [MissionScreen](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_screens_1_1_mission_screen.html) TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.\_missionScreen | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#ad84a3910fbb2698080f4b68af422c0c6)FocusedOrderableObject
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IOrderable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_orderable.html) TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.FocusedOrderableObject | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a3e7fccd6a6313666eaecfa0e0b241d6c)LatestUpdateFrameNo
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.LatestUpdateFrameNo | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a57732d2fc1040bc0c22d12e0f623e25e)Position
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.Position | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a2943e2e09b76723dc90b1b1e06223156)Frame
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.Frame | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_mission_views_1_1_order_1_1_order_flag.html#a2e619f4d5211bffc9f4deccaed2e0561)IsVisible
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.View.MissionViews.Order.OrderFlag.IsVisible | | getset |

