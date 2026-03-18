--- SOURCE: class_tale_worlds_1_1_library_1_1_m_b_math.html ---

TaleWorlds.Library.MBMath Class Reference|  |  |
| --- | --- |
| Static Public Member Functions | |
| static float | [ToRadians](class_tale_worlds_1_1_library_1_1_m_b_math.html#adf0f15ad164831be2f8aad136be21117) (this float f) |
|  | Converts the degree value to radian value. |
| static float | [ToDegrees](class_tale_worlds_1_1_library_1_1_m_b_math.html#a713273b7d220426cbd413b973a7a3c79) (this float f) |
|  | Converts the radian value to degree value. |
| static bool | [ApproximatelyEqualsTo](class_tale_worlds_1_1_library_1_1_m_b_math.html#ac98a0127da4f9f1a38ff2c9a64c3e0b3) (this float f, float comparedValue, float epsilon=MBMath.Epsilon) |
| static bool | [ApproximatelyEquals](class_tale_worlds_1_1_library_1_1_m_b_math.html#a9d19d71821dbd0e0a623333c336098a4) (float first, float second, float epsilon=MBMath.Epsilon) |
| static bool | [IsValidValue](class_tale_worlds_1_1_library_1_1_m_b_math.html#af64a874a39f46bd6fab912cc5973461e) (float f) |
|  | Checks the value. |
| static int | [ClampIndex](class_tale_worlds_1_1_library_1_1_m_b_math.html#aa6a10e327a5e9912e5f16629fea5cc20) (int value, int minValue, int maxValue) |
|  | Clamps the input value, max exclusive. |
| static int | [ClampInt](class_tale_worlds_1_1_library_1_1_m_b_math.html#a5fe703022cf2e5d068e9b196437e901c) (int value, int minValue, int maxValue) |
|  | Clamps the input value. |
| static float | [ClampFloat](class_tale_worlds_1_1_library_1_1_m_b_math.html#ac9a9a5b7cfdf55ef15307a457568f3bf) (float value, float minValue, float maxValue) |
|  | Clamps the input value. |
| static void | [ClampUnit](class_tale_worlds_1_1_library_1_1_m_b_math.html#a1978ca8648e7ce6c281629e042e35d32) (ref float value) |
|  | Clamps the input value between 0.0f and 1.0f. |
| static int | [GetNumberOfBitsToRepresentNumber](class_tale_worlds_1_1_library_1_1_m_b_math.html#af94a824976eec6d1bb09d622fff40026) (uint value) |
| static IEnumerable< ValueTuple< T, int > > | [DistributeShares< T >](class_tale_worlds_1_1_library_1_1_m_b_math.html#aa72ec1e3c52ec40c57436febbb5433e8) (int totalAward, IEnumerable< T > stakeHolders, Func< T, int > shareFunction) |
| static int | [GetNumberOfBitsToRepresentNumber](class_tale_worlds_1_1_library_1_1_m_b_math.html#a3e9a3897b3467cb2c61163c68728c249) (ulong value) |
| static float | [Lerp](class_tale_worlds_1_1_library_1_1_m_b_math.html#a8fb89b22e597678735a10affbc77f7f5) (float valueFrom, float valueTo, float amount, float minimumDifference=[Epsilon](class_tale_worlds_1_1_library_1_1_m_b_math.html#a36081a17eb9a0cc2bc296b2ff4ecec55)) |
|  | Linear interpolation between two floating values. |
| static float | [LinearExtrapolation](class_tale_worlds_1_1_library_1_1_m_b_math.html#a52a5a5ecc705ccfc3d536646ba4304a4) (float valueFrom, float valueTo, float amount) |
|  | Linear extrapolation with respect to two floating values. |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [Lerp](class_tale_worlds_1_1_library_1_1_m_b_math.html#a2c005b454cfdb07125f003ffa99683b5) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) vecFrom, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) vecTo, float amount, float minimumDifference) |
|  | Linear interpolation between two [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html "3D Vector class"). |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [Lerp](class_tale_worlds_1_1_library_1_1_m_b_math.html#aadad1ddc5f9c6e5f105b3c9748be98a0) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) vecFrom, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) vecTo, float amount, float minimumDifference) |
| static float | [Map](class_tale_worlds_1_1_library_1_1_m_b_math.html#a2fa02d0c91796277fe4b7e547f1eba92) (float input, float inputMinimum, float inputMaximum, float outputMinimum, float outputMaximum) |
|  | Re-maps a number from one range to another. |
| static [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | [Lerp](class_tale_worlds_1_1_library_1_1_m_b_math.html#a520c56151f136dc05a0c3622b98fb026) (ref [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) matFrom, ref [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) matTo, float amount, float minimumDifference) |
|  | Linear interpolation between two Matrices. |
| static float | [LerpRadians](class_tale_worlds_1_1_library_1_1_m_b_math.html#a68df8553b7fe7754485cc856fa8248a0) (float valueFrom, float valueTo, float amount, float minChange, float maxChange) |
|  | Linear interpolation between two radian values. |
| static float | [SplitLerp](class_tale_worlds_1_1_library_1_1_m_b_math.html#aab90fe5b2bbe497ea5403220d9530a7c) (float value1, float value2, float value3, float cutOff, float amount, float minimumDifference) |
|  | Linear interpolation between three floating values with a split value. |
| static float | [InverseLerp](class_tale_worlds_1_1_library_1_1_m_b_math.html#a59a08d560c68bc7072986553ffece8c1) (float valueFrom, float valueTo, float value) |
|  | Inverse Linear interpolation between two floating values. |
| static float | [SmoothStep](class_tale_worlds_1_1_library_1_1_m_b_math.html#a891c4ff34742901fcf886e34f83fdb2b) (float edge0, float edge1, float value) |
|  | SmoothStep performs smooth Hermite interpolation between 0 and 1 when edge0 < x < edge1. 0 when x <= edge0 and 1 when x >= edge1. |
| static float | [BilinearLerp](class_tale_worlds_1_1_library_1_1_m_b_math.html#aa4f7973be8d8c4bca3def10a80600432) (float topLeft, float topRight, float botLeft, float botRight, float x, float y) |
|  | Bilinear interpolation between four floating values on a uniform grid. |
| static float | [GetSmallestDifferenceBetweenTwoAngles](class_tale_worlds_1_1_library_1_1_m_b_math.html#a638e9e349d4fa8561999d34c290e1dcd) (float fromAngle, float toAngle) |
|  | Calculates the (smallest) difference angle between two angles. |
| static float | [ClampAngle](class_tale_worlds_1_1_library_1_1_m_b_math.html#aec1ace7ebce65328057a3263c997d53d) (float angle, float restrictionCenter, float restrictionRange) |
|  | Restricts an angle to a specified portion of a disk, a circular sector. |
| static float | [WrapAngle](class_tale_worlds_1_1_library_1_1_m_b_math.html#ae6548f0f40ab7e5206456ed13776aae0) (float angle) |
|  | Reduces a given angle to a value between π and -π. |
| static float | [WrapAngleSafe](class_tale_worlds_1_1_library_1_1_m_b_math.html#a4ae78b513ed1d0b1e9da644d5291b394) (float angle) |
| static bool | [IsBetween](class_tale_worlds_1_1_library_1_1_m_b_math.html#a0758e569ce29e6b5bdb498cf21a3c7b8) (float numberToCheck, float bottom, float top) |
| static bool | [IsBetween](class_tale_worlds_1_1_library_1_1_m_b_math.html#a02d3d6c97b33ca54eef94fe4955df539) (int value, int minValue, int maxValue) |
| static bool | [IsBetweenInclusive](class_tale_worlds_1_1_library_1_1_m_b_math.html#a0f2746976951baeb57f7354a38ef7e30) (float numberToCheck, float bottom, float top) |
| static uint | [ColorFromRGBA](class_tale_worlds_1_1_library_1_1_m_b_math.html#a2a959c13e55af3eed3b71c8e753221a9) (float red, float green, float blue, float alpha) |
| static [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [HSBtoRGB](class_tale_worlds_1_1_library_1_1_m_b_math.html#aadc4e91eaa87bbf844afe71105c143bd) (float hue, float saturation, float brightness, float outputAlpha) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [RGBtoHSB](class_tale_worlds_1_1_library_1_1_m_b_math.html#ab078b958b272d2f370642fdaf1fb8ad8) ([Color](struct_tale_worlds_1_1_library_1_1_color.html) rgb) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GammaCorrectRGB](class_tale_worlds_1_1_library_1_1_m_b_math.html#a78189f476d822cd9c29fb635287f6747) (float gamma, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rgb) |
| static float | [GetSignedDistanceOfPointToLineSegment](class_tale_worlds_1_1_library_1_1_m_b_math.html#ac939e28e53ed0fd7690be6db8442c4c1) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineSegmentBegin, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineSegmentEnd, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) point) |
|  | Computes the signed distance from the specified line segment to the given point. |
| static float | [GetDistanceSquareOfPointToLineSegment](class_tale_worlds_1_1_library_1_1_m_b_math.html#ad1c9b56947ab1820d423f42917e3cd08) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineSegmentBegin, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineSegmentEnd, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) point) |
|  | Computes the squared distance from a line segment to a specified point. |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [ProjectPointOntoLine](class_tale_worlds_1_1_library_1_1_m_b_math.html#a3cd405a977f4fd44e3feb912849735ea) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) point, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineStart, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineEnd) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [ClampToAxisAlignedRectangle](class_tale_worlds_1_1_library_1_1_m_b_math.html#aa31141ebe5b6ff6df5f7c22461ccbcd8) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) point, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineStart, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineEnd) |
| static bool | [GetRayPlaneIntersectionPoint](class_tale_worlds_1_1_library_1_1_m_b_math.html#a304a7d4f38f6c35f3465df5339f35eff) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) planeNormal, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) planeCenter, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rayOrigin, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) rayDirection, out float t) |
| static bool | [PointLiesAheadOfPlane](class_tale_worlds_1_1_library_1_1_m_b_math.html#a070f2c722732b3e396457accee16dac0) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) planeNormal, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) planeCenter, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) point) |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetClosestPointOnLineSegmentToPoint](class_tale_worlds_1_1_library_1_1_m_b_math.html#a950aa63fd01464ef4f648eaba8407ccc) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineSegmentBegin, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineSegmentEnd, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) point) |
|  | Returns closest 2D point on the given 2D line segment to a target 2D point. |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [GetClosestPointOnLineSegmentToPoint](class_tale_worlds_1_1_library_1_1_m_b_math.html#ad163eda5e13fa49aae5847bf538b533e) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) lineSegmentBegin, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) lineSegmentEnd, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) point) |
|  | Returns closest 3D point on the given 3D line segment to a target 3D point. |
| static bool | [CheckLineToLineSegmentIntersection](class_tale_worlds_1_1_library_1_1_m_b_math.html#a1c8dda6a6e433e74eebbebdf38e146df) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineOrigin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) lineDirection, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) segmentA, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) segmentB, out float t, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) intersect) |
|  | Computes intersection of a line (specified by a point on line and direction) with a line segment (specified by two segment points A and B). |
| static bool | [IntersectLineSegmentWithTriangle](class_tale_worlds_1_1_library_1_1_m_b_math.html#a08514c8f815caadd4008ce0299c6b1d2) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) segStart, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) segEnd, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) triA, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) triB, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) triC) |
| static bool | [IntersectLineSegmentWithBoundingBox](class_tale_worlds_1_1_library_1_1_m_b_math.html#a04fc7862304674650537b6ec71b615f0) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) start, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) end, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) min, in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) max) |
| static bool | [CheckLineSegmentToLineSegmentIntersection](class_tale_worlds_1_1_library_1_1_m_b_math.html#a87c8626fdd7f1bf129bee7290d85c794) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) segment1Start, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) segment1End, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) segment2Start, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) segment2End) |
|  | Checks whether two line segments intersect (segment1Start-segment1End), (segment2Start-segment2End). |
| static bool | [CheckPointInsidePolygon](class_tale_worlds_1_1_library_1_1_m_b_math.html#a11ee29e00dabb152453ee1086750e533) (in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) v0, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) v1, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) v2, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) v3, in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) point) |
|  | Using ray casting algorithm, this function checks if the given point is inside the polygon. Polygon vertices are in cw or ccw order. |
| static bool | [CheckPolygonIntersection](class_tale_worlds_1_1_library_1_1_m_b_math.html#a4ea82494cc4c55e1703d08f640ab2ce5) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)[] polygon1, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)[] polygon2) |
|  | Takes two polygons and decides whether they intersect or not. Polygon vertices are in ccw order. |
| static bool | [CheckPolygonLineSegmentIntersection](class_tale_worlds_1_1_library_1_1_m_b_math.html#a2392e586b8fd2b13287618b0e91c3845) (MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > polygon, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) segmentStart, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) segmentEnd) |
|  | Takes a polygon and a line segment and decides whether they intersect or not. Polygon vertices are in ccw order. |
| static bool | [IntersectRayWithPolygon](class_tale_worlds_1_1_library_1_1_m_b_math.html#a7ea9d979ac4221994e29520d0daef5b1) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) rayOrigin, [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) rayDir, MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > polygon, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) intersectionPoint) |
|  | Intersects a ray with the given polygon (with consecutive vertices) and returns true (if intersection exists). |
| static string | [ToOrdinal](class_tale_worlds_1_1_library_1_1_m_b_math.html#a55df5c01dcd8ff4481e648a78673dd65) (int number) |
|  | Coverts a cardinal number to ordinal. |
| static int | [IndexOfMax< T >](class_tale_worlds_1_1_library_1_1_m_b_math.html#aafc7b6260cbf6d8d4ced7d6e11cc3e6b) (MBReadOnlyList< T > array, Func< T, int > func) |
| static T | [MaxElement< T >](class_tale_worlds_1_1_library_1_1_m_b_math.html#a7e81104db77d937934db7dbf88e5d61d) (IEnumerable< T > collection, Func< T, float > func) |
|  | Return the element that has the top return value for the supplied function. |
| static ValueTuple< T, T > | [MaxElements2< T >](class_tale_worlds_1_1_library_1_1_m_b_math.html#a3e3982386c61d0abc465d17d5a321654) (IEnumerable< T > collection, Func< T, float > func) |
| static ValueTuple< T, T, T > | [MaxElements3< T >](class_tale_worlds_1_1_library_1_1_m_b_math.html#abb0f02fb3d6b11e542d4446c6e0714d6) (IEnumerable< T > collection, Func< T, float > func) |
|  | Return the three elements that have the top return values for the supplied function. |
| static ValueTuple< T, T, T, T > | [MaxElements4< T >](class_tale_worlds_1_1_library_1_1_m_b_math.html#ac837f50bad4a29cc93bc8486aeec7bc8) (IEnumerable< T > collection, Func< T, float > func) |
|  | Return the four elements that have the top return values for the supplied function. |
| static ValueTuple< T, T, T, T, T > | [MaxElements5< T >](class_tale_worlds_1_1_library_1_1_m_b_math.html#a11023eb6ac6c40031a8b7a7a6e64889b) (IEnumerable< T > collection, Func< T, float > func) |
|  | Return the five elements that have the top return values for the supplied function. |
| static IList< T > | [TopologySort< T >](class_tale_worlds_1_1_library_1_1_m_b_math.html#a80e5a8bd1b1f492be41df003fbadb602) (IEnumerable< T > source, Func< T, IEnumerable< T > > getDependencies) |
|  | Topology sort a list of items. getDependencies func needs to return the same instance of items for comparing. |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [FindPlaneLineIntersectionPointWithNormal](class_tale_worlds_1_1_library_1_1_m_b_math.html#a9dbf41132189d70b182b41d3e6273f8c) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) planeP1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) planeNormal, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) mouseP1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) mouseP2, out bool exceptionZero) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const float | [TwoPI](class_tale_worlds_1_1_library_1_1_m_b_math.html#a2f2c55d26248cf6ccb7396d228175b19) = (float)(Math.PI \* 2) |
|  | 2π |
| const float | [PI](class_tale_worlds_1_1_library_1_1_m_b_math.html#a013af96a5b045a1764de05b3b281d8da) = (float)Math.PI |
|  | π |
| const float | [HalfPI](class_tale_worlds_1_1_library_1_1_m_b_math.html#a0938509cc7944fc6c8b8b3e5884d1f69) = (float)(Math.PI \* 0.5) |
|  | π / 2 |
| const float | [E](class_tale_worlds_1_1_library_1_1_m_b_math.html#a0ed3d385f3876f74f455a7b5d867639a) = (float)Math.E |
|  | Represents the natural logarithmic base, specified by the constant, e. |
| const float | [DegreesToRadians](class_tale_worlds_1_1_library_1_1_m_b_math.html#a4078d51bcfb3c1b08cfdd45dabba52f9) = ([PI](class_tale_worlds_1_1_library_1_1_m_b_math.html#a013af96a5b045a1764de05b3b281d8da) / 180.0f) |
|  | π / 180 |
| const float | [RadiansToDegrees](class_tale_worlds_1_1_library_1_1_m_b_math.html#a23b62719f22f2173171278c3698ddf43) = (180f / [PI](class_tale_worlds_1_1_library_1_1_m_b_math.html#a013af96a5b045a1764de05b3b281d8da)) |
|  | 180 / π |
| const float | [Epsilon](class_tale_worlds_1_1_library_1_1_m_b_math.html#a36081a17eb9a0cc2bc296b2ff4ecec55) = 0.00001f |
|  | Small positive infinitesimal quantity. |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#adf0f15ad164831be2f8aad136be21117)ToRadians()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.ToRadians | ( | this float | *f* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | f |  |

Returns

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a713273b7d220426cbd413b973a7a3c79)ToDegrees()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.ToDegrees | ( | this float | *f* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | f |  |

Returns

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#ac98a0127da4f9f1a38ff2c9a64c3e0b3)ApproximatelyEqualsTo()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.ApproximatelyEqualsTo | ( | this float | *f*, | |  |  | float | *comparedValue*, | |  |  | float | *epsilon* = MBMath::Epsilon ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a9d19d71821dbd0e0a623333c336098a4)ApproximatelyEquals()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.ApproximatelyEquals | ( | float | *first*, | |  |  | float | *second*, | |  |  | float | *epsilon* = MBMath::Epsilon ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#af64a874a39f46bd6fab912cc5973461e)IsValidValue()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.IsValidValue | ( | float | *f* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | f | Value to be checked. |

Returns
:   true if value is valid float, false if value is NaN (Not A Number).

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#aa6a10e327a5e9912e5f16629fea5cc20)ClampIndex()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Library.MBMath.ClampIndex | ( | int | *value*, | |  |  | int | *minValue*, | |  |  | int | *maxValue* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | value | Input value. |
    | minValue | The min value. |
    | maxValue | The max value, exclusive. |

Returns
:   Clamped value.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a5fe703022cf2e5d068e9b196437e901c)ClampInt()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Library.MBMath.ClampInt | ( | int | *value*, | |  |  | int | *minValue*, | |  |  | int | *maxValue* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | value | Input value. |
    | minValue | The min value. |
    | maxValue | The max value. |

Returns
:   Clamped value.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#ac9a9a5b7cfdf55ef15307a457568f3bf)ClampFloat()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.ClampFloat | ( | float | *value*, | |  |  | float | *minValue*, | |  |  | float | *maxValue* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | value | Input value. |
    | minValue | The min value. |
    | maxValue | The max value. |

Returns
:   Clamped value.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a1978ca8648e7ce6c281629e042e35d32)ClampUnit()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.Library.MBMath.ClampUnit | ( | ref float | *value* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | value |  |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#af94a824976eec6d1bb09d622fff40026)GetNumberOfBitsToRepresentNumber() [1/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Library.MBMath.GetNumberOfBitsToRepresentNumber | ( | uint | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#aa72ec1e3c52ec40c57436febbb5433e8)DistributeShares< T >()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IEnumerable< ValueTuple< T, int > > TaleWorlds.Library.MBMath.DistributeShares< T > | ( | int | *totalAward*, | |  |  | IEnumerable< T > | *stakeHolders*, | |  |  | Func< T, int > | *shareFunction* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a3e9a3897b3467cb2c61163c68728c249)GetNumberOfBitsToRepresentNumber() [2/2]
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.Library.MBMath.GetNumberOfBitsToRepresentNumber | ( | ulong | *value* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a8fb89b22e597678735a10affbc77f7f5)Lerp() [1/4]
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.Lerp | ( | float | *valueFrom*, | |  |  | float | *valueTo*, | |  |  | float | *amount*, | |  |  | float | *minimumDifference* = [Epsilon](class_tale_worlds_1_1_library_1_1_m_b_math.html#a36081a17eb9a0cc2bc296b2ff4ecec55) ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | valueFrom | First source value. |
    | valueTo | Second source value. |
    | amount | The weight of parameter valueTo, such that 0≤x≤1. |
    | minimumDifference | The minimum difference that can happen between two values. If difference is less than this value, then valueTo is returned immediately. |

Returns
:   Interpolated value.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a52a5a5ecc705ccfc3d536646ba4304a4)LinearExtrapolation()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.LinearExtrapolation | ( | float | *valueFrom*, | |  |  | float | *valueTo*, | |  |  | float | *amount* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | valueFrom | First source value. |
    | valueTo | Second source value. |
    | amount | The weight of parameter valueTo. |

Returns
:   Extrapolated value.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a2c005b454cfdb07125f003ffa99683b5)Lerp() [2/4]
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MBMath.Lerp | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *vecFrom*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *vecTo*, | |  |  | float | *amount*, | |  |  | float | *minimumDifference* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | vecFrom | First source value. |
    | vecTo | Second source value. |
    | amount | The weight of parameter valueTo, such that 0≤x≤1. |

Returns
:   Interpolated vector.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#aadad1ddc5f9c6e5f105b3c9748be98a0)Lerp() [3/4]
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Library.MBMath.Lerp | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *vecFrom*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *vecTo*, | |  |  | float | *amount*, | |  |  | float | *minimumDifference* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a2fa02d0c91796277fe4b7e547f1eba92)Map()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.Map | ( | float | *input*, | |  |  | float | *inputMinimum*, | |  |  | float | *inputMaximum*, | |  |  | float | *outputMinimum*, | |  |  | float | *outputMaximum* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | input | The number to map. |
    | inputMinimum | The lower bound of the value’s current range. |
    | inputMaximum | The upper bound of the value’s current range. |
    | outputMinimum | The lower bound of the value’s target range. |
    | outputMaximum | The upper bound of the value’s target range. |

Returns
:   The mapped value

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a520c56151f136dc05a0c3622b98fb026)Lerp() [4/4]
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) TaleWorlds.Library.MBMath.Lerp | ( | ref [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | *matFrom*, | |  |  | ref [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | *matTo*, | |  |  | float | *amount*, | |  |  | float | *minimumDifference* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | matFrom | First source value. |
    | matTo | Second source value. |
    | amount | The weight of parameter valueTo, such that 0≤x≤1. |

Returns
:   Interpolated [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html "3x3 Matrix class for 3d graphics.").

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a68df8553b7fe7754485cc856fa8248a0)LerpRadians()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.LerpRadians | ( | float | *valueFrom*, | |  |  | float | *valueTo*, | |  |  | float | *amount*, | |  |  | float | *minChange*, | |  |  | float | *maxChange* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | valueFrom | First source value, such that -π≤θ≤π. |
    | valueTo | Second source value, such that -π≤θ≤π. |
    | amount | The weight of parameter valueTo, such that 0≤x≤1. |

Returns
:   Interpolated value, such that -π≤θ≤π.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#aab90fe5b2bbe497ea5403220d9530a7c)SplitLerp()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.SplitLerp | ( | float | *value1*, | |  |  | float | *value2*, | |  |  | float | *value3*, | |  |  | float | *cutOff*, | |  |  | float | *amount*, | |  |  | float | *minimumDifference* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | value1 | First source value. |
    | value2 | Second source value. |
    | value3 | Third source value. |
    | cutOff | Value at which to stop lerping from value1 to value2, and go from value2 to value3. |
    | amount | The weight, such that 0≤x≤1. |
    | minimumDifference | The minimum difference that can happen between two values. If difference is less than this value, then the current goalValue is returned immediately. |

Returns
:   Interpolated value.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a59a08d560c68bc7072986553ffece8c1)InverseLerp()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.InverseLerp | ( | float | *valueFrom*, | |  |  | float | *valueTo*, | |  |  | float | *value* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | valueFrom | First source value. |
    | valueTo | Second source value. |
    | value | The weight of parameter valueTo, such that valueFrom ≤ x ≤ valueTo. |

Returns
:   Inverse interpolated value.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a891c4ff34742901fcf886e34f83fdb2b)SmoothStep()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.SmoothStep | ( | float | *edge0*, | |  |  | float | *edge1*, | |  |  | float | *value* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | edge0 | Specifies the value of the lower edge of the Hermite function. |
    | edge1 | Specifies the value of the upper edge of the Hermite function. |
    | value | Specifies the source value for interpolation. |

Returns
:   Hermite interpolated value between two values

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#aa4f7973be8d8c4bca3def10a80600432)BilinearLerp()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.BilinearLerp | ( | float | *topLeft*, | |  |  | float | *topRight*, | |  |  | float | *botLeft*, | |  |  | float | *botRight*, | |  |  | float | *x*, | |  |  | float | *y* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | topLeft | First source value. |
    | topRight | Second source value. |
    | botLeft | Third source value. |
    | botRight | Fourth source value. |
    | x | The horizontal weight |
    | y | The vertical weight |

Returns
:   Inverse interpolated value.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a638e9e349d4fa8561999d34c290e1dcd)GetSmallestDifferenceBetweenTwoAngles()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.GetSmallestDifferenceBetweenTwoAngles | ( | float | *fromAngle*, | |  |  | float | *toAngle* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | fromAngle | Offset angle, θ, measured in radians, such that -π≤θ≤π. |
    | toAngle | Target angle, θ, measured in radians, such that -π≤θ≤π. |

Returns
:   Difference angle, θ, measured in radians, such that -π≤θ≤π.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#aec1ace7ebce65328057a3263c997d53d)ClampAngle()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.ClampAngle | ( | float | *angle*, | |  |  | float | *restrictionCenter*, | |  |  | float | *restrictionRange* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | angle | The angle to be restricted, θ, measured in radians, such that -π≤θ≤π. |
    | restrictionCenter | Angle of restriction arc's midpoint, θ, measured in radians, such that -π≤θ≤π. |
    | restrictionRange | Central angle of restriction sector, θ, measured in radians, such that 0<θ≤π/2. |

Returns
:   The restricted angle value, θ, measured in radians, such that -π≤θ≤π.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#ae6548f0f40ab7e5206456ed13776aae0)WrapAngle()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.WrapAngle | ( | float | *angle* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | angle | The angle to be reduced, θ, measured in radians. |

Returns
:   The reduced angle, θ, measured in radians, such that -π≤θ≤π.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a4ae78b513ed1d0b1e9da644d5291b394)WrapAngleSafe()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.WrapAngleSafe | ( | float | *angle* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a0758e569ce29e6b5bdb498cf21a3c7b8)IsBetween() [1/2]
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.IsBetween | ( | float | *numberToCheck*, | |  |  | float | *bottom*, | |  |  | float | *top* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a02d3d6c97b33ca54eef94fe4955df539)IsBetween() [2/2]
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.IsBetween | ( | int | *value*, | |  |  | int | *minValue*, | |  |  | int | *maxValue* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a0f2746976951baeb57f7354a38ef7e30)IsBetweenInclusive()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.IsBetweenInclusive | ( | float | *numberToCheck*, | |  |  | float | *bottom*, | |  |  | float | *top* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a2a959c13e55af3eed3b71c8e753221a9)ColorFromRGBA()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | uint TaleWorlds.Library.MBMath.ColorFromRGBA | ( | float | *red*, | |  |  | float | *green*, | |  |  | float | *blue*, | |  |  | float | *alpha* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#aadc4e91eaa87bbf844afe71105c143bd)HSBtoRGB()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.Library.MBMath.HSBtoRGB | ( | float | *hue*, | |  |  | float | *saturation*, | |  |  | float | *brightness*, | |  |  | float | *outputAlpha* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#ab078b958b272d2f370642fdaf1fb8ad8)RGBtoHSB()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MBMath.RGBtoHSB | ( | [Color](struct_tale_worlds_1_1_library_1_1_color.html) | *rgb* | ) |  | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a78189f476d822cd9c29fb635287f6747)GammaCorrectRGB()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MBMath.GammaCorrectRGB | ( | float | *gamma*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rgb* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#ac939e28e53ed0fd7690be6db8442c4c1)GetSignedDistanceOfPointToLineSegment()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.GetSignedDistanceOfPointToLineSegment | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineSegmentBegin*, | |  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineSegmentEnd*, | |  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *point* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | lineSegmentBegin | Start point of the line |
    | lineSegmentEnd | End point of the line |
    | point | The point to which the signed distance is to be calculated. |

Returns
:   Positive when the point lies to the left of the line

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#ad1c9b56947ab1820d423f42917e3cd08)GetDistanceSquareOfPointToLineSegment()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.MBMath.GetDistanceSquareOfPointToLineSegment | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineSegmentBegin*, | |  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineSegmentEnd*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *point* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | lineSegmentBegin | Start point of the line segment |
    | lineSegmentEnd | End point of the line segment |
    | point | The point to which the squared distance is to be calculated. |

Returns
:   The squared distance from the line segment to the point

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a3cd405a977f4fd44e3feb912849735ea)ProjectPointOntoLine()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Library.MBMath.ProjectPointOntoLine | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *point*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineStart*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineEnd* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#aa31141ebe5b6ff6df5f7c22461ccbcd8)ClampToAxisAlignedRectangle()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Library.MBMath.ClampToAxisAlignedRectangle | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *point*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineStart*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineEnd* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a304a7d4f38f6c35f3465df5339f35eff)GetRayPlaneIntersectionPoint()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.GetRayPlaneIntersectionPoint | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *planeNormal*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *planeCenter*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rayOrigin*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *rayDirection*, | |  |  | out float | *t* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a070f2c722732b3e396457accee16dac0)PointLiesAheadOfPlane()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.PointLiesAheadOfPlane | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *planeNormal*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *planeCenter*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *point* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a950aa63fd01464ef4f648eaba8407ccc)GetClosestPointOnLineSegmentToPoint() [1/2]
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Library.MBMath.GetClosestPointOnLineSegmentToPoint | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineSegmentBegin*, | |  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineSegmentEnd*, | |  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *point* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#ad163eda5e13fa49aae5847bf538b533e)GetClosestPointOnLineSegmentToPoint() [2/2]
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MBMath.GetClosestPointOnLineSegmentToPoint | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *lineSegmentBegin*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *lineSegmentEnd*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *point* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a1c8dda6a6e433e74eebbebdf38e146df)CheckLineToLineSegmentIntersection()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.CheckLineToLineSegmentIntersection | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineOrigin*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *lineDirection*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *segmentA*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *segmentB*, | |  |  | out float | *t*, | |  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *intersect* ) | | static |

Returns
:   Returns intersection parameter t (i.e. lineOrigin + t\*lineDir = intersection Point) and intersection point itself.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a08514c8f815caadd4008ce0299c6b1d2)IntersectLineSegmentWithTriangle()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.IntersectLineSegmentWithTriangle | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *segStart*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *segEnd*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *triA*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *triB*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *triC* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a04fc7862304674650537b6ec71b615f0)IntersectLineSegmentWithBoundingBox()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.IntersectLineSegmentWithBoundingBox | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *start*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *end*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *min*, | |  |  | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *max* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a87c8626fdd7f1bf129bee7290d85c794)CheckLineSegmentToLineSegmentIntersection()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.CheckLineSegmentToLineSegmentIntersection | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *segment1Start*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *segment1End*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *segment2Start*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *segment2End* ) | | static |

Returns
:   If there is an intersection, returns "true", else "false"

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a11ee29e00dabb152453ee1086750e533)CheckPointInsidePolygon()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.CheckPointInsidePolygon | ( | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *v0*, | |  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *v1*, | |  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *v2*, | |  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *v3*, | |  |  | in [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *point* ) | | static |

Returns
:   True if the point lies in polygon, otherwise false

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a4ea82494cc4c55e1703d08f640ab2ce5)CheckPolygonIntersection()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.CheckPolygonIntersection | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)[] | *polygon1*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)[] | *polygon2* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a2392e586b8fd2b13287618b0e91c3845)CheckPolygonLineSegmentIntersection()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.CheckPolygonLineSegmentIntersection | ( | MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | *polygon*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *segmentStart*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *segmentEnd* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a7ea9d979ac4221994e29520d0daef5b1)IntersectRayWithPolygon()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.MBMath.IntersectRayWithPolygon | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *rayOrigin*, | |  |  | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *rayDir*, | |  |  | MBList< [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) > | *polygon*, | |  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *intersectionPoint* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a55df5c01dcd8ff4481e648a78673dd65)ToOrdinal()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.Library.MBMath.ToOrdinal | ( | int | *number* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | number | Cardinal number to convert. |

Returns
:   Ordinal version of the given number as string.

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#aafc7b6260cbf6d8d4ced7d6e11cc3e6b)IndexOfMax< T >()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | int TaleWorlds.Library.MBMath.IndexOfMax< T > | ( | MBReadOnlyList< T > | *array*, | |  |  | Func< T, int > | *func* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a7e81104db77d937934db7dbf88e5d61d)MaxElement< T >()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | T TaleWorlds.Library.MBMath.MaxElement< T > | ( | IEnumerable< T > | *collection*, | |  |  | Func< T, float > | *func* ) | | static |

Template Parameters
:   |  |  |
    | --- | --- |
    | T |  |

Parameters
:   |  |  |
    | --- | --- |
    | collection |  |
    | func |  |

Returns

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a3e3982386c61d0abc465d17d5a321654)MaxElements2< T >()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ValueTuple< T, T > TaleWorlds.Library.MBMath.MaxElements2< T > | ( | IEnumerable< T > | *collection*, | |  |  | Func< T, float > | *func* ) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#abb0f02fb3d6b11e542d4446c6e0714d6)MaxElements3< T >()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ValueTuple< T, T, T > TaleWorlds.Library.MBMath.MaxElements3< T > | ( | IEnumerable< T > | *collection*, | |  |  | Func< T, float > | *func* ) | | static |

Template Parameters
:   |  |  |
    | --- | --- |
    | T |  |

Parameters
:   |  |  |
    | --- | --- |
    | collection |  |
    | func |  |

Returns

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#ac837f50bad4a29cc93bc8486aeec7bc8)MaxElements4< T >()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ValueTuple< T, T, T, T > TaleWorlds.Library.MBMath.MaxElements4< T > | ( | IEnumerable< T > | *collection*, | |  |  | Func< T, float > | *func* ) | | static |

Template Parameters
:   |  |  |
    | --- | --- |
    | T |  |

Parameters
:   |  |  |
    | --- | --- |
    | collection |  |
    | func |  |

Returns

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a11023eb6ac6c40031a8b7a7a6e64889b)MaxElements5< T >()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | ValueTuple< T, T, T, T, T > TaleWorlds.Library.MBMath.MaxElements5< T > | ( | IEnumerable< T > | *collection*, | |  |  | Func< T, float > | *func* ) | | static |

Template Parameters
:   |  |  |
    | --- | --- |
    | T |  |

Parameters
:   |  |  |
    | --- | --- |
    | collection |  |
    | func |  |

Returns

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a80e5a8bd1b1f492be41df003fbadb602)TopologySort< T >()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | IList< T > TaleWorlds.Library.MBMath.TopologySort< T > | ( | IEnumerable< T > | *source*, | |  |  | Func< T, IEnumerable< T > > | *getDependencies* ) | | static |

Returns

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a9dbf41132189d70b182b41d3e6273f8c)FindPlaneLineIntersectionPointWithNormal()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.MBMath.FindPlaneLineIntersectionPointWithNormal | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *planeP1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *planeNormal*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *mouseP1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *mouseP2*, | |  |  | out bool | *exceptionZero* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a2f2c55d26248cf6ccb7396d228175b19)TwoPI
-------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Library.MBMath.TwoPI = (float)(Math.PI \* 2) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a013af96a5b045a1764de05b3b281d8da)PI
----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Library.MBMath.PI = (float)Math.PI | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a0938509cc7944fc6c8b8b3e5884d1f69)HalfPI
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Library.MBMath.HalfPI = (float)(Math.PI \* 0.5) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a0ed3d385f3876f74f455a7b5d867639a)E
---------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Library.MBMath.E = (float)Math.E | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a4078d51bcfb3c1b08cfdd45dabba52f9)DegreesToRadians
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Library.MBMath.DegreesToRadians = ([PI](class_tale_worlds_1_1_library_1_1_m_b_math.html#a013af96a5b045a1764de05b3b281d8da) / 180.0f) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a23b62719f22f2173171278c3698ddf43)RadiansToDegrees
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Library.MBMath.RadiansToDegrees = (180f / [PI](class_tale_worlds_1_1_library_1_1_m_b_math.html#a013af96a5b045a1764de05b3b281d8da)) | | static |

[◆](class_tale_worlds_1_1_library_1_1_m_b_math.html#a36081a17eb9a0cc2bc296b2ff4ecec55)Epsilon
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const float TaleWorlds.Library.MBMath.Epsilon = 0.00001f | | static |

