--- SOURCE: class_tale_worlds_1_1_library_1_1_parameter_container.html ---

TaleWorlds.Library.ParameterContainer Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ParameterContainer](class_tale_worlds_1_1_library_1_1_parameter_container.html#ae81cc2f3dd4e63fbda555184c9e8d491) () |
| void | [AddParameter](class_tale_worlds_1_1_library_1_1_parameter_container.html#a7b75835b00b0c5fb0afc9b600aad77e5) (string key, string value, bool overwriteIfExists) |
|  | Adds a parameter. Use AddParameterConcurrent for thread safe alternative. |
| void | [AddParameterConcurrent](class_tale_worlds_1_1_library_1_1_parameter_container.html#ad70a1a646428e7c403e88dd974d766c5) (string key, string value, bool overwriteIfExists) |
|  | Adds a parameter. Thread safe but rather costly option. |
| void | [AddParametersConcurrent](class_tale_worlds_1_1_library_1_1_parameter_container.html#a52f95e0bbb87a7598e8f83c5755fba52) (IEnumerable< KeyValuePair< string, string > > parameters, bool overwriteIfExists) |
|  | Adds multiple parameters. Thread safe but rather costly option. |
| void | [ClearParameters](class_tale_worlds_1_1_library_1_1_parameter_container.html#a0c937dfa1b18e24b3374b57f00ce67c9) () |
| bool | [TryGetParameter](class_tale_worlds_1_1_library_1_1_parameter_container.html#a6cf2469593cdae99f159ee700e954a74) (string key, out string outValue) |
| bool | [TryGetParameterAsBool](class_tale_worlds_1_1_library_1_1_parameter_container.html#a846d4c27b753940861626bd5ac16b77a) (string key, out bool outValue) |
| bool | [TryGetParameterAsInt](class_tale_worlds_1_1_library_1_1_parameter_container.html#a55c20b46ae5ad60afcf6fe83b3ff81b9) (string key, out int outValue) |
| bool | [TryGetParameterAsUInt16](class_tale_worlds_1_1_library_1_1_parameter_container.html#a002e19295f7effdad3c98cfc98c97911) (string key, out ushort outValue) |
| bool | [TryGetParameterAsFloat](class_tale_worlds_1_1_library_1_1_parameter_container.html#a34cae783835354f330ab9b0fb1aba7e9) (string key, out float outValue) |
| bool | [TryGetParameterAsByte](class_tale_worlds_1_1_library_1_1_parameter_container.html#a72b04118c52febf9e1777fb022e9ba2c) (string key, out byte outValue) |
| bool | [TryGetParameterAsSByte](class_tale_worlds_1_1_library_1_1_parameter_container.html#ae90161c28b5f87ccf488e6b76ce7a088) (string key, out sbyte outValue) |
| bool | [TryGetParameterAsVec3](class_tale_worlds_1_1_library_1_1_parameter_container.html#ab1f7908bb266a8461f142a2a077dc1d0) (string key, out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) outValue) |
| bool | [TryGetParameterAsVec2](class_tale_worlds_1_1_library_1_1_parameter_container.html#aa734f7751fc6cb986307e067c0bad15e) (string key, out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) outValue) |
| string | [GetParameter](class_tale_worlds_1_1_library_1_1_parameter_container.html#acbc762d4e255e9531e14a417c4be0a8b) (string key) |
| [ParameterContainer](class_tale_worlds_1_1_library_1_1_parameter_container.html#ae81cc2f3dd4e63fbda555184c9e8d491) | [Clone](class_tale_worlds_1_1_library_1_1_parameter_container.html#a91de073ae5a6a5a565687c99a1af16db) () |

|  |  |
| --- | --- |
| Properties | |
| IEnumerable< KeyValuePair< string, string > > | [Iterator](class_tale_worlds_1_1_library_1_1_parameter_container.html#a6df54da86b6308a6dcc8fa08fb37f29f) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#ae81cc2f3dd4e63fbda555184c9e8d491)ParameterContainer()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Library.ParameterContainer.ParameterContainer | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#a7b75835b00b0c5fb0afc9b600aad77e5)AddParameter()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.ParameterContainer.AddParameter | ( | string | *key*, |
|  |  | string | *value*, |
|  |  | bool | *overwriteIfExists* ) |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#ad70a1a646428e7c403e88dd974d766c5)AddParameterConcurrent()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.ParameterContainer.AddParameterConcurrent | ( | string | *key*, |
|  |  | string | *value*, |
|  |  | bool | *overwriteIfExists* ) |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#a52f95e0bbb87a7598e8f83c5755fba52)AddParametersConcurrent()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.ParameterContainer.AddParametersConcurrent | ( | IEnumerable< KeyValuePair< string, string > > | *parameters*, |
|  |  | bool | *overwriteIfExists* ) |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#a0c937dfa1b18e24b3374b57f00ce67c9)ClearParameters()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.ParameterContainer.ClearParameters | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#a6cf2469593cdae99f159ee700e954a74)TryGetParameter()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.ParameterContainer.TryGetParameter | ( | string | *key*, |
|  |  | out string | *outValue* ) |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#a846d4c27b753940861626bd5ac16b77a)TryGetParameterAsBool()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.ParameterContainer.TryGetParameterAsBool | ( | string | *key*, |
|  |  | out bool | *outValue* ) |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#a55c20b46ae5ad60afcf6fe83b3ff81b9)TryGetParameterAsInt()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.ParameterContainer.TryGetParameterAsInt | ( | string | *key*, |
|  |  | out int | *outValue* ) |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#a002e19295f7effdad3c98cfc98c97911)TryGetParameterAsUInt16()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.ParameterContainer.TryGetParameterAsUInt16 | ( | string | *key*, |
|  |  | out ushort | *outValue* ) |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#a34cae783835354f330ab9b0fb1aba7e9)TryGetParameterAsFloat()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.ParameterContainer.TryGetParameterAsFloat | ( | string | *key*, |
|  |  | out float | *outValue* ) |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#a72b04118c52febf9e1777fb022e9ba2c)TryGetParameterAsByte()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.ParameterContainer.TryGetParameterAsByte | ( | string | *key*, |
|  |  | out byte | *outValue* ) |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#ae90161c28b5f87ccf488e6b76ce7a088)TryGetParameterAsSByte()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.ParameterContainer.TryGetParameterAsSByte | ( | string | *key*, |
|  |  | out sbyte | *outValue* ) |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#ab1f7908bb266a8461f142a2a077dc1d0)TryGetParameterAsVec3()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.ParameterContainer.TryGetParameterAsVec3 | ( | string | *key*, |
|  |  | out [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *outValue* ) |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#aa734f7751fc6cb986307e067c0bad15e)TryGetParameterAsVec2()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.Library.ParameterContainer.TryGetParameterAsVec2 | ( | string | *key*, |
|  |  | out [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *outValue* ) |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#acbc762d4e255e9531e14a417c4be0a8b)GetParameter()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| string TaleWorlds.Library.ParameterContainer.GetParameter | ( | string | *key* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#a91de073ae5a6a5a565687c99a1af16db)Clone()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [ParameterContainer](class_tale_worlds_1_1_library_1_1_parameter_container.html#ae81cc2f3dd4e63fbda555184c9e8d491) TaleWorlds.Library.ParameterContainer.Clone | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_parameter_container.html#a6df54da86b6308a6dcc8fa08fb37f29f)Iterator
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | IEnumerable<KeyValuePair<string, string> > TaleWorlds.Library.ParameterContainer.Iterator | | get |

