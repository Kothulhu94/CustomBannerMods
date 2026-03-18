--- SOURCE: class_tale_worlds_1_1_library_1_1_binary_writer.html ---

TaleWorlds.Library.BinaryWriter Class ReferenceInherits [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#aaa81af2ff50411f851c296e7000a6651) () |
|  | [BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#a45e5c389bbca9b13bc8dc507be965562) (int capacity) |
| void | [Clear](class_tale_worlds_1_1_library_1_1_binary_writer.html#a4e633a44dd2f46ec3de6faaadaeecf0a) () |
| void | [EnsureLength](class_tale_worlds_1_1_library_1_1_binary_writer.html#a04c3b617091755a069f67e5dac295ed4) (int added) |
| void | [WriteSerializableObject](class_tale_worlds_1_1_library_1_1_binary_writer.html#ad8c120328f1b4485529d91e7e00a6f3e) ([ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html) serializableObject) |
| void | [WriteByte](class_tale_worlds_1_1_library_1_1_binary_writer.html#a06a48268aae41f28bc78e3f869e84d16) (byte value) |
| void | [WriteBytes](class_tale_worlds_1_1_library_1_1_binary_writer.html#a2609332942a268879cd7f75c9873c8a7) (byte[] bytes) |
| void | [Write3ByteInt](class_tale_worlds_1_1_library_1_1_binary_writer.html#aee03e7adde9b9ee4a053ffa6ac568aee) (int value) |
| void | [WriteInt](class_tale_worlds_1_1_library_1_1_binary_writer.html#a73b25670f55f88b76c20fbefea6acde9) (int value) |
| void | [WriteShort](class_tale_worlds_1_1_library_1_1_binary_writer.html#af05e976cba710221b6fb26fa2465e501) (short value) |
| void | [WriteString](class_tale_worlds_1_1_library_1_1_binary_writer.html#a595bed2d587f47113f580b226b88ca75) (string value) |
| void | [WriteFloats](class_tale_worlds_1_1_library_1_1_binary_writer.html#a67bff74a7a12b0e690221abcb3e7d278) (float[] value, int count) |
| void | [WriteShorts](class_tale_worlds_1_1_library_1_1_binary_writer.html#a667164aba0409d294bf2dede81ec979b) (short[] value, int count) |
| void | [WriteColor](class_tale_worlds_1_1_library_1_1_binary_writer.html#a0f90ad50fd554a1a246a8700f3fc7841) ([Color](struct_tale_worlds_1_1_library_1_1_color.html) value) |
| void | [WriteBool](class_tale_worlds_1_1_library_1_1_binary_writer.html#a95c1c991934f85cd04af1560f7e419b7) (bool value) |
| void | [WriteFloat](class_tale_worlds_1_1_library_1_1_binary_writer.html#a11574d2bd78bcab3debb94cc246b7f08) (float value) |
| void | [WriteUInt](class_tale_worlds_1_1_library_1_1_binary_writer.html#a895aff086ce9b5ef00b226ed1bba7648) (uint value) |
| void | [WriteULong](class_tale_worlds_1_1_library_1_1_binary_writer.html#aa5a209d290aca8198fd1888fc8734b00) (ulong value) |
| void | [WriteLong](class_tale_worlds_1_1_library_1_1_binary_writer.html#adca5daaf54f8efeff2485bfd41b7aaa7) (long value) |
| void | [WriteVec2](class_tale_worlds_1_1_library_1_1_binary_writer.html#a51dfb126e5d664d3089f38074294457f) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) vec2) |
| void | [WriteVec3](class_tale_worlds_1_1_library_1_1_binary_writer.html#add813734c25b0d9d834c09a82e25c5d8) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) vec3) |
| void | [WriteVec3Int](class_tale_worlds_1_1_library_1_1_binary_writer.html#a734e07121814fe3c5fe3b2f4c6a1a746) ([Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html) vec3) |
| void | [WriteSByte](class_tale_worlds_1_1_library_1_1_binary_writer.html#abc56c195784d49b386a7dc8236c1d962) (sbyte value) |
| void | [WriteUShort](class_tale_worlds_1_1_library_1_1_binary_writer.html#a7f074acde90d6f5ef754281aa4590573) (ushort value) |
| void | [WriteDouble](class_tale_worlds_1_1_library_1_1_binary_writer.html#adde5257724cf273ded2f9d013396e046) (double value) |
| void | [AppendData](class_tale_worlds_1_1_library_1_1_binary_writer.html#ac1f9f55bc0cb86a47ad27121f0bd5f9a) ([BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#aaa81af2ff50411f851c296e7000a6651) writer) |
| byte[] | [GetFinalData](class_tale_worlds_1_1_library_1_1_binary_writer.html#ab8c61fe75dc8e5cefe7f63614778d337) () |

|  |  |
| --- | --- |
| Properties | |
| byte[] | [Data](class_tale_worlds_1_1_library_1_1_binary_writer.html#aa44e5b7d1c8cf9f2eebd6845e0f95190) `[get]` |
| int | [Length](class_tale_worlds_1_1_library_1_1_binary_writer.html#a0819d487cfd5ffb993c39b80b555ff9c) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#aaa81af2ff50411f851c296e7000a6651)BinaryWriter() [1/2]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.Library.BinaryWriter.BinaryWriter | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a45e5c389bbca9b13bc8dc507be965562)BinaryWriter() [2/2]
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.BinaryWriter.BinaryWriter | ( | int | *capacity* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a4e633a44dd2f46ec3de6faaadaeecf0a)Clear()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.Clear | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a04c3b617091755a069f67e5dac295ed4)EnsureLength()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.EnsureLength | ( | int | *added* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#ad8c120328f1b4485529d91e7e00a6f3e)WriteSerializableObject()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteSerializableObject | ( | [ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html) | *serializableObject* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#acaacda1f05ba80b9c06b3022a78360e5).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a06a48268aae41f28bc78e3f869e84d16)WriteByte()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteByte | ( | byte | *value* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#ad2c3edaa74f9e40fe89b5921a6365996).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a2609332942a268879cd7f75c9873c8a7)WriteBytes()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteBytes | ( | byte[] | *bytes* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#afe6f01fc9053677b853a53305dd39ab5).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#aee03e7adde9b9ee4a053ffa6ac568aee)Write3ByteInt()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.Write3ByteInt | ( | int | *value* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a73b25670f55f88b76c20fbefea6acde9)WriteInt()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteInt | ( | int | *value* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#a62b95120d59a27e106411bc970d27b12).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#af05e976cba710221b6fb26fa2465e501)WriteShort()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteShort | ( | short | *value* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#a7b8a63f775e6b48e327d9c66e712d976).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a595bed2d587f47113f580b226b88ca75)WriteString()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteString | ( | string | *value* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#a14b9c9950ddfa03ad26b8d441d995ae5).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a67bff74a7a12b0e690221abcb3e7d278)WriteFloats()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteFloats | ( | float[] | *value*, |
|  |  | int | *count* ) |

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a667164aba0409d294bf2dede81ec979b)WriteShorts()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteShorts | ( | short[] | *value*, |
|  |  | int | *count* ) |

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a0f90ad50fd554a1a246a8700f3fc7841)WriteColor()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteColor | ( | [Color](struct_tale_worlds_1_1_library_1_1_color.html) | *value* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#a43937019bb8a90d5e2840dcd43dfd5ed).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a95c1c991934f85cd04af1560f7e419b7)WriteBool()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteBool | ( | bool | *value* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#a9a600ff90a385eba0c44161180492dd3).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a11574d2bd78bcab3debb94cc246b7f08)WriteFloat()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteFloat | ( | float | *value* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#a17d3096239dc018f6811758ce9cbdab8).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a895aff086ce9b5ef00b226ed1bba7648)WriteUInt()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteUInt | ( | uint | *value* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#abeba58d861db5deaaeb77475616f1e2f).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#aa5a209d290aca8198fd1888fc8734b00)WriteULong()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteULong | ( | ulong | *value* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#a856d23d0bc7ad166672c85072a2fc077).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#adca5daaf54f8efeff2485bfd41b7aaa7)WriteLong()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteLong | ( | long | *value* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#a5d05741a65a0ad19cd118d20f503b450).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a51dfb126e5d664d3089f38074294457f)WriteVec2()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteVec2 | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *vec2* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#a7c6764b6f79d2862957b7e1ac9f837fc).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#add813734c25b0d9d834c09a82e25c5d8)WriteVec3()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteVec3 | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *vec3* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#a06e3abb50595735b1e11d0c662613075).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a734e07121814fe3c5fe3b2f4c6a1a746)WriteVec3Int()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteVec3Int | ( | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html) | *vec3* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#a5e7094d5da8c3aa15fd129f52234af2e).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#abc56c195784d49b386a7dc8236c1d962)WriteSByte()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteSByte | ( | sbyte | *value* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#a024470936bcd4c1faaa445d85a00ae51).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a7f074acde90d6f5ef754281aa4590573)WriteUShort()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteUShort | ( | ushort | *value* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#a3ba2c661bf5887c49711ed0eadb9de8f).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#adde5257724cf273ded2f9d013396e046)WriteDouble()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.WriteDouble | ( | double | *value* | ) |  |

Implements [TaleWorlds.Library.IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html#af526326e3a1eb49efae33077b55e2883).

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#ac1f9f55bc0cb86a47ad27121f0bd5f9a)AppendData()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryWriter.AppendData | ( | [BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#aaa81af2ff50411f851c296e7000a6651) | *writer* | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#ab8c61fe75dc8e5cefe7f63614778d337)GetFinalData()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| byte[] TaleWorlds.Library.BinaryWriter.GetFinalData | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#aa44e5b7d1c8cf9f2eebd6845e0f95190)Data
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | byte [] TaleWorlds.Library.BinaryWriter.Data | | get |

[◆](class_tale_worlds_1_1_library_1_1_binary_writer.html#a0819d487cfd5ffb993c39b80b555ff9c)Length
-------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Library.BinaryWriter.Length | | get |

