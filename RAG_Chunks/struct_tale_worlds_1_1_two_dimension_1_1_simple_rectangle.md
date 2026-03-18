--- SOURCE: struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html ---

TaleWorlds.TwoDimension.SimpleRectangle Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SimpleRectangle](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a) (float x, float y, float width, float height) |
| bool | [IsCollide](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a0218caf636201a42133b0c3f9a6b4bab) ([SimpleRectangle](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a) other) |
| Vector2 | [GetCenter](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#ad136072a5a8f03e371e59d6e92522772) () |
| bool | [IsSubRectOf](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a1934ad6898d7fb80c01ad03a224a0cc5) ([SimpleRectangle](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a) other) |
| bool | [IsValid](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a4f964c20c3779e8007e9bb99792b33e4) () |
| bool | [IsPointInside](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#ad2ed546cc20a10f9ebe4bd810add0742) (Vector2 point) |
| void | [ReduceToIntersection](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#ab18070eb521156092656c7845cad81e4) ([SimpleRectangle](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a) other) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [SimpleRectangle](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a) | [Lerp](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#ac1053371772647d68f12909f5e78a5a4) ([SimpleRectangle](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a) from, [SimpleRectangle](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a) to, float ratio) |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [X](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a4d882f821f22a66936e649e1129f92c5) |
| float | [Y](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a230a40f7d9cc38c413a60e7e928b8e49) |
| float | [X2](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a66aa4416551fe50e36b4cb4839521a8d) |
| float | [Y2](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a2b79b53450c9a29dae2000eff6cad696) |

|  |  |
| --- | --- |
| Properties | |
| float | [Width](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#add6ba8938c1fc99723f8d564ad1a8e6f) `[get]` |
| float | [Height](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a05736f410008c33ea724a7fce43adb9d) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a)SimpleRectangle()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.TwoDimension.SimpleRectangle.SimpleRectangle | ( | float | *x*, |
|  |  | float | *y*, |
|  |  | float | *width*, |
|  |  | float | *height* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a0218caf636201a42133b0c3f9a6b4bab)IsCollide()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.SimpleRectangle.IsCollide | ( | [SimpleRectangle](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a) | *other* | ) |  |

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#ad136072a5a8f03e371e59d6e92522772)GetCenter()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Vector2 TaleWorlds.TwoDimension.SimpleRectangle.GetCenter | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a1934ad6898d7fb80c01ad03a224a0cc5)IsSubRectOf()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.SimpleRectangle.IsSubRectOf | ( | [SimpleRectangle](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a) | *other* | ) |  |

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a4f964c20c3779e8007e9bb99792b33e4)IsValid()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.SimpleRectangle.IsValid | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#ad2ed546cc20a10f9ebe4bd810add0742)IsPointInside()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.TwoDimension.SimpleRectangle.IsPointInside | ( | Vector2 | *point* | ) |  |

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#ab18070eb521156092656c7845cad81e4)ReduceToIntersection()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.TwoDimension.SimpleRectangle.ReduceToIntersection | ( | [SimpleRectangle](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a) | *other* | ) |  |

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#ac1053371772647d68f12909f5e78a5a4)Lerp()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [SimpleRectangle](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a) TaleWorlds.TwoDimension.SimpleRectangle.Lerp | ( | [SimpleRectangle](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a) | *from*, | |  |  | [SimpleRectangle](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a713eec00b6b823b313aba1fb57fa572a) | *to*, | |  |  | float | *ratio* ) | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a4d882f821f22a66936e649e1129f92c5)X
------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.TwoDimension.SimpleRectangle.X |

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a230a40f7d9cc38c413a60e7e928b8e49)Y
------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.TwoDimension.SimpleRectangle.Y |

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a66aa4416551fe50e36b4cb4839521a8d)X2
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.TwoDimension.SimpleRectangle.X2 |

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a2b79b53450c9a29dae2000eff6cad696)Y2
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.TwoDimension.SimpleRectangle.Y2 |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#add6ba8938c1fc99723f8d564ad1a8e6f)Width
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.SimpleRectangle.Width | | get |

[◆](struct_tale_worlds_1_1_two_dimension_1_1_simple_rectangle.html#a05736f410008c33ea724a7fce43adb9d)Height
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.TwoDimension.SimpleRectangle.Height | | get |

