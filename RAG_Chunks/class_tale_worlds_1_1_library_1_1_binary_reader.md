--- SOURCE: class_tale_worlds_1_1_library_1_1_binary_reader.html ---

TaleWorlds.Library.BinaryReader Class ReferenceInherits [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [BinaryReader](class_tale_worlds_1_1_library_1_1_binary_reader.html#ae0709fbcdce9cb04823227f6b8966967) (byte[] data) |
| [ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html) | [ReadSerializableObject](class_tale_worlds_1_1_library_1_1_binary_reader.html#a62f7746b423491ebb9c9b862970ac055) () |
| int | [Read3ByteInt](class_tale_worlds_1_1_library_1_1_binary_reader.html#ae375218ca23752387382717e6ba9b751) () |
| int | [ReadInt](class_tale_worlds_1_1_library_1_1_binary_reader.html#a4da271a76b5d60d9708079e991972217) () |
| short | [ReadShort](class_tale_worlds_1_1_library_1_1_binary_reader.html#a267627a852704f2d80413bb73e1f0a59) () |
| void | [ReadFloats](class_tale_worlds_1_1_library_1_1_binary_reader.html#a8933fc70fa0132151e9dd5862f155ee1) (float[] output, int count) |
| void | [ReadShorts](class_tale_worlds_1_1_library_1_1_binary_reader.html#a72006e5421cd96bbafc30201ffdcd1dd) (short[] output, int count) |
| string | [ReadString](class_tale_worlds_1_1_library_1_1_binary_reader.html#aa43a420868fc8b982081f9c23e631ebd) () |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) | [ReadColor](class_tale_worlds_1_1_library_1_1_binary_reader.html#ab33bdaa6a7cababda6bfb8b71ac6df51) () |
| bool | [ReadBool](class_tale_worlds_1_1_library_1_1_binary_reader.html#a5ecd777f3228d6ecd5c6c21084a3c58d) () |
| float | [ReadFloat](class_tale_worlds_1_1_library_1_1_binary_reader.html#aeda5c9ed19a3c048e66e240cfba6d9bf) () |
| uint | [ReadUInt](class_tale_worlds_1_1_library_1_1_binary_reader.html#aad157e3f708213aed3122d30906c32ad) () |
| ulong | [ReadULong](class_tale_worlds_1_1_library_1_1_binary_reader.html#aa446e0d519a6a73e0a634a4a16e671d4) () |
| long | [ReadLong](class_tale_worlds_1_1_library_1_1_binary_reader.html#aa185b599c36522e388bf6b3bc5ffea8e) () |
| byte | [ReadByte](class_tale_worlds_1_1_library_1_1_binary_reader.html#a63882f6be61d6d6a3d74aab530cabc6f) () |
| byte[] | [ReadBytes](class_tale_worlds_1_1_library_1_1_binary_reader.html#ad033d0a03a9b70ef220d8946924fa5ed) (int length) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [ReadVec2](class_tale_worlds_1_1_library_1_1_binary_reader.html#a8588a84ca1e95cc297e495e4f0e6bb90) () |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) | [ReadVec3](class_tale_worlds_1_1_library_1_1_binary_reader.html#a11527db6d893e099a26f27326f7b7f46) () |
| [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html) | [ReadVec3Int](class_tale_worlds_1_1_library_1_1_binary_reader.html#a55900fd2d19e67691dff03d9d2848ffe) () |
| sbyte | [ReadSByte](class_tale_worlds_1_1_library_1_1_binary_reader.html#a5316dfb8a9770fa08fdc31be123628ca) () |
| ushort | [ReadUShort](class_tale_worlds_1_1_library_1_1_binary_reader.html#a03dccd9b6359da8bd66d7ce8c0b2222b) () |
| double | [ReadDouble](class_tale_worlds_1_1_library_1_1_binary_reader.html#a3baf235e457691853293e10b20116910) () |

|  |  |
| --- | --- |
| Properties | |
| byte[] | [Data](class_tale_worlds_1_1_library_1_1_binary_reader.html#a939b938925febe6a73838d96d71f8cbc) `[get]` |
| int | [UnreadByteCount](class_tale_worlds_1_1_library_1_1_binary_reader.html#a28c6912a6836987b8fc5e52922d49a61) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#ae0709fbcdce9cb04823227f6b8966967)BinaryReader()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Library.BinaryReader.BinaryReader | ( | byte[] | *data* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a62f7746b423491ebb9c9b862970ac055)ReadSerializableObject()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html) TaleWorlds.Library.BinaryReader.ReadSerializableObject | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#a17aec9917241d18f487d9ecf44aca69c).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#ae375218ca23752387382717e6ba9b751)Read3ByteInt()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Library.BinaryReader.Read3ByteInt | ( |  | ) |  |

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a4da271a76b5d60d9708079e991972217)ReadInt()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.Library.BinaryReader.ReadInt | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#a33200d62fb770d52818b7c8a6a583fcc).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a267627a852704f2d80413bb73e1f0a59)ReadShort()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| short TaleWorlds.Library.BinaryReader.ReadShort | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#a768df828578fe24d63e3f1f6fa8a38b7).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a8933fc70fa0132151e9dd5862f155ee1)ReadFloats()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryReader.ReadFloats | ( | float[] | *output*, |
|  |  | int | *count* ) |

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a72006e5421cd96bbafc30201ffdcd1dd)ReadShorts()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.Library.BinaryReader.ReadShorts | ( | short[] | *output*, |
|  |  | int | *count* ) |

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#aa43a420868fc8b982081f9c23e631ebd)ReadString()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.Library.BinaryReader.ReadString | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#a40244b3e296527b8dc36c8f0dfaf22d6).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#ab33bdaa6a7cababda6bfb8b71ac6df51)ReadColor()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Color](struct_tale_worlds_1_1_library_1_1_color.html) TaleWorlds.Library.BinaryReader.ReadColor | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#accfb2c5984c1334fa8fec399e69188c5).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a5ecd777f3228d6ecd5c6c21084a3c58d)ReadBool()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.Library.BinaryReader.ReadBool | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#afa96f07f047eb369c576429559d80164).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#aeda5c9ed19a3c048e66e240cfba6d9bf)ReadFloat()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Library.BinaryReader.ReadFloat | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#ad800cfa9d5cd133b90afc485b5997fa6).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#aad157e3f708213aed3122d30906c32ad)ReadUInt()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.Library.BinaryReader.ReadUInt | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#a252c134e8923b8ea70763a268ab09d30).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#aa446e0d519a6a73e0a634a4a16e671d4)ReadULong()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| ulong TaleWorlds.Library.BinaryReader.ReadULong | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#a69c3e4a47f25ca265aa63161c152a97b).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#aa185b599c36522e388bf6b3bc5ffea8e)ReadLong()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| long TaleWorlds.Library.BinaryReader.ReadLong | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#ab2546059c1ee2ab49f5379650d6d8e7c).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a63882f6be61d6d6a3d74aab530cabc6f)ReadByte()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| byte TaleWorlds.Library.BinaryReader.ReadByte | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#a2f331c089d201bdd8b28e1ee1d551255).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#ad033d0a03a9b70ef220d8946924fa5ed)ReadBytes()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| byte[] TaleWorlds.Library.BinaryReader.ReadBytes | ( | int | *length* | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#a130992d02480749377d3c8b20ea1d563).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a8588a84ca1e95cc297e495e4f0e6bb90)ReadVec2()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.Library.BinaryReader.ReadVec2 | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#a3cecab793259635835e81a5dd32f1373).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a11527db6d893e099a26f27326f7b7f46)ReadVec3()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3](struct_tale_worlds_1_1_library_1_1_vec3.html) TaleWorlds.Library.BinaryReader.ReadVec3 | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#aab0d3041f505d3202ac6125fac22e7d5).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a55900fd2d19e67691dff03d9d2848ffe)ReadVec3Int()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec3i](struct_tale_worlds_1_1_library_1_1_vec3i.html) TaleWorlds.Library.BinaryReader.ReadVec3Int | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#a47c2de675fad0a3d8e10714d2535ab20).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a5316dfb8a9770fa08fdc31be123628ca)ReadSByte()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| sbyte TaleWorlds.Library.BinaryReader.ReadSByte | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#a581e57cdd0c7f34ebe9a5387dfcbd035).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a03dccd9b6359da8bd66d7ce8c0b2222b)ReadUShort()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| ushort TaleWorlds.Library.BinaryReader.ReadUShort | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#acf84285fa38519f3ffa2d937d290c58e).

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a3baf235e457691853293e10b20116910)ReadDouble()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| double TaleWorlds.Library.BinaryReader.ReadDouble | ( |  | ) |  |

Implements [TaleWorlds.Library.IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html#acdac16d76397657509041c4edad24b44).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a939b938925febe6a73838d96d71f8cbc)Data
-----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | byte [] TaleWorlds.Library.BinaryReader.Data | | get |

[◆](class_tale_worlds_1_1_library_1_1_binary_reader.html#a28c6912a6836987b8fc5e52922d49a61)UnreadByteCount
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Library.BinaryReader.UnreadByteCount | | get |

