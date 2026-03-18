--- SOURCE: struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html ---

TaleWorlds.MountAndBlade.FacingOrder Struct Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [FacingOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#aa439dbc9f1fd75ff658723fe21ae02e7) {     [LookAtDirection](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#aa439dbc9f1fd75ff658723fe21ae02e7a6443036978ea34721f81009c6ad1fa02) = 0 ,     [LookAtEnemy](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#aa439dbc9f1fd75ff658723fe21ae02e7a0166f9102c688092fca5f6f79de0fd29) = 1   } |

|  |  |
| --- | --- |
| Public Member Functions | |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetDirection](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#af7a9eaf7e3b0ed79c33976e18ff37de3) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) f, [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) targetAgent=null) |
| override bool | [Equals](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#ae25e66b7f36169768accaebb80711ad3) (object obj) |
| override int | [GetHashCode](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#a988d11a48a4b6f074d78c1aa15ed865b) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static FacingOrder | [FacingOrderLookAtDirection](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#a67403400865d0b6fc1f6fac278983575) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) direction) |
| static bool | [operator!=](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#a7874cdc44056815a1478b672ff2a6bbe) (FacingOrder f1, FacingOrder f2) |
| static bool | [operator==](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#ae883bcbaca08c6fe196fbb547aa6b90d) (FacingOrder f1, FacingOrder f2) |

|  |  |
| --- | --- |
| Public Attributes | |
| readonly [FacingOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#aa439dbc9f1fd75ff658723fe21ae02e7) | [OrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#af2cdfe7d57eadd1f7f29f9252e179c58) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly FacingOrder | [FacingOrderLookAtEnemy](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#a89656a1e21d867f3c7bb069c2e4cd951) = new FacingOrder([FacingOrderEnum.LookAtEnemy](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#aa439dbc9f1fd75ff658723fe21ae02e7a0166f9102c688092fca5f6f79de0fd29)) |

|  |  |
| --- | --- |
| Properties | |
| [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [OrderType](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#a7cfbef2338f7f1b4d594fdf587a584cf) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#aa439dbc9f1fd75ff658723fe21ae02e7)FacingOrderEnum
------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.FacingOrder.FacingOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#aa439dbc9f1fd75ff658723fe21ae02e7) |

| Enumerator | |
| --- | --- |
| LookAtDirection |  |
| LookAtEnemy |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#a67403400865d0b6fc1f6fac278983575)FacingOrderLookAtDirection()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | FacingOrder TaleWorlds.MountAndBlade.FacingOrder.FacingOrderLookAtDirection | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *direction* | ) |  | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#af7a9eaf7e3b0ed79c33976e18ff37de3)GetDirection()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.FacingOrder.GetDirection | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *f*, |
|  |  | [Agent](class_tale_worlds_1_1_mount_and_blade_1_1_agent.html) | *targetAgent* = null ) |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#ae25e66b7f36169768accaebb80711ad3)Equals()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.FacingOrder.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#a988d11a48a4b6f074d78c1aa15ed865b)GetHashCode()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.MountAndBlade.FacingOrder.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#a7874cdc44056815a1478b672ff2a6bbe)operator!=()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.FacingOrder.operator!= | ( | FacingOrder | *f1*, | |  |  | FacingOrder | *f2* ) | | static |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#ae883bcbaca08c6fe196fbb547aa6b90d)operator==()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.FacingOrder.operator== | ( | FacingOrder | *f1*, | |  |  | FacingOrder | *f2* ) | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#af2cdfe7d57eadd1f7f29f9252e179c58)OrderEnum
------------------------------------------------------------------------------------------------------------

|  |
| --- |
| readonly [FacingOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#aa439dbc9f1fd75ff658723fe21ae02e7) TaleWorlds.MountAndBlade.FacingOrder.OrderEnum |

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#a89656a1e21d867f3c7bb069c2e4cd951)FacingOrderLookAtEnemy
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly FacingOrder TaleWorlds.MountAndBlade.FacingOrder.FacingOrderLookAtEnemy = new FacingOrder([FacingOrderEnum.LookAtEnemy](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#aa439dbc9f1fd75ff658723fe21ae02e7a0166f9102c688092fca5f6f79de0fd29)) | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_mount_and_blade_1_1_facing_order.html#a7cfbef2338f7f1b4d594fdf587a584cf)OrderType
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.FacingOrder.OrderType | | get |

