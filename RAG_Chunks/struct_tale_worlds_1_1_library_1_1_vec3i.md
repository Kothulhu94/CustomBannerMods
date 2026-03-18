--- SOURCE: struct_tale_worlds_1_1_library_1_1_vec3i.html ---

TaleWorlds.Library.Vec3i Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) (int x=0, int y=0, int z=0) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [ToVec3](struct_tale_worlds_1_1_library_1_1_vec3i.html#ac17c0c2f398c4dfb68cf2b14f1eef23d) () |
| override bool | [Equals](struct_tale_worlds_1_1_library_1_1_vec3i.html#a6e6d08b281139426bbed37303f414703) (object obj) |
| override int | [GetHashCode](struct_tale_worlds_1_1_library_1_1_vec3i.html#a9094ddca667cb6d39c6cc4f950b5d648) () |
|  | Returns a hash code for this instance. This value changes when one of the X, Y, or Z values changes. Therefore, do not put [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html "3D Vector class") objects to a Hash table. If you have to, then do not change any of the values of the object after it is put to a Hash table. |
| override string | [ToString](struct_tale_worlds_1_1_library_1_1_vec3i.html#ac01c97cfa9ee22282bed712660e20aad) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [operator==](struct_tale_worlds_1_1_library_1_1_vec3i.html#acd5ba17808ca589ff4d2a1fabc303a5c) ([Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) v1, [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) v2) |
| static bool | [operator!=](struct_tale_worlds_1_1_library_1_1_vec3i.html#a20c8d8b1686e9426167f2344d175e79c) ([Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) v1, [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) v2) |
| static [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) | [operator\*](struct_tale_worlds_1_1_library_1_1_vec3i.html#a58cdff3dfe2e81b9086206ee84b39f65) ([Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) v, int mult) |
| static [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) | [operator+](struct_tale_worlds_1_1_library_1_1_vec3i.html#a56b79808e406f52d28dab1a87aa551b7) ([Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) v1, [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) v2) |
| static [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) | [operator-](struct_tale_worlds_1_1_library_1_1_vec3i.html#a8412ba79a95015d6e45f61e07c24b7b3) ([Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) v1, [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) v2) |

|  |  |
| --- | --- |
| Public Attributes | |
| int | [X](struct_tale_worlds_1_1_library_1_1_vec3i.html#ad5fb1900c3c0e65c175ac950e08e1da0) |
| int | [Y](struct_tale_worlds_1_1_library_1_1_vec3i.html#ac727ba6d0de0ab2db073f321afa62003) |
| int | [Z](struct_tale_worlds_1_1_library_1_1_vec3i.html#a16ceb6d1061641a497a6fe84a7b8eef5) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) | [Zero](struct_tale_worlds_1_1_library_1_1_vec3i.html#afa37c0967ecb9dc3140a90ea64268d8b) = new [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c)(0, 0, 0) |

|  |  |
| --- | --- |
| Properties | |
| int | [this[int index]](struct_tale_worlds_1_1_library_1_1_vec3i.html#ac1d7b2f46c946de56d6acdfbdbea45e2) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c)Vec3i()
-------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Vec3i.Vec3i | ( | int | *x* = 0, |
|  |  | int | *y* = 0, |
|  |  | int | *z* = 0 ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#acd5ba17808ca589ff4d2a1fabc303a5c)operator==()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Vec3i.operator== | ( | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) | *v1*, | |  |  | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) | *v2* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#a20c8d8b1686e9426167f2344d175e79c)operator!=()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Vec3i.operator!= | ( | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) | *v1*, | |  |  | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) | *v2* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#ac17c0c2f398c4dfb68cf2b14f1eef23d)ToVec3()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Vec3i.ToVec3 | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#a58cdff3dfe2e81b9086206ee84b39f65)operator\*()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) TaleWorlds.Library.Vec3i.operator\* | ( | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) | *v*, | |  |  | int | *mult* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#a56b79808e406f52d28dab1a87aa551b7)operator+()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) TaleWorlds.Library.Vec3i.operator+ | ( | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) | *v1*, | |  |  | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) | *v2* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#a8412ba79a95015d6e45f61e07c24b7b3)operator-()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) TaleWorlds.Library.Vec3i.operator- | ( | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) | *v1*, | |  |  | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) | *v2* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#a6e6d08b281139426bbed37303f414703)Equals()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Library.Vec3i.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#a9094ddca667cb6d39c6cc4f950b5d648)GetHashCode()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Library.Vec3i.GetHashCode | ( |  | ) |  |

Returns
:   A hash code for this instance.

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#ac01c97cfa9ee22282bed712660e20aad)ToString()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Library.Vec3i.ToString | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#ad5fb1900c3c0e65c175ac950e08e1da0)X
-------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.Library.Vec3i.X |

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#ac727ba6d0de0ab2db073f321afa62003)Y
-------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.Library.Vec3i.Y |

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#a16ceb6d1061641a497a6fe84a7b8eef5)Z
-------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.Library.Vec3i.Z |

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#afa37c0967ecb9dc3140a90ea64268d8b)Zero
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c) TaleWorlds.Library.Vec3i.Zero = new [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html#a967d5200a7e2404627c5aaa1b530772c)(0, 0, 0) | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_library_1_1_vec3i.html#ac1d7b2f46c946de56d6acdfbdbea45e2)this[int index]
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Library.Vec3i.this[int index] | | getset |

