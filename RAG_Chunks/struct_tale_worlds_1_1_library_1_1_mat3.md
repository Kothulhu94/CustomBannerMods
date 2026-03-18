--- SOURCE: struct_tale_worlds_1_1_library_1_1_mat3.html ---

TaleWorlds.Library.Mat3 Struct Reference3x3 Matrix class for 3d graphics.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) [s](struct_tale_worlds_1_1_library_1_1_mat3.html#a60dfa2c8100845a4a4b18c1bab4234af), in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) [f](struct_tale_worlds_1_1_library_1_1_mat3.html#a8fcff40b40fae49df98eee5c6f80408a), in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) [u](struct_tale_worlds_1_1_library_1_1_mat3.html#ad7a643f21f346b3cd1dcd500b7095b26)) |
|  | Initializes a new instance of matrix. |
|  | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#adb43b4e36db25715f6b34d14a90aeeff) (float sx, float sy, float sz, float fx, float fy, float fz, float ux, float uy, float uz) |
|  | Initializes a new instance of matrix. |
| void | [RotateAboutSide](struct_tale_worlds_1_1_library_1_1_mat3.html#a1d2bac689983ebfcb1aaea69aeed062d) (float a) |
|  | Rotates about side/x-axis. Applies pitch rotation. |
| void | [RotateAboutForward](struct_tale_worlds_1_1_library_1_1_mat3.html#ae1e0f55a3e727ea86f70ff56ba30ef05) (float a) |
|  | Rotates about forward/y-axis. Applies roll rotation. |
| void | [RotateAboutUp](struct_tale_worlds_1_1_library_1_1_mat3.html#a163e7cebfaa67c8038a7618d5ab58ec3) (float a) |
|  | Rotates about up/z-axis. Applies yaw rotation. |
| void | [RotateAboutAnArbitraryVector](struct_tale_worlds_1_1_library_1_1_mat3.html#af0ff3fba2cf0b0c734145b76d12df8c6) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) v, float a) |
|  | Rotates about the param vector. |
| bool | [IsOrthonormal](struct_tale_worlds_1_1_library_1_1_mat3.html#aa93ede0a230976d1c5cf10aa4c0b9b78) () |
|  | Determines whether the matrix is orthonormal. |
| bool | [IsLeftHanded](struct_tale_worlds_1_1_library_1_1_mat3.html#a84632d2e4327fd084971b640e4daf67c) () |
| bool | [NearlyEquals](struct_tale_worlds_1_1_library_1_1_mat3.html#a52b17701b27979ec650e177303857b46) (in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) rhs, float epsilon=MBMath.Epsilon) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [TransformToParent](struct_tale_worlds_1_1_library_1_1_mat3.html#acad3ca4058ed295297376814b1ce9e70) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) v) |
|  | Transforms vector to parent frame. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [TransformToParent](struct_tale_worlds_1_1_library_1_1_mat3.html#a1a4fd7e055853aafb98f5772ed58bcf1) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) v) |
|  | Transforms vector to parent frame. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [TransformToLocal](struct_tale_worlds_1_1_library_1_1_mat3.html#afc5b00b088c09866e1b1898a2b5a7393) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) v) |
|  | Transforms vector to local frame. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [TransformToLocal](struct_tale_worlds_1_1_library_1_1_mat3.html#a0b9bac064c21342131ea46128f8a82d1) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) v) |
|  | Transforms vector to local frame. |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | [TransformToParent](struct_tale_worlds_1_1_library_1_1_mat3.html#a1b735dfb4a3728c56a2d27e22c9fc276) (in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) m) |
|  | Transforms matrix to parent frame. |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | [TransformToLocal](struct_tale_worlds_1_1_library_1_1_mat3.html#a4700fda171991fe8d140b5af70bb9410) (in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) m) |
|  | Transforms matrix to local frame. |
| void | [Orthonormalize](struct_tale_worlds_1_1_library_1_1_mat3.html#a5a884f45abc53a2cc88569c2fce5a017) () |
|  | Orthonormalizes the matrix. |
| void | [OrthonormalizeAccordingToForwardAndKeepUpAsZAxis](struct_tale_worlds_1_1_library_1_1_mat3.html#aff3a4f485467404155b0be04ac0c87fb) () |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | [GetUnitRotation](struct_tale_worlds_1_1_library_1_1_mat3.html#a01dcfe14ad520382e884c2c9278c05b3) (float removedScale) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [MakeUnit](struct_tale_worlds_1_1_library_1_1_mat3.html#a2ffbaff2e96bf03ff3e2c259d53e348e) () |
| bool | [IsUnit](struct_tale_worlds_1_1_library_1_1_mat3.html#a8ee639fcd185c454206db3d1264bd1fe) () |
| void | [ApplyScaleLocal](struct_tale_worlds_1_1_library_1_1_mat3.html#a2aba0f2ecfa81e7188f8bc308227fe8a) (float scaleAmount) |
|  | Scales the matrix by scaleAmount. |
| void | [ApplyScaleLocal](struct_tale_worlds_1_1_library_1_1_mat3.html#a68a7377be4948488df9ee2a77d16b3fe) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) scaleAmountXYZ) |
|  | Scales the matrix by scaleAmountXYZ vector. |
| bool | [HasScale](struct_tale_worlds_1_1_library_1_1_mat3.html#a0ef0ac0f6e6013044ccbbee1db1922e9) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetScaleVector](struct_tale_worlds_1_1_library_1_1_mat3.html#a11841ea712678197c5768ea5adae61bd) () |
|  | Get scale amounts of each component. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetScaleVectorSquared](struct_tale_worlds_1_1_library_1_1_mat3.html#acd952268041837363c0be84c826f7e04) () |
|  | Get scale squared amounts of each component. |
| void | [ToQuaternion](struct_tale_worlds_1_1_library_1_1_mat3.html#af92763112e1af7103175d4aeba84afa1) (out [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html) quat) |
| [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html) | [ToQuaternion](struct_tale_worlds_1_1_library_1_1_mat3.html#a5a07e324035aa0da284d56dd57493d42) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetEulerAngles](struct_tale_worlds_1_1_library_1_1_mat3.html#a3bd969dfce3b16fde35b9e1f1c198817) () |
|  | Calculates the angular orientation of the matrix with respect to XYZ axes. |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | [Transpose](struct_tale_worlds_1_1_library_1_1_mat3.html#a4a23b0dc5eda39e7eabeaec42af962e3) () |
|  | Create a transposed matrix. |
| override string | [ToString](struct_tale_worlds_1_1_library_1_1_mat3.html#a79985cadebcc6eabc3d2dca1665df2f9) () |
|  | Creates readable string representation. |
| override bool | [Equals](struct_tale_worlds_1_1_library_1_1_mat3.html#aec323cfd4c2740e60bca84fcac1a679b) (object obj) |
|  | Determines whether the specified generic object is equal to this instance. |
| override int | [GetHashCode](struct_tale_worlds_1_1_library_1_1_mat3.html#ad2d167c8a152a7143b25ae59563a6d8e) () |
|  | Returns a hash code for this instance. |
| bool | [IsIdentity](struct_tale_worlds_1_1_library_1_1_mat3.html#a11a68a26bbc901648a5b748dbf676524) () |
| bool | [IsZero](struct_tale_worlds_1_1_library_1_1_mat3.html#ac72c044cdd8feb198637d34034eb82fe) () |
| bool | [IsUniformScaled](struct_tale_worlds_1_1_library_1_1_mat3.html#acb3c354ef916f3d134daf17ba5c90ad0) () |
| void | [ApplyEulerAngles](struct_tale_worlds_1_1_library_1_1_mat3.html#a0b70b12a96d06333d670cd2e498dbc12) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) eulerAngles) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | [Lerp](struct_tale_worlds_1_1_library_1_1_mat3.html#a1b1e27239b1e0f876c4ae1ec8d56a9bd) (in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) m1, in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) m2, float alpha) |
| static [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | [LerpNonOrthogonal](struct_tale_worlds_1_1_library_1_1_mat3.html#a4e7b6cd452980781d55e87ab64280710) (in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) m1, in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) m2, float alpha) |
| static [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | [CreateMat3WithForward](struct_tale_worlds_1_1_library_1_1_mat3.html#adc8db17ee973598cbf2d280db1b1703c) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) direction) |
|  | Creates a new rotation matrix which has its forward axis aligned with the given direction. Uses global up vector (0,0,1) if global up is not aligned with the given direction to determine perpendicular frame directions If global up and direction are aligned, uses the global forward vector (0,1,0) for the same purpose. |
| static [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | [CreateDiagonalMat3](struct_tale_worlds_1_1_library_1_1_mat3.html#a549db1ee7bbdb6a0565a62bf96f7aad9) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) diagonalData) |
| static [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | [operator\*](struct_tale_worlds_1_1_library_1_1_mat3.html#a14d3b6071dab0743780536640b9fdc3b) (in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) v, float a) |
|  | Implements matrix scalar product. |
| static bool | [operator==](struct_tale_worlds_1_1_library_1_1_mat3.html#ab2557735fc0d89a106f4e65a9d1e71c9) (in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) m1, in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) m2) |
|  | Implements the operator ==. |
| static bool | [operator!=](struct_tale_worlds_1_1_library_1_1_mat3.html#a34e8a0ff9551ee52bc45c78cf87c7eef) (in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) m1, in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) m2) |
|  | Implements the operator !=. |

|  |  |
| --- | --- |
| Public Attributes | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [s](struct_tale_worlds_1_1_library_1_1_mat3.html#a60dfa2c8100845a4a4b18c1bab4234af) |
|  | Side vector, also x axis. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [f](struct_tale_worlds_1_1_library_1_1_mat3.html#a8fcff40b40fae49df98eee5c6f80408a) |
|  | Forward vector, also y axis. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [u](struct_tale_worlds_1_1_library_1_1_mat3.html#ad7a643f21f346b3cd1dcd500b7095b26) |
|  | Up vector, also z axis. |

|  |  |
| --- | --- |
| Properties | |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [this[int i]](struct_tale_worlds_1_1_library_1_1_mat3.html#a0b42bde1acb3a0b8ee0352c22ba77a4a) `[get, set]` |
|  | Implements indexer operation. |
| static [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | [Identity](struct_tale_worlds_1_1_library_1_1_mat3.html#ae7f29f86be4d8d25cbd335d90ffdf725) `[get]` |
|  | Returns a identity matrix. |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466)Mat3() [1/2]
-----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Mat3.Mat3 | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *s*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *f*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *u* ) |

Parameters
:   |  |  |
    | --- | --- |
    | s | The side axis. |
    | f | The forward axis. |
    | u | The up axis. |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#adb43b4e36db25715f6b34d14a90aeeff)Mat3() [2/2]
-----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Mat3.Mat3 | ( | float | *sx*, |
|  |  | float | *sy*, |
|  |  | float | *sz*, |
|  |  | float | *fx*, |
|  |  | float | *fy*, |
|  |  | float | *fz*, |
|  |  | float | *ux*, |
|  |  | float | *uy*, |
|  |  | float | *uz* ) |

Parameters
:   |  |  |
    | --- | --- |
    | sx | The side.x. |
    | sy | The side.y. |
    | sz | The side.z. |
    | fx | The forward.x. |
    | fy | The forward.y. |
    | fz | The forward.z. |
    | ux | The up.x. |
    | uy | The up.y. |
    | uz | The up.z. |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a1d2bac689983ebfcb1aaea69aeed062d)RotateAboutSide()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Mat3.RotateAboutSide | ( | float | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | The amount, in radians, in which to rotate around the x-axis. |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#ae1e0f55a3e727ea86f70ff56ba30ef05)RotateAboutForward()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Mat3.RotateAboutForward | ( | float | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | The amount, in radians, in which to rotate around the y-axis. |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a163e7cebfaa67c8038a7618d5ab58ec3)RotateAboutUp()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Mat3.RotateAboutUp | ( | float | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | The amount, in radians, in which to rotate around the z-axis. |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#af0ff3fba2cf0b0c734145b76d12df8c6)RotateAboutAnArbitraryVector()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.Mat3.RotateAboutAnArbitraryVector | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *v*, |
|  |  | float | *a* ) |

Parameters
:   |  |  |
    | --- | --- |
    | v | The vector to be rotated about. |
    | a | The amount, in radians, in which to rotate around the param vector. |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#aa93ede0a230976d1c5cf10aa4c0b9b78)IsOrthonormal()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.Mat3.IsOrthonormal | ( |  | ) |  |

Returns
:   `true` if the matrix is orthonormal; otherwise, `false`.

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a84632d2e4327fd084971b640e4daf67c)IsLeftHanded()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.Mat3.IsLeftHanded | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a52b17701b27979ec650e177303857b46)NearlyEquals()
-------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.Mat3.NearlyEquals | ( | in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | *rhs*, |
|  |  | float | *epsilon* = MBMath::Epsilon ) |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#acad3ca4058ed295297376814b1ce9e70)TransformToParent() [1/3]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Mat3.TransformToParent | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *v* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | v | Vector in local frame. |

Returns
:   Vector in parent frame.

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a1a4fd7e055853aafb98f5772ed58bcf1)TransformToParent() [2/3]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Library.Mat3.TransformToParent | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *v* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | v | Vector in local frame. |

Returns
:   Vector in parent frame.

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#afc5b00b088c09866e1b1898a2b5a7393)TransformToLocal() [1/3]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Mat3.TransformToLocal | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *v* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | v | Vector in parent frame. |

Returns
:   Vector in local frame.

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a0b9bac064c21342131ea46128f8a82d1)TransformToLocal() [2/3]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Library.Mat3.TransformToLocal | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *v* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | v | Vector in parent frame. |

Returns
:   Vector in local frame.

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a1b735dfb4a3728c56a2d27e22c9fc276)TransformToParent() [3/3]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) TaleWorlds.Library.Mat3.TransformToParent | ( | in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | *m* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | m | Matrix in local frame. |

Returns
:   Matrix in parent frame.

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a4700fda171991fe8d140b5af70bb9410)TransformToLocal() [3/3]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) TaleWorlds.Library.Mat3.TransformToLocal | ( | in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | *m* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | m | Matrix in parent frame. |

Returns
:   Matrix in local frame.

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a5a884f45abc53a2cc88569c2fce5a017)Orthonormalize()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Mat3.Orthonormalize | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#aff3a4f485467404155b0be04ac0c87fb)OrthonormalizeAccordingToForwardAndKeepUpAsZAxis()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Mat3.OrthonormalizeAccordingToForwardAndKeepUpAsZAxis | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a01dcfe14ad520382e884c2c9278c05b3)GetUnitRotation()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) TaleWorlds.Library.Mat3.GetUnitRotation | ( | float | *removedScale* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a2ffbaff2e96bf03ff3e2c259d53e348e)MakeUnit()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Mat3.MakeUnit | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a8ee639fcd185c454206db3d1264bd1fe)IsUnit()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.Mat3.IsUnit | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a2aba0f2ecfa81e7188f8bc308227fe8a)ApplyScaleLocal() [1/2]
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Mat3.ApplyScaleLocal | ( | float | *scaleAmount* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | scaleAmount | The scale amount. |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a68a7377be4948488df9ee2a77d16b3fe)ApplyScaleLocal() [2/2]
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Mat3.ApplyScaleLocal | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *scaleAmountXYZ* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | scaleAmountXYZ | The scale amount. |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a0ef0ac0f6e6013044ccbbee1db1922e9)HasScale()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.Mat3.HasScale | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a11841ea712678197c5768ea5adae61bd)GetScaleVector()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Mat3.GetScaleVector | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#acd952268041837363c0be84c826f7e04)GetScaleVectorSquared()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Mat3.GetScaleVectorSquared | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#af92763112e1af7103175d4aeba84afa1)ToQuaternion() [1/2]
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Mat3.ToQuaternion | ( | out [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html) | *quat* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a5a07e324035aa0da284d56dd57493d42)ToQuaternion() [2/2]
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html) TaleWorlds.Library.Mat3.ToQuaternion | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a1b1e27239b1e0f876c4ae1ec8d56a9bd)Lerp()
-----------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) TaleWorlds.Library.Mat3.Lerp | ( | in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | *m1*, | |  |  | in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | *m2*, | |  |  | float | *alpha* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a4e7b6cd452980781d55e87ab64280710)LerpNonOrthogonal()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) TaleWorlds.Library.Mat3.LerpNonOrthogonal | ( | in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | *m1*, | |  |  | in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | *m2*, | |  |  | float | *alpha* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#adc8db17ee973598cbf2d280db1b1703c)CreateMat3WithForward()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) TaleWorlds.Library.Mat3.CreateMat3WithForward | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *direction* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | direction | Is the forward direction. |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a549db1ee7bbdb6a0565a62bf96f7aad9)CreateDiagonalMat3()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) TaleWorlds.Library.Mat3.CreateDiagonalMat3 | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *diagonalData* | ) |  | | static |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a3bd969dfce3b16fde35b9e1f1c198817)GetEulerAngles()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Mat3.GetEulerAngles | ( |  | ) |  |

Returns
:   Each axis's rotation angle is wrapped in the vector's corresponding component.

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a4a23b0dc5eda39e7eabeaec42af962e3)Transpose()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) TaleWorlds.Library.Mat3.Transpose | ( |  | ) |  |

Returns

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a14d3b6071dab0743780536640b9fdc3b)operator\*()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) TaleWorlds.Library.Mat3.operator\* | ( | in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | *v*, | |  |  | float | *a* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | v | The matrix. |
    | a | Scalar. |

Returns
:   The result of the operator.

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#ab2557735fc0d89a106f4e65a9d1e71c9)operator==()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Mat3.operator== | ( | in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | *m1*, | |  |  | in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | *m2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | m1 | The m1. |
    | m2 | The m2. |

Returns
:   The result of the operator.

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a34e8a0ff9551ee52bc45c78cf87c7eef)operator!=()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Mat3.operator!= | ( | in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | *m1*, | |  |  | in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) | *m2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | m1 | The m1. |
    | m2 | The m2. |

Returns
:   The result of the operator.

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a79985cadebcc6eabc3d2dca1665df2f9)ToString()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Library.Mat3.ToString | ( |  | ) |  |

Returns
:   Output string

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#aec323cfd4c2740e60bca84fcac1a679b)Equals()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Library.Mat3.Equals | ( | object | *obj* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | obj | The generic object to compare with this instance. |

Returns
:   `true` if the specified generic object is equal to this instance; otherwise, `false`.

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#ad2d167c8a152a7143b25ae59563a6d8e)GetHashCode()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Library.Mat3.GetHashCode | ( |  | ) |  |

Returns
:   A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a11a68a26bbc901648a5b748dbf676524)IsIdentity()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.Mat3.IsIdentity | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#ac72c044cdd8feb198637d34034eb82fe)IsZero()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.Mat3.IsZero | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#acb3c354ef916f3d134daf17ba5c90ad0)IsUniformScaled()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.Mat3.IsUniformScaled | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a0b70b12a96d06333d670cd2e498dbc12)ApplyEulerAngles()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Mat3.ApplyEulerAngles | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *eulerAngles* | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a60dfa2c8100845a4a4b18c1bab4234af)s
------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Mat3.s |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a8fcff40b40fae49df98eee5c6f80408a)f
------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Mat3.f |

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#ad7a643f21f346b3cd1dcd500b7095b26)u
------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Mat3.u |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#a0b42bde1acb3a0b8ee0352c22ba77a4a)this[int i]
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Mat3.this[int i] | | getset |

return s if i = 0 return f if i = 1 return u if i = 2

[◆](struct_tale_worlds_1_1_library_1_1_mat3.html#ae7f29f86be4d8d25cbd335d90ffdf725)Identity
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html#ada0058f649484843c8f6d51813cc4466) TaleWorlds.Library.Mat3.Identity | | staticget |

Returns

