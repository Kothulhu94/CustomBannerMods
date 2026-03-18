--- SOURCE: struct_tale_worlds_1_1_library_1_1_transformation.html ---

TaleWorlds.Library.Transformation Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) origin, [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) rotation, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) scale) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [TransformToParent](struct_tale_worlds_1_1_library_1_1_transformation.html#ad3adb7e4f1ec411218ca2c9f2a548ad4) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) v) |
| [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) | [TransformToParent](struct_tale_worlds_1_1_library_1_1_transformation.html#af36b003b85e1f64849747d966b7e2bef) ([Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) t) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [TransformToLocal](struct_tale_worlds_1_1_library_1_1_transformation.html#a8c9424bc3329325fecf63236ffb7f551) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) v) |
| [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) | [TransformToLocal](struct_tale_worlds_1_1_library_1_1_transformation.html#a8cd4865e49ac56cac53f69e8ba0d513d) ([Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) t) |
| void | [Rotate](struct_tale_worlds_1_1_library_1_1_transformation.html#ac2d67f2454315fadf3ff2e63a2545c00) (float radian, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) axis) |
| void | [ApplyScale](struct_tale_worlds_1_1_library_1_1_transformation.html#a8fe5ee2591cf05c827f8ec536c99660e) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) vec3) |
| override bool | [Equals](struct_tale_worlds_1_1_library_1_1_transformation.html#ab5e7f107699014fcdcf402bdd0dc537d) (object obj) |
| override int | [GetHashCode](struct_tale_worlds_1_1_library_1_1_transformation.html#a1317c6b84e31f01cb0e8dff337236668) () |
| override string | [ToString](struct_tale_worlds_1_1_library_1_1_transformation.html#aa584422473f8b3758c7c8bcf1b1eb56d) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) | [CreateFromMatrixFrame](struct_tale_worlds_1_1_library_1_1_transformation.html#a05002490a33c35270b4dd80c66a2e9a0) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) matrixFrame) |
| static [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) | [CreateFromRotation](struct_tale_worlds_1_1_library_1_1_transformation.html#addc00a387f4c4cac88f9de708f288c09) ([Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) rotation) |
| static bool | [operator==](struct_tale_worlds_1_1_library_1_1_transformation.html#a3c763ef45888d014da41451c3f9363b4) ([Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) t1, [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) t2) |
| static bool | [operator!=](struct_tale_worlds_1_1_library_1_1_transformation.html#a254c5479dc13f07163fe03759b52f577) ([Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) t1, [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) t2) |

|  |  |
| --- | --- |
| Public Attributes | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Origin](struct_tale_worlds_1_1_library_1_1_transformation.html#a1cf73bb9b84ae637b53b460bafcbfec1) |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | [Rotation](struct_tale_worlds_1_1_library_1_1_transformation.html#aa625dc26c2f2ed67b7bd4ab0120ccc3b) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Scale](struct_tale_worlds_1_1_library_1_1_transformation.html#afb24461daf30cf23eface03411e14599) |

|  |  |
| --- | --- |
| Properties | |
| static [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) | [Identity](struct_tale_worlds_1_1_library_1_1_transformation.html#a952a41490cca50c81d7fc97506ce5460) `[get]` |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | [AsMatrixFrame](struct_tale_worlds_1_1_library_1_1_transformation.html#a00d274e9c2191d46f846ad0add071a9b) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae)Transformation()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Transformation.Transformation | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *origin*, |
|  |  | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | *rotation*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *scale* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#a05002490a33c35270b4dd80c66a2e9a0)CreateFromMatrixFrame()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) TaleWorlds.Library.Transformation.CreateFromMatrixFrame | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *matrixFrame* | ) |  | | static |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#addc00a387f4c4cac88f9de708f288c09)CreateFromRotation()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) TaleWorlds.Library.Transformation.CreateFromRotation | ( | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | *rotation* | ) |  | | static |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#ad3adb7e4f1ec411218ca2c9f2a548ad4)TransformToParent() [1/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Transformation.TransformToParent | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *v* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#af36b003b85e1f64849747d966b7e2bef)TransformToParent() [2/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) TaleWorlds.Library.Transformation.TransformToParent | ( | [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) | *t* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#a8c9424bc3329325fecf63236ffb7f551)TransformToLocal() [1/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Transformation.TransformToLocal | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *v* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#a8cd4865e49ac56cac53f69e8ba0d513d)TransformToLocal() [2/2]
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) TaleWorlds.Library.Transformation.TransformToLocal | ( | [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) | *t* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#ac2d67f2454315fadf3ff2e63a2545c00)Rotate()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.Transformation.Rotate | ( | float | *radian*, |
|  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *axis* ) |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#a3c763ef45888d014da41451c3f9363b4)operator==()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Transformation.operator== | ( | [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) | *t1*, | |  |  | [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) | *t2* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#a8fe5ee2591cf05c827f8ec536c99660e)ApplyScale()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Transformation.ApplyScale | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *vec3* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#a254c5479dc13f07163fe03759b52f577)operator!=()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Transformation.operator!= | ( | [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) | *t1*, | |  |  | [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) | *t2* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#ab5e7f107699014fcdcf402bdd0dc537d)Equals()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Library.Transformation.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#a1317c6b84e31f01cb0e8dff337236668)GetHashCode()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Library.Transformation.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#aa584422473f8b3758c7c8bcf1b1eb56d)ToString()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Library.Transformation.ToString | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#a1cf73bb9b84ae637b53b460bafcbfec1)Origin
---------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Transformation.Origin |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#aa625dc26c2f2ed67b7bd4ab0120ccc3b)Rotation
-----------------------------------------------------------------------------------------------------

|  |
| --- |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) TaleWorlds.Library.Transformation.Rotation |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#afb24461daf30cf23eface03411e14599)Scale
--------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Transformation.Scale |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#a952a41490cca50c81d7fc97506ce5460)Identity
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Transformation](struct_tale_worlds_1_1_library_1_1_transformation.html#afe4e15822cadf1f66f09209e8b54daae) TaleWorlds.Library.Transformation.Identity | | staticget |

[◆](struct_tale_worlds_1_1_library_1_1_transformation.html#a00d274e9c2191d46f846ad0add071a9b)AsMatrixFrame
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) TaleWorlds.Library.Transformation.AsMatrixFrame | | get |

