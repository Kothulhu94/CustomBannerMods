--- SOURCE: struct_tale_worlds_1_1_core_1_1_static_body_properties.html ---

TaleWorlds.Core.StaticBodyProperties Struct ReferenceInherits [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d) (ulong keyPart1, ulong keyPart2, ulong keyPart3, ulong keyPart4, ulong keyPart5, ulong keyPart6, ulong keyPart7, ulong keyPart8) |
| override int | [GetHashCode](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a3e1b6c373f4116f4696953a35da6da0a) () |
| override bool | [Equals](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#aff1b5e4a8859123e752745a0ec4b95ac) (object obj) |
| override string | [ToString](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a0f68e327e27220e5968681d1e7d548bc) () |
| void ISerializableObject. | [DeserializeFrom](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a6700aaf7b2d352370a0460ff03dce52f) ([IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) reader) |
| void ISerializableObject. | [SerializeTo](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a9c8add59978856b59a6a56a43a586179) ([IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) writer) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [FromXmlNode](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a8aaa4375c9ce624ca8573f1455ab0b69) (XmlNode node, out [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d) staticBodyProperties) |
| static bool | [operator==](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a5dc8e697f20ba0148776bed905a1dd6f) ([StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d) a, [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d) b) |
| static bool | [operator!=](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#aa2b1050d2a13e4172c5913f7486e2d56) ([StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d) a, [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d) b) |
| static [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d) | [GetRandomStaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a2838436cd7065ad4a20a8a4ac02c4b48) () |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [WeightKeyNo](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a15d6b27fa64484f5ffb417f22be539af) = 59 |
| const int | [BuildKeyNo](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a8a4f6e832f6c2c98b977535ce10d641e) = 60 |

|  |  |
| --- | --- |
| Properties | |
| ulong | [KeyPart1](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a5f319c12e19bbab769d5a678b62266f2) `[get]` |
| ulong | [KeyPart2](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#ae76a641ee10ea2d5c62234095586476d) `[get]` |
| ulong | [KeyPart3](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#ac7b2ea286551ee5b63b91673c81bfec7) `[get]` |
| ulong | [KeyPart4](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a06518ff9736c6db89a3673facb3b21c0) `[get]` |
| ulong | [KeyPart5](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a1a5d487c986f0a8257b6d59c9fb96026) `[get]` |
| ulong | [KeyPart6](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a13a48482a23699cffd5dfe259fbd9f90) `[get]` |
| ulong | [KeyPart7](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a6e8d33e590e023c6da6be61618d50ec7) `[get]` |
| ulong | [KeyPart8](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a86a14d60bdcda83d0a8f195818927f9d) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d)StaticBodyProperties()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.StaticBodyProperties.StaticBodyProperties | ( | ulong | *keyPart1*, |
|  |  | ulong | *keyPart2*, |
|  |  | ulong | *keyPart3*, |
|  |  | ulong | *keyPart4*, |
|  |  | ulong | *keyPart5*, |
|  |  | ulong | *keyPart6*, |
|  |  | ulong | *keyPart7*, |
|  |  | ulong | *keyPart8* ) |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a8aaa4375c9ce624ca8573f1455ab0b69)FromXmlNode()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Core.StaticBodyProperties.FromXmlNode | ( | XmlNode | *node*, | |  |  | out [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d) | *staticBodyProperties* ) | | static |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a3e1b6c373f4116f4696953a35da6da0a)GetHashCode()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Core.StaticBodyProperties.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#aff1b5e4a8859123e752745a0ec4b95ac)Equals()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Core.StaticBodyProperties.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a5dc8e697f20ba0148776bed905a1dd6f)operator==()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Core.StaticBodyProperties.operator== | ( | [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d) | *a*, | |  |  | [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#aa2b1050d2a13e4172c5913f7486e2d56)operator!=()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.Core.StaticBodyProperties.operator!= | ( | [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d) | *a*, | |  |  | [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d) | *b* ) | | static |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a0f68e327e27220e5968681d1e7d548bc)ToString()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Core.StaticBodyProperties.ToString | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a6700aaf7b2d352370a0460ff03dce52f)DeserializeFrom()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void ISerializableObject. TaleWorlds.Core.StaticBodyProperties.DeserializeFrom | ( | [IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) | *reader* | ) |  |

Implements [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aaaf5181fea51c7c2d4e365efe82bc703).

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a9c8add59978856b59a6a56a43a586179)SerializeTo()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void ISerializableObject. TaleWorlds.Core.StaticBodyProperties.SerializeTo | ( | [IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) | *writer* | ) |  |

Implements [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aac913af86c2a4128993048fc2023b4de).

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a2838436cd7065ad4a20a8a4ac02c4b48)GetRandomStaticBodyProperties()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [StaticBodyProperties](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#af9cee40f1ff75b9a39e1d1b5321cca1d) TaleWorlds.Core.StaticBodyProperties.GetRandomStaticBodyProperties | ( |  | ) |  | | static |

Member Data Documentation
-------------------------

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a15d6b27fa64484f5ffb417f22be539af)WeightKeyNo
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.StaticBodyProperties.WeightKeyNo = 59 | | static |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a8a4f6e832f6c2c98b977535ce10d641e)BuildKeyNo
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.Core.StaticBodyProperties.BuildKeyNo = 60 | | static |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a5f319c12e19bbab769d5a678b62266f2)KeyPart1
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.StaticBodyProperties.KeyPart1 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#ae76a641ee10ea2d5c62234095586476d)KeyPart2
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.StaticBodyProperties.KeyPart2 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#ac7b2ea286551ee5b63b91673c81bfec7)KeyPart3
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.StaticBodyProperties.KeyPart3 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a06518ff9736c6db89a3673facb3b21c0)KeyPart4
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.StaticBodyProperties.KeyPart4 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a1a5d487c986f0a8257b6d59c9fb96026)KeyPart5
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.StaticBodyProperties.KeyPart5 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a13a48482a23699cffd5dfe259fbd9f90)KeyPart6
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.StaticBodyProperties.KeyPart6 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a6e8d33e590e023c6da6be61618d50ec7)KeyPart7
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.StaticBodyProperties.KeyPart7 | | get |

[◆](struct_tale_worlds_1_1_core_1_1_static_body_properties.html#a86a14d60bdcda83d0a8f195818927f9d)KeyPart8
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.Core.StaticBodyProperties.KeyPart8 | | get |

