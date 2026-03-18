--- SOURCE: interface_tale_worlds_1_1_library_1_1_i_writer.html ---

TaleWorlds.Library.IWriter Interface ReferenceInherited by [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [WriteSerializableObject](interface_tale_worlds_1_1_library_1_1_i_writer.html#acaacda1f05ba80b9c06b3022a78360e5) ([ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html) serializableObject) |
| void | [WriteByte](interface_tale_worlds_1_1_library_1_1_i_writer.html#ad2c3edaa74f9e40fe89b5921a6365996) (byte value) |
| void | [WriteSByte](interface_tale_worlds_1_1_library_1_1_i_writer.html#a024470936bcd4c1faaa445d85a00ae51) (sbyte value) |
| void | [WriteBytes](interface_tale_worlds_1_1_library_1_1_i_writer.html#afe6f01fc9053677b853a53305dd39ab5) (byte[] bytes) |
| void | [WriteInt](interface_tale_worlds_1_1_library_1_1_i_writer.html#a62b95120d59a27e106411bc970d27b12) (int value) |
| void | [WriteUInt](interface_tale_worlds_1_1_library_1_1_i_writer.html#abeba58d861db5deaaeb77475616f1e2f) (uint value) |
| void | [WriteShort](interface_tale_worlds_1_1_library_1_1_i_writer.html#a7b8a63f775e6b48e327d9c66e712d976) (short value) |
| void | [WriteUShort](interface_tale_worlds_1_1_library_1_1_i_writer.html#a3ba2c661bf5887c49711ed0eadb9de8f) (ushort value) |
| void | [WriteString](interface_tale_worlds_1_1_library_1_1_i_writer.html#a14b9c9950ddfa03ad26b8d441d995ae5) (string value) |
| void | [WriteColor](interface_tale_worlds_1_1_library_1_1_i_writer.html#a43937019bb8a90d5e2840dcd43dfd5ed) ([Color](struct_tale_worlds_1_1_library_1_1_color.html) value) |
| void | [WriteBool](interface_tale_worlds_1_1_library_1_1_i_writer.html#a9a600ff90a385eba0c44161180492dd3) (bool value) |
| void | [WriteFloat](interface_tale_worlds_1_1_library_1_1_i_writer.html#a17d3096239dc018f6811758ce9cbdab8) (float value) |
| void | [WriteDouble](interface_tale_worlds_1_1_library_1_1_i_writer.html#af526326e3a1eb49efae33077b55e2883) (double value) |
| void | [WriteULong](interface_tale_worlds_1_1_library_1_1_i_writer.html#a856d23d0bc7ad166672c85072a2fc077) (ulong value) |
| void | [WriteLong](interface_tale_worlds_1_1_library_1_1_i_writer.html#a5d05741a65a0ad19cd118d20f503b450) (long value) |
| void | [WriteVec2](interface_tale_worlds_1_1_library_1_1_i_writer.html#a7c6764b6f79d2862957b7e1ac9f837fc) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) vec2) |
| void | [WriteVec3](interface_tale_worlds_1_1_library_1_1_i_writer.html#a06e3abb50595735b1e11d0c662613075) ([Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) vec3) |
| void | [WriteVec3Int](interface_tale_worlds_1_1_library_1_1_i_writer.html#a5e7094d5da8c3aa15fd129f52234af2e) ([Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html) vec3) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#acaacda1f05ba80b9c06b3022a78360e5)WriteSerializableObject()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteSerializableObject | ( | [ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html) | *serializableObject* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#ad8c120328f1b4485529d91e7e00a6f3e), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#a09f4a5a204b313a97e4260afdbe91cce).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#ad2c3edaa74f9e40fe89b5921a6365996)WriteByte()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteByte | ( | byte | *value* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#a06a48268aae41f28bc78e3f869e84d16), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#a4a4269ea5c7ba594b78b61581c6153ea).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#a024470936bcd4c1faaa445d85a00ae51)WriteSByte()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteSByte | ( | sbyte | *value* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#abc56c195784d49b386a7dc8236c1d962), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#a2f162d375a2b7673c3b317849efd3c8d).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#afe6f01fc9053677b853a53305dd39ab5)WriteBytes()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteBytes | ( | byte[] | *bytes* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#a2609332942a268879cd7f75c9873c8a7), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#ac4597c3a1919aaa1a8c3cc137322a2d9).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#a62b95120d59a27e106411bc970d27b12)WriteInt()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteInt | ( | int | *value* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#a73b25670f55f88b76c20fbefea6acde9), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#ac6fdb9aaaeb0e35fa18acf06f351bc8d).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#abeba58d861db5deaaeb77475616f1e2f)WriteUInt()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteUInt | ( | uint | *value* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#a895aff086ce9b5ef00b226ed1bba7648), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#ae8ee0084776c6dbf8b8ca8acb2046ede).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#a7b8a63f775e6b48e327d9c66e712d976)WriteShort()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteShort | ( | short | *value* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#af05e976cba710221b6fb26fa2465e501), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#a0205eb38d09fe095784728c9046af7e4).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#a3ba2c661bf5887c49711ed0eadb9de8f)WriteUShort()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteUShort | ( | ushort | *value* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#a7f074acde90d6f5ef754281aa4590573), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#ac282fec2115e41b4aed4646b6af2abaf).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#a14b9c9950ddfa03ad26b8d441d995ae5)WriteString()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteString | ( | string | *value* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#a595bed2d587f47113f580b226b88ca75), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#aae6ec2db8f5f4f972eb91c0b96cfa720).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#a43937019bb8a90d5e2840dcd43dfd5ed)WriteColor()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteColor | ( | [Color](struct_tale_worlds_1_1_library_1_1_color.html) | *value* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#a0f90ad50fd554a1a246a8700f3fc7841), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#a3a9f54829e200522454466cfdbe79715).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#a9a600ff90a385eba0c44161180492dd3)WriteBool()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteBool | ( | bool | *value* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#a95c1c991934f85cd04af1560f7e419b7), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#a7ff895f7bd7c9842a3973bc8bc2390b2).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#a17d3096239dc018f6811758ce9cbdab8)WriteFloat()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteFloat | ( | float | *value* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#a11574d2bd78bcab3debb94cc246b7f08), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#a6d8427f49652eb7d9891a6bc750946c0).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#af526326e3a1eb49efae33077b55e2883)WriteDouble()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteDouble | ( | double | *value* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#adde5257724cf273ded2f9d013396e046), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#a1716c90f6f052a5d8f7b80f56ecf6c05).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#a856d23d0bc7ad166672c85072a2fc077)WriteULong()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteULong | ( | ulong | *value* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#aa5a209d290aca8198fd1888fc8734b00), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#a87937b1f477ca6786ff9b5791d369692).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#a5d05741a65a0ad19cd118d20f503b450)WriteLong()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteLong | ( | long | *value* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#adca5daaf54f8efeff2485bfd41b7aaa7), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#acc2b0c5cf38001ac7980073cc99aee35).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#a7c6764b6f79d2862957b7e1ac9f837fc)WriteVec2()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteVec2 | ( | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | *vec2* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#a51dfb126e5d664d3089f38074294457f), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#a5bedcf61946202a675b7f5a669133622).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#a06e3abb50595735b1e11d0c662613075)WriteVec3()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteVec3 | ( | [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | *vec3* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#add813734c25b0d9d834c09a82e25c5d8), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#abed0b49eada87999399f4869ac540f79).

[◆](interface_tale_worlds_1_1_library_1_1_i_writer.html#a5e7094d5da8c3aa15fd129f52234af2e)WriteVec3Int()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Library.IWriter.WriteVec3Int | ( | [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html) | *vec3* | ) |  |

Implemented in [TaleWorlds.Library.BinaryWriter](class_tale_worlds_1_1_library_1_1_binary_writer.html#a734e07121814fe3c5fe3b2f4c6a1a746), and [TaleWorlds.Library.StringWriter](class_tale_worlds_1_1_library_1_1_string_writer.html#a75a5dabe4e68f7703fdc64777ddcd3da).

