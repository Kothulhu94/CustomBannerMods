--- SOURCE: struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html ---

TaleWorlds.ObjectSystem.MBGUID Struct ReferenceRepresents the ID and type of an object, packed in 32 bits.

Inherits IComparable, and IEquatable.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) (uint id) |
|  | Initializes a new instance of the MMOGUID struct. Should contain 4 bits of type information, then 28 bits of sub ID. |
|  | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a12f23fe5fba68f7e71182f44772b34fd) (uint objType, uint subId) |
|  | Initializes a new instance of the MMOGUID struct. |
| int | [CompareTo](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a340304e11c3f8208ca4e2195ebf971da) (object a) |
|  | Compares an object with this MMOGUID. |
| uint | [GetTypeIndex](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a72a8e82c00f396db13943b7ae7903626) () |
| override int | [GetHashCode](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a4fd5a73d8a2343a2fd2d4399f06cfa73) () |
|  | Hash code override. |
| override string | [ToString](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a9417e3c78e42311745cef0ac3986f393) () |
| override bool | [Equals](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a89641a0b4b9c2c4ba768797523001646) (object obj) |
|  | Compares an object with this MMOGUID. |
| bool | [Equals](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a27dd46b3ea61d678fdfde112d6c3a456) ([MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) other) |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [operator==](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a1fc17ef966c591e6e835cc37bc5a2a66) ([MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id1, [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id2) |
|  | Compares two MMOGUIDS. |
| static bool | [operator!=](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a090fc1e28b3876552ff35af89dda25b7) ([MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id1, [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id2) |
|  | Compares two MMOGUIDS. |
| static bool | [operator<](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a8f0d3bc1ab788122a8ad272e17fffb94) ([MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id1, [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id2) |
| static bool | [operator>](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#ab1717175762205ccb7ffbcc838ce9cf2) ([MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id1, [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id2) |
| static bool | [operator<=](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a5132eabd46c6f4198055f8a5fc97a0ad) ([MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id1, [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id2) |
| static bool | [operator>=](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a237a32e8448c701de5f0393238f7b302) ([MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id1, [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id2) |
| static long | [GetHash2](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#aeb4952aa94402df20bad490b78b6a490) ([MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id1, [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) id2) |

|  |  |
| --- | --- |
| Properties | |
| uint | [InternalValue](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#abf9afb711a00ed683cdee967658aaaf5) `[get]` |
|  | Gets the internal int value. |
| uint | [SubId](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a74f4512afbd83a0aa7f116041575b7c5) `[get]` |
|  | Gets the ID of the object. |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5)MBGUID() [1/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.ObjectSystem.MBGUID.MBGUID | ( | uint | *id* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | id | internal ID of the object |

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a12f23fe5fba68f7e71182f44772b34fd)MBGUID() [2/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.ObjectSystem.MBGUID.MBGUID | ( | uint | *objType*, |
|  |  | uint | *subId* ) |

Parameters
:   |  |  |
    | --- | --- |
    | objType | Type of the object |
    | subId | ID of the object |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a1fc17ef966c591e6e835cc37bc5a2a66)operator==()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.ObjectSystem.MBGUID.operator== | ( | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id1*, | |  |  | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | id1 | An MMOGUID object 1 |
    | id2 | An MMOGUID object 2 |

Returns
:   True if type and ID is equal, false otherwise

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a090fc1e28b3876552ff35af89dda25b7)operator!=()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.ObjectSystem.MBGUID.operator!= | ( | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id1*, | |  |  | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id2* ) | | static |

Parameters
:   |  |  |
    | --- | --- |
    | id1 | An MMOGUID object 1 |
    | id2 | An MMOGUID object 2 |

Returns
:   False if type and ID is equal, true otherwise

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a8f0d3bc1ab788122a8ad272e17fffb94)operator<()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.ObjectSystem.MBGUID.operator< | ( | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id1*, | |  |  | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id2* ) | | static |

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#ab1717175762205ccb7ffbcc838ce9cf2)operator>()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.ObjectSystem.MBGUID.operator> | ( | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id1*, | |  |  | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id2* ) | | static |

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a5132eabd46c6f4198055f8a5fc97a0ad)operator<=()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.ObjectSystem.MBGUID.operator<= | ( | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id1*, | |  |  | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id2* ) | | static |

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a237a32e8448c701de5f0393238f7b302)operator>=()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.ObjectSystem.MBGUID.operator>= | ( | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id1*, | |  |  | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id2* ) | | static |

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#aeb4952aa94402df20bad490b78b6a490)GetHash2()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | long TaleWorlds.ObjectSystem.MBGUID.GetHash2 | ( | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id1*, | |  |  | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *id2* ) | | static |

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a340304e11c3f8208ca4e2195ebf971da)CompareTo()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.ObjectSystem.MBGUID.CompareTo | ( | object | *a* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | a | MMOGUID object to be compared |

Returns
:   0 if equal, 1 if greater, -1 if less. Throws if object is not MMOGUID

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a72a8e82c00f396db13943b7ae7903626)GetTypeIndex()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| uint TaleWorlds.ObjectSystem.MBGUID.GetTypeIndex | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a4fd5a73d8a2343a2fd2d4399f06cfa73)GetHashCode()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.ObjectSystem.MBGUID.GetHashCode | ( |  | ) |  |

Returns
:   Hash code of the object

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a9417e3c78e42311745cef0ac3986f393)ToString()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.ObjectSystem.MBGUID.ToString | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a89641a0b4b9c2c4ba768797523001646)Equals() [1/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.ObjectSystem.MBGUID.Equals | ( | object | *obj* | ) |  |

Parameters
:   |  |  |
    | --- | --- |
    | obj | MMOGUID object to be compared |

Returns
:   True if equal, false otherwise. Throws if object is not MMOGUID

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a27dd46b3ea61d678fdfde112d6c3a456)Equals() [2/2]
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.ObjectSystem.MBGUID.Equals | ( | [MBGUID](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a232795699c36e8b1ec401773b464f1d5) | *other* | ) |  |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#abf9afb711a00ed683cdee967658aaaf5)InternalValue
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.ObjectSystem.MBGUID.InternalValue | | get |

[◆](struct_tale_worlds_1_1_object_system_1_1_m_b_g_u_i_d.html#a74f4512afbd83a0aa7f116041575b7c5)SubId
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | uint TaleWorlds.ObjectSystem.MBGUID.SubId | | get |

