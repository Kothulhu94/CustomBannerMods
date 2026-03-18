--- SOURCE: struct_tale_worlds_1_1_library_1_1_vec2.html ---

TaleWorlds.Library.Vec2 Struct Reference2D vector class

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) (float a, float b) |
|  | Initializes a new instance of vector. |
|  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#a12e326b815a5e546c8b0a338816ca7a4) (Vec2 v) |
|  | Initializes a new instance of vector. |
|  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#a7f1eda9bae732248fc11d29266dcf930) (Vector2 v) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [ToVec3](struct_tale_worlds_1_1_library_1_1_vec2.html#a5fe385dbd1961ed670e4d65e690badfc) (float z=0.0f) |
| float | [Normalize](struct_tale_worlds_1_1_library_1_1_vec2.html#ab8160d2c924807459c492b5cf7407ebd) () |
|  | Normalizes vector. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [Normalized](struct_tale_worlds_1_1_library_1_1_vec2.html#ae8119a6d5e54cba2f965972ec697c955) () |
| void | [ClampMagnitude](struct_tale_worlds_1_1_library_1_1_vec2.html#a848e72d5297c2b70058268c7b0b10fe2) (float min, float max) |
| override bool | [Equals](struct_tale_worlds_1_1_library_1_1_vec2.html#a6b04b57b9bc96bbc8295354ecaf5feae) (object obj) |
|  | Determines whether the specified generic object is equal to this instance. |
| override int | [GetHashCode](struct_tale_worlds_1_1_library_1_1_vec2.html#abe2ee6eb7ab8aac6209e103b28d8ef91) () |
|  | Returns a hash code for this instance. |
| bool | [IsUnit](struct_tale_worlds_1_1_library_1_1_vec2.html#a36000f0817d36767ed48bc3a24a669c5) () |
| bool | [IsNonZero](struct_tale_worlds_1_1_library_1_1_vec2.html#a1961d599dc64cd7e0fa8ee70175366de) () |
| bool | [NearlyEquals](struct_tale_worlds_1_1_library_1_1_vec2.html#a8fbebf6494f103b0e1af7a001d6f62ae) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v, float epsilon=MBMath.Epsilon) |
|  | Checks if vector is nearly equals to another vector. |
| void | [RotateCCW](struct_tale_worlds_1_1_library_1_1_vec2.html#a8cf3798e38db45cdb1719ac07b143612) (float angleInRadians) |
|  | Rotates the vector in Counter-Clockwise direction by an angle. |
| float | [DotProduct](struct_tale_worlds_1_1_library_1_1_vec2.html#abba87b63d415fdcd94bac258fb97eb1d) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v) |
|  | Dot product of two vectors. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [TransformToLocalUnitF](struct_tale_worlds_1_1_library_1_1_vec2.html#a487e9f3aeb9a6ee502b945afb44c2782) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) a) |
|  | Transforms a vector to local. assumes vec is unit f vector. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [TransformToParentUnitF](struct_tale_worlds_1_1_library_1_1_vec2.html#ab154dae7896e49b426bf0f858955647b) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) a) |
|  | Transforms a vector to parent. assumes vec is unit f vector. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [TransformToLocalUnitFLeftHanded](struct_tale_worlds_1_1_library_1_1_vec2.html#a77d55d85198069b454ab58b604eb2bb2) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) a) |
|  | Transforms a vector to local. Uses left handed coordinate system. assumes vec is unit f vector. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [TransformToParentUnitFLeftHanded](struct_tale_worlds_1_1_library_1_1_vec2.html#ab47b195baf0d0de23be390940c92db44) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) a) |
|  | Transforms a vector to parent. Uses left handed coordinate system. assumes vec is unit f vector. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [RightVec](struct_tale_worlds_1_1_library_1_1_vec2.html#a32a24c5897bdd8e91876fe6441009376) () |
|  | 90 degrees rotated vector |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [LeftVec](struct_tale_worlds_1_1_library_1_1_vec2.html#abdfbdd52f39e2f046b53be02b00f1f21) () |
|  | -90 degrees rotated vector |
| override string | [ToString](struct_tale_worlds_1_1_library_1_1_vec2.html#a9294ccefbf293c0d11eb87c15b8a4b69) () |
| float | [DistanceSquared](struct_tale_worlds_1_1_library_1_1_vec2.html#a1d02b56ade5799b0aaaad39c71909ee0) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v) |
| float | [Distance](struct_tale_worlds_1_1_library_1_1_vec2.html#a0f3fca8487301a0987162aa7fb547054) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v) |
|  | The length of distance from v. |
| float | [DistanceToLineSegment](struct_tale_worlds_1_1_library_1_1_vec2.html#a768fbd3f1e22468d87edbae7ed5b6939) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) w, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) closestPointOnLineSegment) |
| float | [DistanceSquaredToLineSegment](struct_tale_worlds_1_1_library_1_1_vec2.html#a1277fbdd55d7c06844347935399ee686) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) w, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) closestPointOnLineSegment) |
| float | [AngleBetween](struct_tale_worlds_1_1_library_1_1_vec2.html#a587b233efd4a7339406a2c1c28a14676) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) vector2) |
|  | Returns the the angle in radians between this and the argument vectors. |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static | [operator Vector2](struct_tale_worlds_1_1_library_1_1_vec2.html#a6042d71626189a24e765be38e4569ce2) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) vec2) |
| static implicit | [operator Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#a9aaa8830683579ea2aaeb3b3f82990bd) (Vector2 vec2) |
| static WindingOrder | [GetWindingOrder](struct_tale_worlds_1_1_library_1_1_vec2.html#af4b50f96d1a0df7ec445489aa29daab9) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) first, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) second, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) third) |
| static float | [CCW](struct_tale_worlds_1_1_library_1_1_vec2.html#a96dd8826cd34a85c1559ed8314942d28) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) va, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) vb) |
|  | Counter-clockwise: 2-d version of cross product. Check sign of result. = |va|\*|vb|\*sin(counter-clockwise angle). |
| static bool | [operator==](struct_tale_worlds_1_1_library_1_1_vec2.html#aa2c1f87c2b3f28afc2bc7d70dbc51b50) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v2) |
| static bool | [operator!=](struct_tale_worlds_1_1_library_1_1_vec2.html#ac119752164cb25bfa93964b49837caf8) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v2) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [operator-](struct_tale_worlds_1_1_library_1_1_vec2.html#af1c5e1d58153cb962de565d8927848e5) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [operator+](struct_tale_worlds_1_1_library_1_1_vec2.html#aaa678a757c491373e32d489a22224354) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v2) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [operator-](struct_tale_worlds_1_1_library_1_1_vec2.html#af8881d7f5841e20060999f0f5b1ba4e5) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v2) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [operator\*](struct_tale_worlds_1_1_library_1_1_vec2.html#a2728279a7d3053b1a8785365ac77ebe5) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v, float f) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [operator\*](struct_tale_worlds_1_1_library_1_1_vec2.html#ac26d5a93cf752eb7f1555c64c9918cec) (float f, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [operator/](struct_tale_worlds_1_1_library_1_1_vec2.html#a212e2aff11b7c3df5325bcb7695d23d8) (float f, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [operator/](struct_tale_worlds_1_1_library_1_1_vec2.html#a0476fb7ff43554b7002ec7a673bd5d03) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v, float f) |
| static float | [DotProduct](struct_tale_worlds_1_1_library_1_1_vec2.html#abf2a5a6c057853a94e53777130c8cc9e) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) va, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) vb) |
|  | Dot product of two vectors. |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [ElementWiseProduct](struct_tale_worlds_1_1_library_1_1_vec2.html#a911b5393974474807f6fa1ed2ef81ff9) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) va, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) vb) |
|  | Element-wise product of two vectors. |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [FromRotation](struct_tale_worlds_1_1_library_1_1_vec2.html#a8b4acafaa2a839bef74ac130a2c0fcf5) (float rotation) |
|  | Creates a new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html "2D vector class") from the rotation angle. |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [Max](struct_tale_worlds_1_1_library_1_1_vec2.html#a2463d8436857d41250397c89c1491912) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v2) |
|  | Returns maximum of each component of two vectors. |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [Max](struct_tale_worlds_1_1_library_1_1_vec2.html#a2b120f42cb56d4667e22156cd8c12b80) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v1, float f) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [Min](struct_tale_worlds_1_1_library_1_1_vec2.html#a6ac3ab0553843db59771df6a92815834) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v2) |
|  | Returns minimum of each component of two vectors. |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [Min](struct_tale_worlds_1_1_library_1_1_vec2.html#adb4c1d865e77e67981a46fb3455133cd) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v1, float f) |
| static float | [DistanceToLine](struct_tale_worlds_1_1_library_1_1_vec2.html#a5bb76cf41556ae9d82d9c82d8ab9e0f5) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) line1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) line2, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) point) |
| static float | [DistanceToLineSegmentSquared](struct_tale_worlds_1_1_library_1_1_vec2.html#a5e04309b17aadedd9bd01125fcfff814) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) line1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) line2, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) point) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [Abs](struct_tale_worlds_1_1_library_1_1_vec2.html#aab8fe49a9420d241bbe2adc946aa33b9) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) vec) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [Lerp](struct_tale_worlds_1_1_library_1_1_vec2.html#a295fe616ef053324dcf0f55a1f696036) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) v2, float alpha) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [Slerp](struct_tale_worlds_1_1_library_1_1_vec2.html#a110b719101847470b4a73999f9744d39) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) start, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) end, float percent) |
| static float | [Determinant](struct_tale_worlds_1_1_library_1_1_vec2.html#a509bc15fe4ba0c7bbcf5d5f6d7985398) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) vec1, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) vec2) |
|  | Computes determinant of the matrix specified by two two-dimensional vectors. |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [x](struct_tale_worlds_1_1_library_1_1_vec2.html#a415e621acf0ea425bfc4ada755753fc9) |
|  | x component of the vector. |
| float | [y](struct_tale_worlds_1_1_library_1_1_vec2.html#a94e513bca0ba59d62270d16a3ee7ff8a) |
|  | y component of the vector. |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [Side](struct_tale_worlds_1_1_library_1_1_vec2.html#a4f40389127ecd89d68e09fc341bcf489) = new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6)(1, 0) |
| static readonly [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [Forward](struct_tale_worlds_1_1_library_1_1_vec2.html#a37b7dcce3640f8958b9545df5557b9e7) = new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6)(0, 1) |
| static readonly [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [One](struct_tale_worlds_1_1_library_1_1_vec2.html#a350f5d713adb541af26931ccd2e45a82) = new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6)(1, 1) |
| static readonly [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [Zero](struct_tale_worlds_1_1_library_1_1_vec2.html#aeb41cfae13f72833eb61b2103b8102a2) = new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6)(0, 0) |
| static readonly [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | [Invalid](struct_tale_worlds_1_1_library_1_1_vec2.html#a96928af045eefc232b30fe60c926d71d) = new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6)(float.NaN, float.NaN) |

|  |  |
| --- | --- |
| Properties | |
| float | [X](struct_tale_worlds_1_1_library_1_1_vec2.html#ad2f440a6a0fb617142f318add2b51874) `[get]` |
| float | [Y](struct_tale_worlds_1_1_library_1_1_vec2.html#aff6f7d3e836c7dd368ad26372e11a239) `[get]` |
| float | [Length](struct_tale_worlds_1_1_library_1_1_vec2.html#aae17733b08b8cca6812cff194bcc7e87) `[get]` |
|  | Return the length of the vector. |
| float | [LengthSquared](struct_tale_worlds_1_1_library_1_1_vec2.html#a7f34d2f8701d6e7a7041b7f445c6ebdf) `[get]` |
|  | Return the square of the length of the vector. |
| float | [RotationInRadians](struct_tale_worlds_1_1_library_1_1_vec2.html#ac94eb9c71db0db1409f8415ea3f78a7f) `[get]` |
|  | Calculates the counter clockwise rotation from y axis in radians. |
| bool | [IsValid](struct_tale_worlds_1_1_library_1_1_vec2.html#aeb51c437884f243e5e5deb0d6a029abc) `[get]` |
|  | Determines if all (XY) components are valid (not NaN or Infinite) or not. |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6)Vec2() [1/3]
-----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Vec2.Vec2 | ( | float | *a*, |
|  |  | float | *b* ) |

Parameters
:   |  |  |
    | --- | --- |
    | a | x value. |
    | b | y value. |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a12e326b815a5e546c8b0a338816ca7a4)Vec2() [2/3]
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.Vec2.Vec2 | ( | Vec2 | *v* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | v | Copied vector |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a7f1eda9bae732248fc11d29266dcf930)Vec2() [3/3]
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.Vec2.Vec2 | ( | Vector2 | *v* | ) |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a5fe385dbd1961ed670e4d65e690badfc)ToVec3()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Vec2.ToVec3 | ( | float | *z* = 0::0f | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a6042d71626189a24e765be38e4569ce2)operator Vector2()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.Library.Vec2.operator Vector2 | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *vec2* | ) |  | | explicitstatic |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a9aaa8830683579ea2aaeb3b3f82990bd)operator Vec2()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | implicit TaleWorlds.Library.Vec2.operator [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | ( | Vector2 | *vec2* | ) |  | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#ab8160d2c924807459c492b5cf7407ebd)Normalize()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Library.Vec2.Normalize | ( |  | ) |  |

Returns
:   Length of vector.

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#ae8119a6d5e54cba2f965972ec697c955)Normalized()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.Normalized | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a848e72d5297c2b70058268c7b0b10fe2)ClampMagnitude()
---------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.Vec2.ClampMagnitude | ( | float | *min*, |
|  |  | float | *max* ) |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#af4b50f96d1a0df7ec445489aa29daab9)GetWindingOrder()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | WindingOrder TaleWorlds.Library.Vec2.GetWindingOrder | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *first*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *second*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *third* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a96dd8826cd34a85c1559ed8314942d28)CCW()
----------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.Vec2.CCW | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *va*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *vb* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | va | The va. |
    | vb | The vb. |

Returns
:   |va|\*|vb|\*sin(counter-clockwise angle)

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a6b04b57b9bc96bbc8295354ecaf5feae)Equals()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Library.Vec2.Equals | ( | object | *obj* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | obj | The generic object to compare with this instance. |

Returns
:   `true` if the specified object is equal to this instance; otherwise, `false`.

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#abe2ee6eb7ab8aac6209e103b28d8ef91)GetHashCode()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Library.Vec2.GetHashCode | ( |  | ) |  |

Returns
:   A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#aa2c1f87c2b3f28afc2bc7d70dbc51b50)operator==()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Vec2.operator== | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v1*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v2* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#ac119752164cb25bfa93964b49837caf8)operator!=()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Vec2.operator!= | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v1*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v2* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#af1c5e1d58153cb962de565d8927848e5)operator-() [1/2]
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.operator- | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v* | ) |  | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#aaa678a757c491373e32d489a22224354)operator+()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.operator+ | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v1*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v2* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#af8881d7f5841e20060999f0f5b1ba4e5)operator-() [2/2]
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.operator- | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v1*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v2* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a2728279a7d3053b1a8785365ac77ebe5)operator\*() [1/2]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.operator\* | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v*, | |  |  | float | *f* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#ac26d5a93cf752eb7f1555c64c9918cec)operator\*() [2/2]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.operator\* | ( | float | *f*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a212e2aff11b7c3df5325bcb7695d23d8)operator/() [1/2]
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.operator/ | ( | float | *f*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a0476fb7ff43554b7002ec7a673bd5d03)operator/() [2/2]
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.operator/ | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v*, | |  |  | float | *f* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a36000f0817d36767ed48bc3a24a669c5)IsUnit()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.Vec2.IsUnit | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a1961d599dc64cd7e0fa8ee70175366de)IsNonZero()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.Vec2.IsNonZero | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a8fbebf6494f103b0e1af7a001d6f62ae)NearlyEquals()
-------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.Vec2.NearlyEquals | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v*, |
|  |  | float | *epsilon* = MBMath::Epsilon ) |

Parameters
:   |  |  |
    | --- | --- |
    | v | Vector that is compared. |
    | epsilon | Epsilon for equality. |

Returns
:   true is nearly equals

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a8cf3798e38db45cdb1719ac07b143612)RotateCCW()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Vec2.RotateCCW | ( | float | *angleInRadians* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | angleInRadians | The angle |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#abba87b63d415fdcd94bac258fb97eb1d)DotProduct() [1/2]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Library.Vec2.DotProduct | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | v | Second vector |

Returns
:   Dot product

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#abf2a5a6c057853a94e53777130c8cc9e)DotProduct() [2/2]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.Vec2.DotProduct | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *va*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *vb* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | va | First vector |
    | vb | Second vector |

Returns
:   Dot product

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a911b5393974474807f6fa1ed2ef81ff9)ElementWiseProduct()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.ElementWiseProduct | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *va*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *vb* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | va | First vector |
    | vb | Second vector |

Returns
:   Element-wise product

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a8b4acafaa2a839bef74ac130a2c0fcf5)FromRotation()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.FromRotation | ( | float | *rotation* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | rotation |  |

Returns

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a487e9f3aeb9a6ee502b945afb44c2782)TransformToLocalUnitF()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.TransformToLocalUnitF | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | Vector to be transformed. |

Returns
:   Transformed vector.

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#ab154dae7896e49b426bf0f858955647b)TransformToParentUnitF()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.TransformToParentUnitF | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | Vector to be transformed. |

Returns
:   Transformed vector.

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a77d55d85198069b454ab58b604eb2bb2)TransformToLocalUnitFLeftHanded()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.TransformToLocalUnitFLeftHanded | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | Vector to be transformed. |

Returns
:   Transformed vector.

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#ab47b195baf0d0de23be390940c92db44)TransformToParentUnitFLeftHanded()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.TransformToParentUnitFLeftHanded | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | Vector to be transformed. |

Returns
:   Transformed vector.

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a32a24c5897bdd8e91876fe6441009376)RightVec()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.RightVec | ( |  | ) |  |

Returns

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#abdfbdd52f39e2f046b53be02b00f1f21)LeftVec()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.LeftVec | ( |  | ) |  |

Returns

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a2463d8436857d41250397c89c1491912)Max() [1/2]
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.Max | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v1*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | va | First vector |
    | vb | Second vector |

Returns
:   Elementvise maximum of two vectors

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a2b120f42cb56d4667e22156cd8c12b80)Max() [2/2]
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.Max | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v1*, | |  |  | float | *f* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a6ac3ab0553843db59771df6a92815834)Min() [1/2]
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.Min | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v1*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | va | First vector |
    | vb | Second vector |

Returns
:   Element vise minimum of two vectors

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#adb4c1d865e77e67981a46fb3455133cd)Min() [2/2]
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.Min | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v1*, | |  |  | float | *f* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a9294ccefbf293c0d11eb87c15b8a4b69)ToString()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Library.Vec2.ToString | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a1d02b56ade5799b0aaaad39c71909ee0)DistanceSquared()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Library.Vec2.DistanceSquared | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a0f3fca8487301a0987162aa7fb547054)Distance()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Library.Vec2.Distance | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | v | Vector v. |

Returns
:   Length difference

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a5bb76cf41556ae9d82d9c82d8ab9e0f5)DistanceToLine()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.Vec2.DistanceToLine | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *line1*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *line2*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *point* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a5e04309b17aadedd9bd01125fcfff814)DistanceToLineSegmentSquared()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.Vec2.DistanceToLineSegmentSquared | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *line1*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *line2*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *point* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a768fbd3f1e22468d87edbae7ed5b6939)DistanceToLineSegment()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.Library.Vec2.DistanceToLineSegment | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *w*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *closestPointOnLineSegment* ) |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a1277fbdd55d7c06844347935399ee686)DistanceSquaredToLineSegment()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.Library.Vec2.DistanceSquaredToLineSegment | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v*, |
|  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *w*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *closestPointOnLineSegment* ) |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#aab8fe49a9420d241bbe2adc946aa33b9)Abs()
----------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.Abs | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *vec* | ) |  | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a295fe616ef053324dcf0f55a1f696036)Lerp()
-----------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.Lerp | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v1*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *v2*, | |  |  | float | *alpha* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a110b719101847470b4a73999f9744d39)Slerp()
------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.Slerp | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *start*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *end*, | |  |  | float | *percent* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a587b233efd4a7339406a2c1c28a14676)AngleBetween()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Library.Vec2.AngleBetween | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *vector2* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | vector2 |  |

Returns

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a509bc15fe4ba0c7bbcf5d5f6d7985398)Determinant()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.Vec2.Determinant | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *vec1*, | |  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) | *vec2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | vec1 | First vector |
    | vec2 | Second vector |

Returns
:   Determinant

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a415e621acf0ea425bfc4ada755753fc9)x
------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Library.Vec2.x |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a94e513bca0ba59d62270d16a3ee7ff8a)y
------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Library.Vec2.y |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a4f40389127ecd89d68e09fc341bcf489)Side
---------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.Side = new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6)(1, 0) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a37b7dcce3640f8958b9545df5557b9e7)Forward
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.Forward = new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6)(0, 1) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a350f5d713adb541af26931ccd2e45a82)One
--------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.One = new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6)(1, 1) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#aeb41cfae13f72833eb61b2103b8102a2)Zero
---------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.Zero = new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6)(0, 0) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a96928af045eefc232b30fe60c926d71d)Invalid
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6) TaleWorlds.Library.Vec2.Invalid = new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html#ac1c214d506786727d90e498a47ad8df6)(float.NaN, float.NaN) | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#ad2f440a6a0fb617142f318add2b51874)X
------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Vec2.X | | get |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#aff6f7d3e836c7dd368ad26372e11a239)Y
------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Vec2.Y | | get |

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#aae17733b08b8cca6812cff194bcc7e87)Length
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Vec2.Length | | get |

Returns
:   length of the vector

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#a7f34d2f8701d6e7a7041b7f445c6ebdf)LengthSquared
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Vec2.LengthSquared | | get |

Returns
:   Square of length.

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#ac94eb9c71db0db1409f8415ea3f78a7f)RotationInRadians
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Vec2.RotationInRadians | | get |

Rotation angle.

[◆](struct_tale_worlds_1_1_library_1_1_vec2.html#aeb51c437884f243e5e5deb0d6a029abc)IsValid
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.Vec2.IsValid | | get |

