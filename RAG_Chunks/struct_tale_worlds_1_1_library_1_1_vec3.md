--- SOURCE: struct_tale_worlds_1_1_library_1_1_vec3.html ---

TaleWorlds.Library.Vec3 Struct Reference3D Vector class

|  |  |
| --- | --- |
| Classes | |
| struct | [StackArray8Vec3](struct_tale_worlds_1_1_library_1_1_vec3_1_1_stack_array8_vec3.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) (float [x](struct_tale_worlds_1_1_library_1_1_vec3.html#af3175aa2aec75bd5f209001e81064fed)=0f, float [y](struct_tale_worlds_1_1_library_1_1_vec3.html#a72867873003b3a0ef97960267a98de06)=0f, float [z](struct_tale_worlds_1_1_library_1_1_vec3.html#a303a358877d7d5f18a70202a4e82e82e)=0f, float [w](struct_tale_worlds_1_1_library_1_1_vec3.html#a9534d03a271bc4195ca2bd2cf986e568)=-1f) |
|  | Initializes a new instance of the [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html "3D Vector class") struct. |
|  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#a67040ce34285ddb11f2ef33eb0c4a50c) (Vec3 c, float [w](struct_tale_worlds_1_1_library_1_1_vec3.html#a9534d03a271bc4195ca2bd2cf986e568)=-1) |
|  | Initializes a new instance of the [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html "3D Vector class") struct. |
|  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#a536f8d36759b573b37b01e886e17941b) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) xy, float [z](struct_tale_worlds_1_1_library_1_1_vec3.html#a303a358877d7d5f18a70202a4e82e82e)=0f, float [w](struct_tale_worlds_1_1_library_1_1_vec3.html#a9534d03a271bc4195ca2bd2cf986e568)=-1f) |
|  | Initializes a new instance of the [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html "3D Vector class") struct. |
|  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#a51546a7de80ac63df5a520a7d83340c7) (System.Numerics.Vector3 vector3) |
| override bool | [Equals](struct_tale_worlds_1_1_library_1_1_vec3.html#a290b3c03870a6de6927255daa31ce144) (object obj) |
|  | Determines whether the specified generic object is equal to this instance. |
| override int | [GetHashCode](struct_tale_worlds_1_1_library_1_1_vec3.html#aa8f02734b516a4091ed45a0ca77ddd16) () |
|  | Returns a hash code for this instance. This value changes when one of the X, Y, or Z values changes. Therefore, do not put [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html "3D Vector class") objects to a Hash table. If you have to, then do not change any of the values of the object after it is put to a Hash table. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [NormalizedCopy](struct_tale_worlds_1_1_library_1_1_vec3.html#afe6b855fc1722c331c6891963368d69e) () |
| float | [Normalize](struct_tale_worlds_1_1_library_1_1_vec3.html#afcc32bd63d5ac8936e97db32aa487793) () |
|  | Normalizes current vector. |
| void | [ClampMagnitude](struct_tale_worlds_1_1_library_1_1_vec3.html#acb98cd8ff67c2ee95bcebb713ba16079) (float min, float max) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [ClampedCopy](struct_tale_worlds_1_1_library_1_1_vec3.html#a3f3a033ffca8aea3aead5572ef87de85) (float min, float max) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [ClampedCopy](struct_tale_worlds_1_1_library_1_1_vec3.html#a7f78a1d26be427246cd327cac38e8aaf) (float min, float max, out bool valueClamped) |
| void | [NormalizeWithoutChangingZ](struct_tale_worlds_1_1_library_1_1_vec3.html#ad94dd853eb2f57cfee065aab6dfb4397) () |
|  | Normalizes current vector without changing Z component. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [CrossProductWithUp](struct_tale_worlds_1_1_library_1_1_vec3.html#a8f7e2bf206f7cd03a70ec949ddf6a215) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [CrossProductWithUpAsLeftParameter](struct_tale_worlds_1_1_library_1_1_vec3.html#a6af64ae495ef3ae06cd5c939d9a1da46) () |
| bool | [NearlyEquals](struct_tale_worlds_1_1_library_1_1_vec3.html#ae808ab5d4eb4a20ead581f5386506afa) (in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v, float epsilon=MBMath.Epsilon) |
|  | Checks if vector is nearly equals to another vector. |
| void | [RotateAboutX](struct_tale_worlds_1_1_library_1_1_vec3.html#a8fa420314571174e48f49bb3366d306c) (float a) |
|  | Rotates the vector about X axis. |
| void | [RotateAboutY](struct_tale_worlds_1_1_library_1_1_vec3.html#a612171e61ff0ec416587588510b5d6fe) (float a) |
|  | Rotates the vector about Y axis. |
| void | [RotateAboutZ](struct_tale_worlds_1_1_library_1_1_vec3.html#a8b273a3b2b4aa74b010605aa8cf6ca0b) (float a) |
|  | Rotates the vector about Z axis. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [RotateAboutAnArbitraryVector](struct_tale_worlds_1_1_library_1_1_vec3.html#a6d6d743f33b5532ffa3c83fed0f29400) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) vec, float a) |
|  | Rotates the vector about param vector. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [Reflect](struct_tale_worlds_1_1_library_1_1_vec3.html#a5a4057fc6d86f50bc7008951639fd422) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) normal) |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [ProjectOnUnitVector](struct_tale_worlds_1_1_library_1_1_vec3.html#a0d2cd90ce048987c4796a8aee706fddc) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) ov) |
| float | [DistanceSquared](struct_tale_worlds_1_1_library_1_1_vec3.html#a1b7d9087c7c8e4a9c2f15e427be28960) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v) |
|  | Square of the length of distance from v. |
| float | [Distance](struct_tale_worlds_1_1_library_1_1_vec3.html#ab33567eb64a5bd74a0dd4db14882eff2) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v) |
|  | The length of distance from v. |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [RotateVectorToXYPlane](struct_tale_worlds_1_1_library_1_1_vec3.html#a80c52c8e2eadb739af3a921c69d30dec) () |
| override string | [ToString](struct_tale_worlds_1_1_library_1_1_vec3.html#a3e6259d44d9eafbd05412b4a43024cc6) () |
|  | Creates readable string representation. |
| string | [ToString](struct_tale_worlds_1_1_library_1_1_vec3.html#a99ebb59c1b37153a5a53f55ce96636f1) (string format) |
|  | Creates readable string representation where each vector element uses the passed format for its string representation. |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [Abs](struct_tale_worlds_1_1_library_1_1_vec3.html#a7e0ab0757c88a42cedfbe1e7fdc55186) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) vec) |
| static | [operator System.Numerics.Vector3](struct_tale_worlds_1_1_library_1_1_vec3.html#a47d728011a5057e329f34126533d4e17) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) vec3) |
| static float | [DotProduct](struct_tale_worlds_1_1_library_1_1_vec3.html#a514807dde05298767830b67f2073ec73) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v2) |
|  | Dot product of two vectors. |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [Lerp](struct_tale_worlds_1_1_library_1_1_vec3.html#ab917455727064a1feb58dbdd974b58eb) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v2, float alpha) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [Slerp](struct_tale_worlds_1_1_library_1_1_vec3.html#a323eb4933a5126606e4f5db9ffe36dab) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) start, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) end, float percent) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [Vec3Max](struct_tale_worlds_1_1_library_1_1_vec3.html#ad6c67750590d9733e568d3c32f075bfd) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v2) |
|  | Returns maximum of each component of two vectors. |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [Vec3Min](struct_tale_worlds_1_1_library_1_1_vec3.html#a432612a38e10909e25f272a3738b177a) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v2) |
|  | Returns minimum of each component of two vectors. |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [CrossProduct](struct_tale_worlds_1_1_library_1_1_vec3.html#a3c43ee3d435aa7e12b74790f8ebc3a2c) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) va, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) vb) |
|  | Cross product of two vectors. |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [ElementWiseProduct](struct_tale_worlds_1_1_library_1_1_vec3.html#a59f65d58e14bf95ad99e902413e4cf28) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) va, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) vb) |
|  | Element-wise product of two vectors. |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [ElementWiseDivision](struct_tale_worlds_1_1_library_1_1_vec3.html#a846bdbcfc7f0d0467aabc876c95e9dca) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) va, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) vb) |
|  | Element-wise division of two vectors. |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [operator-](struct_tale_worlds_1_1_library_1_1_vec3.html#a232b825c380b15eea59d101a9fc57469) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v) |
|  | Implements the operator -. |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [operator+](struct_tale_worlds_1_1_library_1_1_vec3.html#a623f6f76fa6685fb8450b640e84669a5) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v2) |
|  | Implements the operator +. |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [operator-](struct_tale_worlds_1_1_library_1_1_vec3.html#a147b3a2489bb0992198f28a84f33fe60) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v2) |
|  | Implements the operator -. |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [operator\*](struct_tale_worlds_1_1_library_1_1_vec3.html#a172bc79e021bb018e313fa9b517b8efb) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v, float f) |
|  | Implements scalar to vector product. |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [operator\*](struct_tale_worlds_1_1_library_1_1_vec3.html#ab7a8e047faa81665b5acde83ff8f8447) (float f, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [operator\*](struct_tale_worlds_1_1_library_1_1_vec3.html#a22d652685eeb0549727f2ee58774a04a) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v, [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) frame) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [operator/](struct_tale_worlds_1_1_library_1_1_vec3.html#aa745a35fe47020884d329705bb926630) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v, float f) |
|  | Implements vector and float division. Internally, the division is converted to a multiplication for performance reasons. |
| static bool | [operator==](struct_tale_worlds_1_1_library_1_1_vec3.html#a54f241116262a702c87d209302610adf) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v2) |
|  | Implements the operator ==. |
| static bool | [operator!=](struct_tale_worlds_1_1_library_1_1_vec3.html#a947067a72595e7012d3f18ca2fc87e1e) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v2) |
|  | Implements the operator !=. |
| static float | [AngleBetweenTwoVectors](struct_tale_worlds_1_1_library_1_1_vec3.html#ac9e47107234547891d356817ab81620b) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v1, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) v2) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [Parse](struct_tale_worlds_1_1_library_1_1_vec3.html#a1b77495489794f72f25881b58f886651) (string input) |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [x](struct_tale_worlds_1_1_library_1_1_vec3.html#af3175aa2aec75bd5f209001e81064fed) |
|  | X component of the vector. |
| float | [y](struct_tale_worlds_1_1_library_1_1_vec3.html#a72867873003b3a0ef97960267a98de06) |
|  | Y component of the vector. |
| float | [z](struct_tale_worlds_1_1_library_1_1_vec3.html#a303a358877d7d5f18a70202a4e82e82e) |
|  | Z component of the vector. |
| float | [w](struct_tale_worlds_1_1_library_1_1_vec3.html#a9534d03a271bc4195ca2bd2cf986e568) |
|  | W component of the vector. |

|  |  |
| --- | --- |
| Static Public Attributes | |
| static readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [Side](struct_tale_worlds_1_1_library_1_1_vec3.html#abae352dee77525e4679b8511a5270a7c) = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11)(1, 0, 0) |
| static readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [Forward](struct_tale_worlds_1_1_library_1_1_vec3.html#a2259d022062fde9ab61d8474aa79c03c) = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11)(0, 1, 0) |
| static readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [Up](struct_tale_worlds_1_1_library_1_1_vec3.html#a509119c0855866c161b12c78033b6ea3) = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11)(0, 0, 1) |
| static readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [One](struct_tale_worlds_1_1_library_1_1_vec3.html#a129e36087b5bb897b4050a5bea672c13) = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11)(1, 1, 1) |
| static readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [Zero](struct_tale_worlds_1_1_library_1_1_vec3.html#af98ad32c26dc5c52ad2198f3a9bf1975) = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11)(0, 0, 0) |
| static readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | [Invalid](struct_tale_worlds_1_1_library_1_1_vec3.html#ab975cc2200f9444a5c6678c3a31c10c5) = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11)(float.NaN, float.NaN, float.NaN) |

|  |  |
| --- | --- |
| Properties | |
| float | [X](struct_tale_worlds_1_1_library_1_1_vec3.html#acbecdbf256a8a01f2f6b9c96ab7259e3) `[get]` |
| float | [Y](struct_tale_worlds_1_1_library_1_1_vec3.html#ad171bf11703a64990cbd474fe0fa4797) `[get]` |
| float | [Z](struct_tale_worlds_1_1_library_1_1_vec3.html#a3bec41ed8593c07d559e42195322a423) `[get]` |
| float | [this[int i]](struct_tale_worlds_1_1_library_1_1_vec3.html#a25a9fd32b065df08dfa35ca216bf3e15) `[get, set]` |
|  | Gets or sets the vector value with the specified index. |
| float | [Length](struct_tale_worlds_1_1_library_1_1_vec3.html#a7f71b9381c16b299c18476e3f076001c) `[get]` |
|  | Calculates and returns the length of the vector. |
| float | [LengthSquared](struct_tale_worlds_1_1_library_1_1_vec3.html#a0ed370062975fcda791154200c911154) `[get]` |
|  | Calculates and returns the square of the length of the vector. |
| bool | [IsValid](struct_tale_worlds_1_1_library_1_1_vec3.html#af708f9377392425d9de2435c4c2dfb37) `[get]` |
|  | Determines if all (XYZ) components are valid (not NaN or Infinite) or not. |
| bool | [IsValidXYZW](struct_tale_worlds_1_1_library_1_1_vec3.html#aeec08b97834c48d96aba49b43a25d0cd) `[get]` |
|  | Determines if all (XYZW) components are valid (not NaN or Infinite) or not. |
| bool | [IsUnit](struct_tale_worlds_1_1_library_1_1_vec3.html#aa40f1bed5499e56fb54dda36caef1ad3) `[get]` |
|  | Determines whether vector is unit. <c>true</c> if vector is unit; otherwise, <c>false</c>. |
| bool | [IsNonZero](struct_tale_worlds_1_1_library_1_1_vec3.html#ac4382e5de902f77ea1027d598a5716cc) `[get]` |
|  | Determines whether if vector is non zero. <c>true</c> if vector is non zero; otherwise, <c>false</c>. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [AsVec2](struct_tale_worlds_1_1_library_1_1_vec3.html#a47c86eb8b62111cec80e56e74dfb4017) `[get, set]` |
|  | Returns new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html "2D vector class") from X,Y components, discards Z. |
| uint | [ToARGB](struct_tale_worlds_1_1_library_1_1_vec3.html#a6d7fa3b223f4e311d7247e7de2e07724) `[get]` |
| float | [RotationZ](struct_tale_worlds_1_1_library_1_1_vec3.html#a4af5b7976ddc6bc72f2100e111f05f2c) `[get]` |
|  | Rotation angle about the up/z-axis. Yaw rotation value. Value is in radians. |
| float | [RotationX](struct_tale_worlds_1_1_library_1_1_vec3.html#a43c3765d24a8cc5de066eb831791b9ab) `[get]` |
|  | Rotation angle about the side/x-axis. Pitch rotation value. Value is in radians. |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11)Vec3() [1/4]
-----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Vec3.Vec3 | ( | float | *x* = 0f, |
|  |  | float | *y* = 0f, |
|  |  | float | *z* = 0f, |
|  |  | float | *w* = -1f ) |

Parameters
:   |  |  |
    | --- | --- |
    | x | X value. |
    | y | Y value. |
    | z | Z value. |
    | w | W value. |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a67040ce34285ddb11f2ef33eb0c4a50c)Vec3() [2/4]
-----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Vec3.Vec3 | ( | Vec3 | *c*, |
|  |  | float | *w* = -1 ) |

Parameters
:   |  |  |
    | --- | --- |
    | c | The vector that the values are copied from. |
    | w | W value. |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a536f8d36759b573b37b01e886e17941b)Vec3() [3/4]
-----------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Vec3.Vec3 | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *xy*, |
|  |  | float | *z* = 0f, |
|  |  | float | *w* = -1f ) |

Parameters
:   |  |  |
    | --- | --- |
    | xy | The vector that the values are copied from. |
    | z | Z value. |
    | w | W value. |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a51546a7de80ac63df5a520a7d83340c7)Vec3() [4/4]
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.Vec3.Vec3 | ( | System.Numerics.Vector3 | *vector3* | ) |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a7e0ab0757c88a42cedfbe1e7fdc55186)Abs()
----------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.Abs | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *vec* | ) |  | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a47d728011a5057e329f34126533d4e17)operator System.Numerics.Vector3()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | TaleWorlds.Library.Vec3.operator System.Numerics.Vector3 | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *vec3* | ) |  | | explicitstatic |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a514807dde05298767830b67f2073ec73)DotProduct()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.Vec3.DotProduct | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | v1 | First vector |
    | v2 | Second vector |

Returns
:   Dot product

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#ab917455727064a1feb58dbdd974b58eb)Lerp()
-----------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.Lerp | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v2*, | |  |  | float | *alpha* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a323eb4933a5126606e4f5db9ffe36dab)Slerp()
------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.Slerp | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *start*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *end*, | |  |  | float | *percent* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#ad6c67750590d9733e568d3c32f075bfd)Vec3Max()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.Vec3Max | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | v1 | First vector |
    | v2 | Second vector |

Returns
:   Elementvise maximum of two vectors

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a432612a38e10909e25f272a3738b177a)Vec3Min()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.Vec3Min | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | v1 | First vector |
    | v2 | Second vector |

Returns
:   Element vise minimum of two vectors

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a3c43ee3d435aa7e12b74790f8ebc3a2c)CrossProduct()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.CrossProduct | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *va*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *vb* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | va | First vector |
    | vb | Second vector |

Returns
:   Cross product

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a59f65d58e14bf95ad99e902413e4cf28)ElementWiseProduct()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.ElementWiseProduct | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *va*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *vb* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | va | First vector |
    | vb | Second vector |

Returns
:   Element-wise product

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a846bdbcfc7f0d0467aabc876c95e9dca)ElementWiseDivision()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.ElementWiseDivision | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *va*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *vb* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | va | First vector |
    | vb | Second vector |

Returns
:   Element-wise division

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a232b825c380b15eea59d101a9fc57469)operator-() [1/2]
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.operator- | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v* | ) |  | | static |

Parameters
:   |  |  |
    | --- | --- |
    | v | The v. |

Returns
:   Negative of vector

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a623f6f76fa6685fb8450b640e84669a5)operator+()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.operator+ | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | v1 | The v1. |
    | v2 | The v2. |

Returns
:   Summation of vectors.

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a147b3a2489bb0992198f28a84f33fe60)operator-() [2/2]
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.operator- | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | v1 | The v1. |
    | v2 | The v2. |

Returns
:   Difference of vectors

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a172bc79e021bb018e313fa9b517b8efb)operator\*() [1/3]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.operator\* | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v*, | |  |  | float | *f* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | v | The v. |
    | f | The f. |

Returns
:   The result of the operator.

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#ab7a8e047faa81665b5acde83ff8f8447)operator\*() [2/3]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.operator\* | ( | float | *f*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a22d652685eeb0549727f2ee58774a04a)operator\*() [3/3]
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.operator\* | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v*, | |  |  | [MatrixFrame](struct_tale_worlds_1_1_library_1_1_matrix_frame.html) | *frame* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#aa745a35fe47020884d329705bb926630)operator/()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.operator/ | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v*, | |  |  | float | *f* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | v | The v. |
    | f | The f. |

Returns
:   The result of the operator.

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a54f241116262a702c87d209302610adf)operator==()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Vec3.operator== | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | v1 | The v1. |
    | v2 | The v2. |

Returns
:   The result of the operator.

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a947067a72595e7012d3f18ca2fc87e1e)operator!=()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Vec3.operator!= | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | v1 | The v1. |
    | v2 | The v2. |

Returns
:   The result of the operator.

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a290b3c03870a6de6927255daa31ce144)Equals()
-------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Library.Vec3.Equals | ( | object | *obj* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | obj | Thegeneric object to compare with this instance. |

Returns
:   `true` if the specified object is equal to this instance; otherwise, `false`.

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#aa8f02734b516a4091ed45a0ca77ddd16)GetHashCode()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Library.Vec3.GetHashCode | ( |  | ) |  |

Returns
:   A hash code for this instance.

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#afe6b855fc1722c331c6891963368d69e)NormalizedCopy()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.NormalizedCopy | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#afcc32bd63d5ac8936e97db32aa487793)Normalize()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Library.Vec3.Normalize | ( |  | ) |  |

Returns
:   Length of the vector before normalization

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#acb98cd8ff67c2ee95bcebb713ba16079)ClampMagnitude()
---------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.Vec3.ClampMagnitude | ( | float | *min*, |
|  |  | float | *max* ) |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a3f3a033ffca8aea3aead5572ef87de85)ClampedCopy() [1/2]
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.ClampedCopy | ( | float | *min*, |
|  |  | float | *max* ) |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a7f78a1d26be427246cd327cac38e8aaf)ClampedCopy() [2/2]
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.ClampedCopy | ( | float | *min*, |
|  |  | float | *max*, |
|  |  | out bool | *valueClamped* ) |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#ad94dd853eb2f57cfee065aab6dfb4397)NormalizeWithoutChangingZ()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Vec3.NormalizeWithoutChangingZ | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a8f7e2bf206f7cd03a70ec949ddf6a215)CrossProductWithUp()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.CrossProductWithUp | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a6af64ae495ef3ae06cd5c939d9a1da46)CrossProductWithUpAsLeftParameter()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.CrossProductWithUpAsLeftParameter | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#ae808ab5d4eb4a20ead581f5386506afa)NearlyEquals()
-------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.Vec3.NearlyEquals | ( | in [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v*, |
|  |  | float | *epsilon* = MBMath::Epsilon ) |

Parameters
:   |  |  |
    | --- | --- |
    | v | Vector that is compared. |
    | epsilon | Epsilon for equality. |

Returns
:   true is nearly equals

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a8fa420314571174e48f49bb3366d306c)RotateAboutX()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Vec3.RotateAboutX | ( | float | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | Rotation angle in radians. |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a612171e61ff0ec416587588510b5d6fe)RotateAboutY()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Vec3.RotateAboutY | ( | float | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | Rotation angle in radians |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a8b273a3b2b4aa74b010605aa8cf6ca0b)RotateAboutZ()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Vec3.RotateAboutZ | ( | float | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | Rotation angle in radians |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a6d6d743f33b5532ffa3c83fed0f29400)RotateAboutAnArbitraryVector()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.RotateAboutAnArbitraryVector | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *vec*, |
|  |  | float | *a* ) |

Parameters
:   |  |  |
    | --- | --- |
    | vec | Rotation axis |
    | a | Rotation angle in radians |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a5a4057fc6d86f50bc7008951639fd422)Reflect()
--------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.Reflect | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *normal* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a0d2cd90ce048987c4796a8aee706fddc)ProjectOnUnitVector()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.ProjectOnUnitVector | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *ov* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a1b7d9087c7c8e4a9c2f15e427be28960)DistanceSquared()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Library.Vec3.DistanceSquared | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | v | Vector v. |

Returns
:   Length square of difference.

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#ab33567eb64a5bd74a0dd4db14882eff2)Distance()
---------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Library.Vec3.Distance | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | v | Vector v. |

Returns
:   Length difference

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a80c52c8e2eadb739af3a921c69d30dec)RotateVectorToXYPlane()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.RotateVectorToXYPlane | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#ac9e47107234547891d356817ab81620b)AngleBetweenTwoVectors()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | float TaleWorlds.Library.Vec3.AngleBetweenTwoVectors | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v1*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) | *v2* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a3e6259d44d9eafbd05412b4a43024cc6)ToString() [1/2]
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Library.Vec3.ToString | ( |  | ) |  |

Returns
:   Output string

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a99ebb59c1b37153a5a53f55ce96636f1)ToString() [2/2]
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Library.Vec3.ToString | ( | string | *format* | ) |  |

Returns
:   Output string

REMARK\_ATES: Strange enough this cannot be overridden like ToString so its added as a new method.

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a1b77495489794f72f25881b58f886651)Parse()
------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.Parse | ( | string | *input* | ) |  | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#af3175aa2aec75bd5f209001e81064fed)x
------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Library.Vec3.x |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a72867873003b3a0ef97960267a98de06)y
------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Library.Vec3.y |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a303a358877d7d5f18a70202a4e82e82e)z
------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Library.Vec3.z |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a9534d03a271bc4195ca2bd2cf986e568)w
------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Library.Vec3.w |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#abae352dee77525e4679b8511a5270a7c)Side
---------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.Side = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11)(1, 0, 0) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a2259d022062fde9ab61d8474aa79c03c)Forward
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.Forward = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11)(0, 1, 0) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a509119c0855866c161b12c78033b6ea3)Up
-------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.Up = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11)(0, 0, 1) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a129e36087b5bb897b4050a5bea672c13)One
--------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.One = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11)(1, 1, 1) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#af98ad32c26dc5c52ad2198f3a9bf1975)Zero
---------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.Zero = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11)(0, 0, 0) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#ab975cc2200f9444a5c6678c3a31c10c5)Invalid
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11) TaleWorlds.Library.Vec3.Invalid = new [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html#aba071f3950503e0c8fdb8b8a52de5a11)(float.NaN, float.NaN, float.NaN) | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#acbecdbf256a8a01f2f6b9c96ab7259e3)X
------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Vec3.X | | get |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#ad171bf11703a64990cbd474fe0fa4797)Y
------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Vec3.Y | | get |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a3bec41ed8593c07d559e42195322a423)Z
------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Vec3.Z | | get |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a25a9fd32b065df08dfa35ca216bf3e15)this[int i]
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Vec3.this[int i] | | getset |

Parameters
:   |  |  |
    | --- | --- |
    | i | Index of the requested value. |

Returns
:   X if i = 0, Y if i = 1 and Z if i = 2.

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a7f71b9381c16b299c18476e3f076001c)Length
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Vec3.Length | | get |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a0ed370062975fcda791154200c911154)LengthSquared
------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Vec3.LengthSquared | | get |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#af708f9377392425d9de2435c4c2dfb37)IsValid
------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.Vec3.IsValid | | get |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#aeec08b97834c48d96aba49b43a25d0cd)IsValidXYZW
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.Vec3.IsValidXYZW | | get |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#aa40f1bed5499e56fb54dda36caef1ad3)IsUnit
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.Vec3.IsUnit | | get |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#ac4382e5de902f77ea1027d598a5716cc)IsNonZero
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.Vec3.IsNonZero | | get |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a47c86eb8b62111cec80e56e74dfb4017)AsVec2
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Library.Vec3.AsVec2 | | getset |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a6d7fa3b223f4e311d7247e7de2e07724)ToARGB
-----------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.Library.Vec3.ToARGB | | get |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a4af5b7976ddc6bc72f2100e111f05f2c)RotationZ
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Vec3.RotationZ | | get |

[◆](struct_tale_worlds_1_1_library_1_1_vec3.html#a43c3765d24a8cc5de066eb831791b9ab)RotationX
--------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Vec3.RotationX | | get |

