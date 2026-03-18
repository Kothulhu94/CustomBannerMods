--- SOURCE: struct_tale_worlds_1_1_library_1_1_quaternion.html ---

TaleWorlds.Library.Quaternion Struct Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) (float x, float y, float z, float w) |
| override int | [GetHashCode](struct_tale_worlds_1_1_library_1_1_quaternion.html#a1340e8faa8edc4849d1fdbefc235b0b7) () |
| override bool | [Equals](struct_tale_worlds_1_1_library_1_1_quaternion.html#aa63e0554e23f398cdda8597bed342ce2) (object obj) |
| float | [Normalize](struct_tale_worlds_1_1_library_1_1_quaternion.html#a72aa313f4437366c4ce310a9a6a6799c) () |
| float | [SafeNormalize](struct_tale_worlds_1_1_library_1_1_quaternion.html#a79b7aa8297ac4ee97a182f599199b119) () |
| float | [NormalizeWeighted](struct_tale_worlds_1_1_library_1_1_quaternion.html#a944ee15d17efabe5c5f81f3ce39536d6) () |
| void | [SetToRotationX](struct_tale_worlds_1_1_library_1_1_quaternion.html#af519b664c785528311c0fb97021376c5) (float angle) |
| void | [SetToRotationY](struct_tale_worlds_1_1_library_1_1_quaternion.html#a75f4d16e45fcf81a7dc0243331c36e90) (float angle) |
| void | [SetToRotationZ](struct_tale_worlds_1_1_library_1_1_quaternion.html#aff2923987e74a892dff358b2e20fc66f) (float angle) |
| void | [Flip](struct_tale_worlds_1_1_library_1_1_quaternion.html#ab02820cd58ec03b11dd7bd6801cb36ae) () |
| [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [TransformToParent](struct_tale_worlds_1_1_library_1_1_quaternion.html#a762761772f32bd6384bfd504690418fd) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) q) |
| [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [TransformToLocal](struct_tale_worlds_1_1_library_1_1_quaternion.html#a298e4fae7e992597408e242d98748f2e) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) q) |
| [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [TransformToLocalWithoutNormalize](struct_tale_worlds_1_1_library_1_1_quaternion.html#a538c0bbabb5678f2267e7122fa7fd4ea) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) q) |
| float | [Dotp4](struct_tale_worlds_1_1_library_1_1_quaternion.html#a6dd1af12c3bf8a3c7894ad3120e2fd21) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) q2) |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | [ToMat3](struct_tale_worlds_1_1_library_1_1_quaternion.html#ae7b574d633dea68c6c4461b79dd0dc1f) () |
| bool | [InverseDirection](struct_tale_worlds_1_1_library_1_1_quaternion.html#a084796368a242ee35d83145b935189e4) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) q2) |
| [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [Conjugate](struct_tale_worlds_1_1_library_1_1_quaternion.html#a72d850ada9c3fe390bfaf7066e5e8098) () |
| [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [Inverse](struct_tale_worlds_1_1_library_1_1_quaternion.html#aabeed0bbd4dbaec48f18e8c7793d6ee8) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [operator==](struct_tale_worlds_1_1_library_1_1_quaternion.html#a5a1fff77493d34f819fd0601c2f70970) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) a, [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) b) |
| static bool | [operator!=](struct_tale_worlds_1_1_library_1_1_quaternion.html#a8e04a9c2ccce4184b04fdfa34175d482) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) a, [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) b) |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [operator+](struct_tale_worlds_1_1_library_1_1_quaternion.html#a70d8dffd1bcffcc2e4e3f7cc61cbed16) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) a, [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) b) |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [operator-](struct_tale_worlds_1_1_library_1_1_quaternion.html#a2012c83fc8769e40e5f9e79d0d15ad86) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) a, [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) b) |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [operator\*](struct_tale_worlds_1_1_library_1_1_quaternion.html#a38161a922bbf1e59a865c76204a4af3f) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) a, float b) |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [operator\*](struct_tale_worlds_1_1_library_1_1_quaternion.html#aba15613b6dd20f749e8471de89a7f506) (float s, [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) v) |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [operator\*](struct_tale_worlds_1_1_library_1_1_quaternion.html#ae81d1140bac2b5891e48a5f15b5a6f15) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) a, [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) b) |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [operator/](struct_tale_worlds_1_1_library_1_1_quaternion.html#a877f8d200a40dc1277d220c2050db316) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) v, float s) |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [Slerp](struct_tale_worlds_1_1_library_1_1_quaternion.html#a120daa8942e9a984bf6c2b24b5d994f6) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) from, [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) to, float t) |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [Lerp](struct_tale_worlds_1_1_library_1_1_quaternion.html#a926878ff1c236454a95c4d2816ef9626) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) from, [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) to, float t) |
| static [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | [Mat3FromQuaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a05a3fc37e583441baa0fcd7a7e6aa4b9) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) quat) |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [QuaternionFromEulerAngles](struct_tale_worlds_1_1_library_1_1_quaternion.html#a136440c2ec3080e9c969f7a0971e98dc) (float yaw, float pitch, float roll) |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [QuaternionFromMat3](struct_tale_worlds_1_1_library_1_1_quaternion.html#ade66f7bea854e5318f1f0000fae77e63) ([Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) m) |
| static void | [AxisAngleFromQuaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#aedc12d4582a75cdb93403f9b44607853) (out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) axis, out float angle, [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) quat) |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [QuaternionFromAxisAngle](struct_tale_worlds_1_1_library_1_1_quaternion.html#a1ea913ec1140e2890170ba633422b265) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) axis, float angle) |
| static [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [EulerAngleFromQuaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#afda9488c4274fd6f37f958fec407ec70) ([Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) quat) |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [FindShortestArcAsQuaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#afc0f1946edd4d1104a27e47689fee854) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) v0, [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) v1) |

|  |  |
| --- | --- |
| Public Attributes | |
| float | [W](struct_tale_worlds_1_1_library_1_1_quaternion.html#a9c4a3a7d741867e61cc2ff1cf7e2544f) |
| float | [X](struct_tale_worlds_1_1_library_1_1_quaternion.html#abc60bb01a96a81b6642972ec80074394) |
| float | [Y](struct_tale_worlds_1_1_library_1_1_quaternion.html#a5a19fc6c6e40dd72d16f8a4210617cb0) |
| float | [Z](struct_tale_worlds_1_1_library_1_1_quaternion.html#a02c5ebf160cc3c261d62ddc88fd95995) |

|  |  |
| --- | --- |
| Properties | |
| float | [this[int i]](struct_tale_worlds_1_1_library_1_1_quaternion.html#aa3de1e397918294fa03415dad7c3b69b) `[get, set]` |
| bool | [IsIdentity](struct_tale_worlds_1_1_library_1_1_quaternion.html#a2b3a13dd965990f5e327e8963ff7b61a) `[get]` |
| bool | [IsUnit](struct_tale_worlds_1_1_library_1_1_quaternion.html#a980856358af9937f64bd885ca096ae0e) `[get]` |
| static [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | [Identity](struct_tale_worlds_1_1_library_1_1_quaternion.html#a47445da766b64af4d1ea2abc6f8ab416) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130)Quaternion()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Library.Quaternion.Quaternion | ( | float | *x*, |
|  |  | float | *y*, |
|  |  | float | *z*, |
|  |  | float | *w* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a1340e8faa8edc4849d1fdbefc235b0b7)GetHashCode()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Library.Quaternion.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#aa63e0554e23f398cdda8597bed342ce2)Equals()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Library.Quaternion.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a5a1fff77493d34f819fd0601c2f70970)operator==()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Quaternion.operator== | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *a*, | |  |  | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a8e04a9c2ccce4184b04fdfa34175d482)operator!=()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Library.Quaternion.operator!= | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *a*, | |  |  | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a70d8dffd1bcffcc2e4e3f7cc61cbed16)operator+()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.operator+ | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *a*, | |  |  | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a2012c83fc8769e40e5f9e79d0d15ad86)operator-()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.operator- | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *a*, | |  |  | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a38161a922bbf1e59a865c76204a4af3f)operator\*() [1/3]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.operator\* | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *a*, | |  |  | float | *b* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#aba15613b6dd20f749e8471de89a7f506)operator\*() [2/3]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.operator\* | ( | float | *s*, | |  |  | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *v* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#ae81d1140bac2b5891e48a5f15b5a6f15)operator\*() [3/3]
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.operator\* | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *a*, | |  |  | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a877f8d200a40dc1277d220c2050db316)operator/()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.operator/ | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *v*, | |  |  | float | *s* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a72aa313f4437366c4ce310a9a6a6799c)Normalize()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Library.Quaternion.Normalize | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a79b7aa8297ac4ee97a182f599199b119)SafeNormalize()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Library.Quaternion.SafeNormalize | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a944ee15d17efabe5c5f81f3ce39536d6)NormalizeWeighted()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Library.Quaternion.NormalizeWeighted | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#af519b664c785528311c0fb97021376c5)SetToRotationX()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Quaternion.SetToRotationX | ( | float | *angle* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a75f4d16e45fcf81a7dc0243331c36e90)SetToRotationY()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Quaternion.SetToRotationY | ( | float | *angle* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#aff2923987e74a892dff358b2e20fc66f)SetToRotationZ()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Quaternion.SetToRotationZ | ( | float | *angle* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#ab02820cd58ec03b11dd7bd6801cb36ae)Flip()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.Quaternion.Flip | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a762761772f32bd6384bfd504690418fd)TransformToParent()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.TransformToParent | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *q* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a298e4fae7e992597408e242d98748f2e)TransformToLocal()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.TransformToLocal | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *q* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a538c0bbabb5678f2267e7122fa7fd4ea)TransformToLocalWithoutNormalize()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.TransformToLocalWithoutNormalize | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *q* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a120daa8942e9a984bf6c2b24b5d994f6)Slerp()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.Slerp | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *from*, | |  |  | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *to*, | |  |  | float | *t* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a926878ff1c236454a95c4d2816ef9626)Lerp()
-----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.Lerp | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *from*, | |  |  | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *to*, | |  |  | float | *t* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a05a3fc37e583441baa0fcd7a7e6aa4b9)Mat3FromQuaternion()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) TaleWorlds.Library.Quaternion.Mat3FromQuaternion | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *quat* | ) |  | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a136440c2ec3080e9c969f7a0971e98dc)QuaternionFromEulerAngles()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.QuaternionFromEulerAngles | ( | float | *yaw*, | |  |  | float | *pitch*, | |  |  | float | *roll* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#ade66f7bea854e5318f1f0000fae77e63)QuaternionFromMat3()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.QuaternionFromMat3 | ( | [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) | *m* | ) |  | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#aedc12d4582a75cdb93403f9b44607853)AxisAngleFromQuaternion()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Library.Quaternion.AxisAngleFromQuaternion | ( | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *axis*, | |  |  | out float | *angle*, | |  |  | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *quat* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a1ea913ec1140e2890170ba633422b265)QuaternionFromAxisAngle()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.QuaternionFromAxisAngle | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *axis*, | |  |  | float | *angle* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#afda9488c4274fd6f37f958fec407ec70)EulerAngleFromQuaternion()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.Quaternion.EulerAngleFromQuaternion | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *quat* | ) |  | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#afc0f1946edd4d1104a27e47689fee854)FindShortestArcAsQuaternion()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.FindShortestArcAsQuaternion | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *v0*, | |  |  | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *v1* ) | | static |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a6dd1af12c3bf8a3c7894ad3120e2fd21)Dotp4()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.Library.Quaternion.Dotp4 | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *q2* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#ae7b574d633dea68c6c4461b79dd0dc1f)ToMat3()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Mat3](struct_tale_worlds_1_1_library_1_1_mat3.html) TaleWorlds.Library.Quaternion.ToMat3 | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a084796368a242ee35d83145b935189e4)InverseDirection()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.Quaternion.InverseDirection | ( | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) | *q2* | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a72d850ada9c3fe390bfaf7066e5e8098)Conjugate()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.Conjugate | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#aabeed0bbd4dbaec48f18e8c7793d6ee8)Inverse()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.Inverse | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a9c4a3a7d741867e61cc2ff1cf7e2544f)W
------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Library.Quaternion.W |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#abc60bb01a96a81b6642972ec80074394)X
------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Library.Quaternion.X |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a5a19fc6c6e40dd72d16f8a4210617cb0)Y
------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Library.Quaternion.Y |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a02c5ebf160cc3c261d62ddc88fd95995)Z
------------------------------------------------------------------------------------------

|  |
| --- |
| float TaleWorlds.Library.Quaternion.Z |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#aa3de1e397918294fa03415dad7c3b69b)this[int i]
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Library.Quaternion.this[int i] | | getset |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a2b3a13dd965990f5e327e8963ff7b61a)IsIdentity
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.Quaternion.IsIdentity | | get |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a980856358af9937f64bd885ca096ae0e)IsUnit
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Library.Quaternion.IsUnit | | get |

[◆](struct_tale_worlds_1_1_library_1_1_quaternion.html#a47445da766b64af4d1ea2abc6f8ab416)Identity
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Quaternion](struct_tale_worlds_1_1_library_1_1_quaternion.html#a32c913d8794eabe0d598bb92553dc130) TaleWorlds.Library.Quaternion.Identity | | staticget |

