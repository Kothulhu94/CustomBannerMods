--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html ---

TaleWorlds.MountAndBlade.OrderComponent Class Referenceabstract|  |  |
| --- | --- |
| Public Member Functions | |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetDirection](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#a5c11be9e2c5d361c7b92d9757acd26a3) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) f) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [CopyPositionAndDirectionFrom](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#af02210f19d1b9b4d0a76866428050352) ([OrderComponent](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#a47c81fbaa1f2e69ae3ceec36dc122fa9) order) |
|  | [OrderComponent](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#a47c81fbaa1f2e69ae3ceec36dc122fa9) (float tickTimerDuration=0.5f) |
| virtual void | [TickDebug](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#ac985960e875beae1ffe5dd3ed9e4d9a2) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |

|  |  |
| --- | --- |
| Protected Attributes | |
| Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) > | [Position](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#aca331f2cf26777c02f05592e34182de6) |
| Func< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | [Direction](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#a27fabf25e35d2625909a3af22c603246) |

|  |  |
| --- | --- |
| Properties | |
| [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [OrderType](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#a434ae9e1e7da508598e5262d6ba59c8f) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#a47c81fbaa1f2e69ae3ceec36dc122fa9)OrderComponent()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.MountAndBlade.OrderComponent.OrderComponent | ( | float | *tickTimerDuration* = 0::5f | ) |  | | protected |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#a5c11be9e2c5d361c7b92d9757acd26a3)GetDirection()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.OrderComponent.GetDirection | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *f* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#af02210f19d1b9b4d0a76866428050352)CopyPositionAndDirectionFrom()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.OrderComponent.CopyPositionAndDirectionFrom | ( | [OrderComponent](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#a47c81fbaa1f2e69ae3ceec36dc122fa9) | *order* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#ac985960e875beae1ffe5dd3ed9e4d9a2)TickDebug()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.OrderComponent.TickDebug | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | protectedvirtual |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#aca331f2cf26777c02f05592e34182de6)Position
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html)> TaleWorlds.MountAndBlade.OrderComponent.Position | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#a27fabf25e35d2625909a3af22c603246)Direction
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<[Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html), [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)> TaleWorlds.MountAndBlade.OrderComponent.Direction | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_order_component.html#a434ae9e1e7da508598e5262d6ba59c8f)OrderType
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.OrderComponent.OrderType | | getabstract |

