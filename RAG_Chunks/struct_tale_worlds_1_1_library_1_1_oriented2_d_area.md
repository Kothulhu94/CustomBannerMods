--- SOURCE: struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html ---

TaleWorlds.Library.Oriented2DArea Struct ReferenceRepresents an oriented rectangular area in 2d space which is defined by a center position and a normalized forward vector.

|  |  |
| --- | --- |
| Classes | |
| struct | [Corners](struct_tale_worlds_1_1_library_1_1_oriented2_d_area_1_1_corners.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Oriented2DArea](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#aea14a238f20cbf8c07e7ee5ab2d87f79) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) globalCenter, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) globalForward, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) localDimensions) |
|  | Creates a new 2D area from the given parameters. |
| void | [SetGlobalCenter](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#a139c3ba966b94d2078a732e1983da66e) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) globalCenter) |
| void | [SetLocalDimensions](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#a6f00a9060ebefdb242077ba430d2a9cb) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) localDimensions) |
| bool | [Overlaps](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#a953d6ab6c190773116c41ddc1a9e7a6f) (in [Oriented2DArea](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#aea14a238f20cbf8c07e7ee5ab2d87f79) otherArea, float clearanceMargin) |
|  | Returns true if this area overlaps with the given area. False otherwise. |
| bool | [Intersects](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#adafdb80dddfe9aa8c7b179c4c148cee1) (in [LineSegment2D](struct_tale_worlds_1_1_library_1_1_line_segment2_d.html) line, float clearanceMargin) |
| [Corners](struct_tale_worlds_1_1_library_1_1_oriented2_d_area_1_1_corners.html) | [GetCorners](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#af2dacaf82ba046cef854c54dced1ff77) () |
|  | Returns corners of. |

|  |  |
| --- | --- |
| Properties | |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GlobalCenter](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#a39f22caa05cff5acb4c29cd8221a378a) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GlobalForward](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#af9e6ff5512ab0cc54bd832a526380cfa) `[get]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [LocalDimensions](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#a183789b8b36b52b03f0907584f8ff9e7) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#aea14a238f20cbf8c07e7ee5ab2d87f79)Oriented2DArea()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Oriented2DArea.Oriented2DArea | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *globalCenter*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *globalForward*, |
|  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *localDimensions* ) |

Parameters
:   |  |  |
    | --- | --- |
    | center | Center of the area |
    | forward | Forward direction of the area |
    | dimensions | Dimensions of the area |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#a139c3ba966b94d2078a732e1983da66e)SetGlobalCenter()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Oriented2DArea.SetGlobalCenter | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *globalCenter* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#a6f00a9060ebefdb242077ba430d2a9cb)SetLocalDimensions()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Oriented2DArea.SetLocalDimensions | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *localDimensions* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#a953d6ab6c190773116c41ddc1a9e7a6f)Overlaps()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.Oriented2DArea.Overlaps | ( | in [Oriented2DArea](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#aea14a238f20cbf8c07e7ee5ab2d87f79) | *otherArea*, |
|  |  | float | *clearanceMargin* ) |

REMARK\_ATES: Use separating axis theorem (SAT) to check if there is at least one axis on which the corners do not overlap

[◆](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#adafdb80dddfe9aa8c7b179c4c148cee1)Intersects()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.Oriented2DArea.Intersects | ( | in [LineSegment2D](struct_tale_worlds_1_1_library_1_1_line_segment2_d.html) | *line*, |
|  |  | float | *clearanceMargin* ) |

[◆](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#af2dacaf82ba046cef854c54dced1ff77)GetCorners()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Corners](struct_tale_worlds_1_1_library_1_1_oriented2_d_area_1_1_corners.html) TaleWorlds.Library.Oriented2DArea.GetCorners | ( |  | ) |  |

Returns

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#a39f22caa05cff5acb4c29cd8221a378a)GlobalCenter
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Library.Oriented2DArea.GlobalCenter | | get |

[◆](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#af9e6ff5512ab0cc54bd832a526380cfa)GlobalForward
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Library.Oriented2DArea.GlobalForward | | get |

[◆](struct_tale_worlds_1_1_library_1_1_oriented2_d_area.html#a183789b8b36b52b03f0907584f8ff9e7)LocalDimensions
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Library.Oriented2DArea.LocalDimensions | | get |

