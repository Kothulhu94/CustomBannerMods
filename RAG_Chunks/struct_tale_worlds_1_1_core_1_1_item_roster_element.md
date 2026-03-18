--- SOURCE: struct_tale_worlds_1_1_core_1_1_item_roster_element.html ---

TaleWorlds.Core.ItemRosterElement Struct ReferenceInherits [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html), and ISavedStruct.

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a8b654c1ef2a411551548db99173d0388) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) item, int amount=0, [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) itemModifier=null) |
|  | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#abd9ed5156448a90a17acfdcd517f0326) ([EquipmentElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a294e7a5cf98eaa6197b062ec50f811ad) equipmentElement, int amount) |
| override int | [GetHashCode](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a36e6eaadf1447efcab29af9fc4269727) () |
| override string | [ToString](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a4aad14797052926e0bcd67ebe1998348) () |
|  | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#ae0010a1ee4d53cf4f235fe0442c3861c) (ItemRosterElement itemRosterElement) |
| void | [Clear](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a60a774d0e8dfca05cba7e0581329376a) () |
| bool | [IsEqualTo](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a365661ea99b8dce72ba18033fca377f2) ([ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a8b654c1ef2a411551548db99173d0388) other) |
| override bool | [Equals](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#ab8035dc96ac90f765518676a0ea365af) (object obj) |
| float | [GetRosterElementWeight](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a39d2c8431b79150619552d4e05a0b936) () |
| void ISerializableObject. | [DeserializeFrom](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a8843f62f01ab5f6d9d54d297c74df698) ([IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) reader) |
| void ISerializableObject. | [SerializeTo](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a1c1b397e143c857ac5727c8f393db9ee) ([IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) writer) |
| bool ISavedStruct. | [IsDefault](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a529f71cae9924b32885f5198165f262b) () |

|  |  |
| --- | --- |
| Properties | |
| static [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a8b654c1ef2a411551548db99173d0388) | [Invalid](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#ac6a4c62e38a74cd5738fb2b30cef073e) `[get]` |
| EquipmentElement | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a294e7a5cf98eaa6197b062ec50f811ad) `[get]` |
| int | [Amount](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#ad21186f65961ea83c06360d698da1217) `[get, set]` |
| bool | [IsEmpty](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#ab5767d4292e00913fce07e58092767b5) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a8b654c1ef2a411551548db99173d0388)ItemRosterElement() [1/3]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.ItemRosterElement.ItemRosterElement | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *item*, |
|  |  | int | *amount* = 0, |
|  |  | [ItemModifier](class_tale_worlds_1_1_core_1_1_item_modifier.html) | *itemModifier* = null ) |

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#abd9ed5156448a90a17acfdcd517f0326)ItemRosterElement() [2/3]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.ItemRosterElement.ItemRosterElement | ( | [EquipmentElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a294e7a5cf98eaa6197b062ec50f811ad) | *equipmentElement*, |
|  |  | int | *amount* ) |

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#ae0010a1ee4d53cf4f235fe0442c3861c)ItemRosterElement() [3/3]
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.Core.ItemRosterElement.ItemRosterElement | ( | ItemRosterElement | *itemRosterElement* | ) |  |

Member Function Documentation
-----------------------------

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a36e6eaadf1447efcab29af9fc4269727)GetHashCode()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.Core.ItemRosterElement.GetHashCode | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a4aad14797052926e0bcd67ebe1998348)ToString()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.Core.ItemRosterElement.ToString | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a60a774d0e8dfca05cba7e0581329376a)Clear()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ItemRosterElement.Clear | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a365661ea99b8dce72ba18033fca377f2)IsEqualTo()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.Core.ItemRosterElement.IsEqualTo | ( | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a8b654c1ef2a411551548db99173d0388) | *other* | ) |  |

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#ab8035dc96ac90f765518676a0ea365af)Equals()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.Core.ItemRosterElement.Equals | ( | object | *obj* | ) |  |

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a39d2c8431b79150619552d4e05a0b936)GetRosterElementWeight()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.Core.ItemRosterElement.GetRosterElementWeight | ( |  | ) |  |

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a8843f62f01ab5f6d9d54d297c74df698)DeserializeFrom()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void ISerializableObject. TaleWorlds.Core.ItemRosterElement.DeserializeFrom | ( | [IReader](interface_tale_worlds_1_1_library_1_1_i_reader.html) | *reader* | ) |  |

Implements [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aaaf5181fea51c7c2d4e365efe82bc703).

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a1c1b397e143c857ac5727c8f393db9ee)SerializeTo()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void ISerializableObject. TaleWorlds.Core.ItemRosterElement.SerializeTo | ( | [IWriter](interface_tale_worlds_1_1_library_1_1_i_writer.html) | *writer* | ) |  |

Implements [TaleWorlds.Library.ISerializableObject](interface_tale_worlds_1_1_library_1_1_i_serializable_object.html#aac913af86c2a4128993048fc2023b4de).

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a529f71cae9924b32885f5198165f262b)IsDefault()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool ISavedStruct. TaleWorlds.Core.ItemRosterElement.IsDefault | ( |  | ) |  |

Property Documentation
----------------------

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#ac6a4c62e38a74cd5738fb2b30cef073e)Invalid
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemRosterElement](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a8b654c1ef2a411551548db99173d0388) TaleWorlds.Core.ItemRosterElement.Invalid | | staticget |

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#a294e7a5cf98eaa6197b062ec50f811ad)EquipmentElement
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | EquipmentElement TaleWorlds.Core.ItemRosterElement.EquipmentElement | | get |

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#ad21186f65961ea83c06360d698da1217)Amount
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.Core.ItemRosterElement.Amount | | getset |

[◆](struct_tale_worlds_1_1_core_1_1_item_roster_element.html#ab5767d4292e00913fce07e58092767b5)IsEmpty
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ItemRosterElement.IsEmpty | | get |

