--- SOURCE: class_tale_worlds_1_1_engine_1_1_path.html ---

TaleWorlds.Engine.Path Class ReferencesealedInherits NativeObject.

|  |  |
| --- | --- |
| Public Member Functions | |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetHermiteFrameForDt](class_tale_worlds_1_1_engine_1_1_path.html#a0c1dba5a24f8cb476be23d7932426ebd) (float phase, int first\_point) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetFrameForDistance](class_tale_worlds_1_1_engine_1_1_path.html#a5cc8e0629747f630fbae2b47cae41684) (float distance) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [GetNearestFrameWithValidAlphaForDistance](class_tale_worlds_1_1_engine_1_1_path.html#ad4b02ea8f37e92151d9b5793035680be) (float distance, bool searchForward=true, float alphaThreshold=0.5f) |
| void | [GetFrameAndColorForDistance](class_tale_worlds_1_1_engine_1_1_path.html#a3a6bb3997d42e43f8ce1a7066857cb60) (float distance, out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) color) |
| float | [GetArcLength](class_tale_worlds_1_1_engine_1_1_path.html#adbe2f0302d5de6a2c9525fa1daa17cfe) (int first\_point) |
| void | [GetPoints](class_tale_worlds_1_1_engine_1_1_path.html#a933f1bf88b559a94551952e044ecd621) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] points) |
| float | [GetTotalLength](class_tale_worlds_1_1_engine_1_1_path.html#ab049d9c806974c94140ecb047e7933b7) () |
| int | [GetVersion](class_tale_worlds_1_1_engine_1_1_path.html#a33d40fc36767c443362fc4296ddbded3) () |
| void | [SetFrameOfPoint](class_tale_worlds_1_1_engine_1_1_path.html#a17b2dee532d9284c4c9f22bb3996c1b9) (int pointIndex, ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| void | [SetTangentPositionOfPoint](class_tale_worlds_1_1_engine_1_1_path.html#af139f0fc14be34209f500beb2df91bc2) (int pointIndex, int tangentIndex, ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position) |
| int | [AddPathPoint](class_tale_worlds_1_1_engine_1_1_path.html#a2b3ba5ea30254a71fad10cf595b4ebea) (int newNodeIndex) |
| void | [DeletePathPoint](class_tale_worlds_1_1_engine_1_1_path.html#ab2565e27a8c10f357fef1d4d7fc4b289) (int nodeIndex) |
| bool | [HasValidAlphaAtPathPoint](class_tale_worlds_1_1_engine_1_1_path.html#a558d5d56225fe096aef43090b4f7249f) (int nodeIndex, float alphaThreshold=0.5f) |
| string | [GetName](class_tale_worlds_1_1_engine_1_1_path.html#abdb9ef7a27ebbf302ea73ef0c23689b8) () |

|  |  |
| --- | --- |
| Properties | |
| int | [NumberOfPoints](class_tale_worlds_1_1_engine_1_1_path.html#ab6b02ce185a676a3fe578d9832a27fe1) `[get]` |
| float | [TotalDistance](class_tale_worlds_1_1_engine_1_1_path.html#aa2db62b0fee8b0b3a738025fa6eadca1) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_engine_1_1_path.html#a0c1dba5a24f8cb476be23d7932426ebd)GetHermiteFrameForDt()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Path.GetHermiteFrameForDt | ( | float | *phase*, |
|  |  | int | *first\_point* ) |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#a5cc8e0629747f630fbae2b47cae41684)GetFrameForDistance()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Path.GetFrameForDistance | ( | float | *distance* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#ad4b02ea8f37e92151d9b5793035680be)GetNearestFrameWithValidAlphaForDistance()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Engine.Path.GetNearestFrameWithValidAlphaForDistance | ( | float | *distance*, |
|  |  | bool | *searchForward* = true, |
|  |  | float | *alphaThreshold* = 0::5f ) |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#a3a6bb3997d42e43f8ce1a7066857cb60)GetFrameAndColorForDistance()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Path.GetFrameAndColorForDistance | ( | float | *distance*, |
|  |  | out [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *color* ) |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#adbe2f0302d5de6a2c9525fa1daa17cfe)GetArcLength()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Path.GetArcLength | ( | int | *first\_point* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#a933f1bf88b559a94551952e044ecd621)GetPoints()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Path.GetPoints | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html)[] | *points* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#ab049d9c806974c94140ecb047e7933b7)GetTotalLength()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Engine.Path.GetTotalLength | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#a33d40fc36767c443362fc4296ddbded3)GetVersion()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Path.GetVersion | ( |  | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#a17b2dee532d9284c4c9f22bb3996c1b9)SetFrameOfPoint()
--------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Path.SetFrameOfPoint | ( | int | *pointIndex*, |
|  |  | ref [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#af139f0fc14be34209f500beb2df91bc2)SetTangentPositionOfPoint()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Engine.Path.SetTangentPositionOfPoint | ( | int | *pointIndex*, |
|  |  | int | *tangentIndex*, |
|  |  | ref [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position* ) |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#a2b3ba5ea30254a71fad10cf595b4ebea)AddPathPoint()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.Engine.Path.AddPathPoint | ( | int | *newNodeIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#ab2565e27a8c10f357fef1d4d7fc4b289)DeletePathPoint()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Engine.Path.DeletePathPoint | ( | int | *nodeIndex* | ) |  |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#a558d5d56225fe096aef43090b4f7249f)HasValidAlphaAtPathPoint()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Engine.Path.HasValidAlphaAtPathPoint | ( | int | *nodeIndex*, |
|  |  | float | *alphaThreshold* = 0::5f ) |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#abdb9ef7a27ebbf302ea73ef0c23689b8)GetName()
------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Engine.Path.GetName | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_engine_1_1_path.html#ab6b02ce185a676a3fe578d9832a27fe1)NumberOfPoints
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Engine.Path.NumberOfPoints | | get |

[◆](class_tale_worlds_1_1_engine_1_1_path.html#aa2db62b0fee8b0b3a738025fa6eadca1)TotalDistance
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Engine.Path.TotalDistance | | get |

