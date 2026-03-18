--- SOURCE: struct_tale_worlds_1_1_library_1_1_matrix_frame.html ---

TaleWorlds.Library.MatrixFrame Struct ReferenceDefines Matrix frame class for a coordinate frame.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) (in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) rot, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) o) |
|  | Initializes a new instance of matrix frame. |
|  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a10d76e0b05999ec897dab60534532477) (float \_11, float \_12, float \_13, float \_21, float \_22, float \_23, float \_31, float \_32, float \_33, float \_41, float \_42, float \_43) |
|  | Initializes a new instance of matrix frame from a 4x3 matrix(in flat form). |
|  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#abddeb8f36cb19221b383d4bf17a39e60) (float \_11, float \_12, float \_13, float \_14, float \_21, float \_22, float \_23, float \_24, float \_31, float \_32, float \_33, float \_34, float \_41, float \_42, float \_43, float \_44) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [TransformToParent](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a74fa6f0dad031a12c54990c7d63f92d5) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) v) |
|  | Transforms vector to parent frame. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [TransformToParentDouble](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a227089b3a5f3a1df4be6d9ec0718409b) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) v) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [TransformToParent](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a33a02fc2d407b2a9d499b0ef83759537) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) v) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [TransformToLocal](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a8b15c8a1944e56b7da3631c7ea2c6ff4) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) v) |
|  | Transforms vector to local frame. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [TransformToLocalNonUnit](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#ac094dff2fbb4df07a73580e6d8a1ac43) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) v) |
| bool | [NearlyEquals](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aa6b1e19b9d9119c79f46261e42ad74cd) ([MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) rhs, float epsilon=MBMath.Epsilon) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [TransformToLocalNonOrthogonal](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#ace2ae060f4dd13ce2fa5f625c24c42f6) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) v) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [TransformToLocalNonOrthogonal](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#ab8f2c6495e256c7126e6295735f56d0b) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) frame) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [TransformToParent](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a223943ad5917699d8e4522216fcdfd48) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m) |
|  | Transforms a matrix frame to parent frame. |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [TransformToLocal](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a49c84ead42834d076bbdbbf943880429) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m) |
|  | Transforms matrix frame to local frame. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [TransformToParentWithW](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#af1ed6158ab32567ff8c57e5eb4604996) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) \_s) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [GetUnitRotFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a860e71662636d31207930ccfbf2b9b4d) (float removedScale) |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [InverseFast](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a738ecaf700d8a79e1d9ab7ab3260170c) () |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [Inverse](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aa4b9ae2e6657a16c5a9b4cceebd52d85) () |
| float | [Determinant4X4](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a15722ad1f075a1ff0a33d6b3eef70a27) () |
| void | [Rotate](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a8e247816c563ef6a914ed8090cb276bc) (float radian, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) axis) |
| override string | [ToString](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aecce97fc655b6faf26a8ca3682137d14) () |
|  | Creates readable string representation. |
| override bool | [Equals](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#ad26e18e4093889032ab7e659833dc82d) (object obj) |
|  | Determines whether the specified generic object is equal to this instance. |
| override int | [GetHashCode](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aa1505454b99bb30f9c75c7f1b31350fb) () |
|  | Returns a hash code for this instance. |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [Strafe](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aac048de7f5853b9e0fe1ba32eb623a60) (float a) |
|  | Moves the origin on the local x-coordinate of the frame. |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [Advance](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#abcc1e9bb9d72f5a675758e84e9c5b9d0) (float a) |
|  | Moves the origin on the local y-coordinate of the frame. |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [Elevate](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a033cc84b60b7d8633147a1a4365b08d0) (float a) |
|  | Moves the origin on the local z-coordinate of the frame. |
| void | [Scale](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aaadc3c2adc37fae7fbb702d0a476257c) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) scalingVector) |
|  | Scales the matrix frame according to scaling vector. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetScale](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#ae04b9a8cd10ef7a5e556dddfa2715a30) () |
| void | [Fill](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3c1e2d681f78398040a854a43f2d5811) () |
| void | [AssertFilled](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a33bce4c6a6df5e20ebd3490c233a9a64) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [Lerp](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#ae57ddeb423455c2080244dbf3dc96b47) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m1, in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m2, float alpha) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [LerpNonOrthogonal](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a508187d8361a074122602e64e11063a9) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m1, in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m2, float alpha) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [Slerp](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a7113549b6ff5c2381547d89aa2b41bca) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m1, in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m2, float alpha) |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [operator\*](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a7b2a0a125cda26e99641220a8bb092f9) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m1, in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m2) |
|  | Implements the operator \*. |
| static bool | [operator==](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3060ab9d59575b32509f790a3e01cb1e) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m1, in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m2) |
|  | Implements the operator ==. |
| static bool | [operator!=](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#afb709658cbc5b4b30b67fe24e2b29600) (in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m1, in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) m2) |
|  | Implements the operator !=. |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [CreateLookAt](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a883ccb27f2c0301e254ae0057e3d655f) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) position, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) target, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) upVector) |
|  | Builds a left-handed look-at matrix. |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [CenterFrameOfTwoPoints](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a85b22e5de6b3b2046ced7cee29dc06ab) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p1, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) p2, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) upVector) |

|  |  |
| --- | --- |
| Public Attributes | |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | [rotation](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a8d3d5720bd9358e9435ceac05664b8c0) |
|  | Rotation matrix. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [origin](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3417c099c0dd87215427eaab30d07ebe) |
|  | Origin of coordinate frame wrt to parent frame. |

|  |  |
| --- | --- |
| Properties | |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [Identity](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aa0224252b43a11ad02df3be037aa7a7a) `[get]` |
|  | Gets an identity frame. |
| static [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | [Zero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15) `[get]` |
| bool | [IsIdentity](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a7fe61769d6144123f8b046f74397472d) `[get]` |
| bool | [IsZero](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#adf74f2d309250673a6b2ad7442cb8089) `[get]` |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [this[int i]](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a05098ce737175c2288bce1825be2a729) `[get, set]` |
| float | [this[int i, int j]](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#acf52bf80284f2a3bf2b05bdb49ca9c3a) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb)MatrixFrame() [1/3]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.MatrixFrame.MatrixFrame | ( | in [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | *rot*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *o* ) |

Parameters
:   |  |  |
    | --- | --- |
    | rot | The rotation matrix. |
    | o | The origin point. |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a10d76e0b05999ec897dab60534532477)MatrixFrame() [2/3]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.MatrixFrame.MatrixFrame | ( | float | *\_11*, |
|  |  | float | *\_12*, |
|  |  | float | *\_13*, |
|  |  | float | *\_21*, |
|  |  | float | *\_22*, |
|  |  | float | *\_23*, |
|  |  | float | *\_31*, |
|  |  | float | *\_32*, |
|  |  | float | *\_33*, |
|  |  | float | *\_41*, |
|  |  | float | *\_42*, |
|  |  | float | *\_43* ) |

Parameters
:   |  |  |
    | --- | --- |
    | \_11 | The \_11. |
    | \_12 | The \_12. |
    | \_13 | The \_13. |
    | \_21 | The \_21. |
    | \_22 | The \_22. |
    | \_23 | The \_23. |
    | \_31 | The \_31. |
    | \_32 | The \_32. |
    | \_33 | The \_33. |
    | \_41 | The \_41. |
    | \_42 | The \_42. |
    | \_43 | The \_43. |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#abddeb8f36cb19221b383d4bf17a39e60)MatrixFrame() [3/3]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.MatrixFrame.MatrixFrame | ( | float | *\_11*, |
|  |  | float | *\_12*, |
|  |  | float | *\_13*, |
|  |  | float | *\_14*, |
|  |  | float | *\_21*, |
|  |  | float | *\_22*, |
|  |  | float | *\_23*, |
|  |  | float | *\_24*, |
|  |  | float | *\_31*, |
|  |  | float | *\_32*, |
|  |  | float | *\_33*, |
|  |  | float | *\_34*, |
|  |  | float | *\_41*, |
|  |  | float | *\_42*, |
|  |  | float | *\_43*, |
|  |  | float | *\_44* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a74fa6f0dad031a12c54990c7d63f92d5)TransformToParent() [1/3]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MatrixFrame.TransformToParent | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *v* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | v | Vector in local frame. |

Returns
:   Vector in parent frame.

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a227089b3a5f3a1df4be6d9ec0718409b)TransformToParentDouble()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MatrixFrame.TransformToParentDouble | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *v* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a33a02fc2d407b2a9d499b0ef83759537)TransformToParent() [2/3]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Library.MatrixFrame.TransformToParent | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *v* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a8b15c8a1944e56b7da3631c7ea2c6ff4)TransformToLocal() [1/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MatrixFrame.TransformToLocal | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *v* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | v | Vector in parent frame. |

Returns
:   Vector in local frame.

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#ac094dff2fbb4df07a73580e6d8a1ac43)TransformToLocalNonUnit()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MatrixFrame.TransformToLocalNonUnit | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *v* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aa6b1e19b9d9119c79f46261e42ad74cd)NearlyEquals()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.MatrixFrame.NearlyEquals | ( | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *rhs*, |
|  |  | float | *epsilon* = MBMath::Epsilon ) |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#ace2ae060f4dd13ce2fa5f625c24c42f6)TransformToLocalNonOrthogonal() [1/2]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MatrixFrame.TransformToLocalNonOrthogonal | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *v* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#ab8f2c6495e256c7126e6295735f56d0b)TransformToLocalNonOrthogonal() [2/2]
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.TransformToLocalNonOrthogonal | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *frame* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#ae57ddeb423455c2080244dbf3dc96b47)Lerp()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.Lerp | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m1*, | |  |  | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m2*, | |  |  | float | *alpha* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a508187d8361a074122602e64e11063a9)LerpNonOrthogonal()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.LerpNonOrthogonal | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m1*, | |  |  | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m2*, | |  |  | float | *alpha* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a7113549b6ff5c2381547d89aa2b41bca)Slerp()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.Slerp | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m1*, | |  |  | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m2*, | |  |  | float | *alpha* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a223943ad5917699d8e4522216fcdfd48)TransformToParent() [3/3]
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.TransformToParent | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | m | Matrix frame in local frame. |

Returns
:   Matrix frame in parent frame.

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a49c84ead42834d076bbdbbf943880429)TransformToLocal() [2/2]
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.TransformToLocal | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | m | Matrix frame in parent frame. |

Returns
:   Matrix frame in local frame.

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#af1ed6158ab32567ff8c57e5eb4604996)TransformToParentWithW()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MatrixFrame.TransformToParentWithW | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *\_s* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a860e71662636d31207930ccfbf2b9b4d)GetUnitRotFrame()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.GetUnitRotFrame | ( | float | *removedScale* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a738ecaf700d8a79e1d9ab7ab3260170c)InverseFast()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.InverseFast | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aa4b9ae2e6657a16c5a9b4cceebd52d85)Inverse()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.Inverse | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a15722ad1f075a1ff0a33d6b3eef70a27)Determinant4X4()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Library.MatrixFrame.Determinant4X4 | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a8e247816c563ef6a914ed8090cb276bc)Rotate()
---------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.MatrixFrame.Rotate | ( | float | *radian*, |
|  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *axis* ) |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a7b2a0a125cda26e99641220a8bb092f9)operator\*()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.operator\* | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m1*, | |  |  | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | m1 | The m1. |
    | m2 | The m2. |

Returns
:   The result of the operator.

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3060ab9d59575b32509f790a3e01cb1e)operator==()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MatrixFrame.operator== | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m1*, | |  |  | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | m1 | The m1. |
    | m2 | The m2. |

Returns
:   The result of the operator.

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#afb709658cbc5b4b30b67fe24e2b29600)operator!=()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MatrixFrame.operator!= | ( | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m1*, | |  |  | in [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) | *m2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | m1 | The m1. |
    | m2 | The m2. |

Returns
:   The result of the operator.

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aecce97fc655b6faf26a8ca3682137d14)ToString()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Library.MatrixFrame.ToString | ( |  | ) |  |

Returns
:   Output string

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#ad26e18e4093889032ab7e659833dc82d)Equals()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Library.MatrixFrame.Equals | ( | object | *obj* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | obj | The generic object to compare with this instance. |

Returns
:   `true` if the specified generic object is equal to this instance; otherwise, `false`.

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aa1505454b99bb30f9c75c7f1b31350fb)GetHashCode()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Library.MatrixFrame.GetHashCode | ( |  | ) |  |

Returns
:   A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aac048de7f5853b9e0fe1ba32eb623a60)Strafe()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.Strafe | ( | float | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | Units to strafe |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#abcc1e9bb9d72f5a675758e84e9c5b9d0)Advance()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.Advance | ( | float | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | Units to advance |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a033cc84b60b7d8633147a1a4365b08d0)Elevate()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.Elevate | ( | float | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | Units to elevate |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aaadc3c2adc37fae7fbb702d0a476257c)Scale()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MatrixFrame.Scale | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *scalingVector* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | scalingVector | Units to scale |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#ae04b9a8cd10ef7a5e556dddfa2715a30)GetScale()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MatrixFrame.GetScale | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a883ccb27f2c0301e254ae0057e3d655f)CreateLookAt()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.CreateLookAt | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *position*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *target*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *upVector* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | position |  |
    | target |  |
    | upVector |  |

Returns

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a85b22e5de6b3b2046ced7cee29dc06ab)CenterFrameOfTwoPoints()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.CenterFrameOfTwoPoints | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p1*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *p2*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *upVector* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3c1e2d681f78398040a854a43f2d5811)Fill()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MatrixFrame.Fill | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a33bce4c6a6df5e20ebd3490c233a9a64)AssertFilled()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.MatrixFrame.AssertFilled | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a8d3d5720bd9358e9435ceac05664b8c0)rotation
---------------------------------------------------------------------------------------------------

|  |
| --- |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) TaleWorlds.Library.MatrixFrame.rotation |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3417c099c0dd87215427eaab30d07ebe)origin
-------------------------------------------------------------------------------------------------

|  |
| --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MatrixFrame.origin |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#aa0224252b43a11ad02df3be037aa7a7a)Identity
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.Identity | | staticget |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a3334fcb67f6967b227157c879ca90d15)Zero
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a125b28a4ee8ff5f76dc11367ec76c3fb) TaleWorlds.Library.MatrixFrame.Zero | | staticget |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a7fe61769d6144123f8b046f74397472d)IsIdentity
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.MatrixFrame.IsIdentity | | get |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#adf74f2d309250673a6b2ad7442cb8089)IsZero
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.MatrixFrame.IsZero | | get |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#a05098ce737175c2288bce1825be2a729)this[int i]
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MatrixFrame.this[int i] | | getset |

[◆](struct_tale_worlds_1_1_library_1_1_matrix_frame.html#acf52bf80284f2a3bf2b05bdb49ca9c3a)this[int i, int j]
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.MatrixFrame.this[int i, int j] | | getset |

