--- SOURCE: class_tale_worlds_1_1_input_system_1_1_hot_key.html ---

TaleWorlds.InputSystem.HotKey Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [Modifiers](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6) {     [None](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6a6adf97f83acf6453d4a6a4b1070f3754) = 0x00000000 ,     [Shift](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6a825a3d98017bab11815ad2817201324c) = 0x00000001 ,     [Alt](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6aa2e92861b757ab878312dd57993d60cf) = 0x00000002 ,     [Control](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6aa1595abbb4c3a326636dd178757cd6c1) = 0x00000004   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a6afc243d469da16c0bb7778bfb38d010) (string id, string groupId, List< [Key](class_tale_worlds_1_1_input_system_1_1_key.html) > keys, [Modifiers](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6) modifiers=[Modifiers.None](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6a6adf97f83acf6453d4a6a4b1070f3754), [Modifiers](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6) negativeModifiers=[Modifiers.None](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6a6adf97f83acf6453d4a6a4b1070f3754)) |
|  | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a8e9983b266c6100cedba62802d6ee4ff) (string id, string groupId, [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) inputKey, [Modifiers](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6) modifiers=[Modifiers.None](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6a6adf97f83acf6453d4a6a4b1070f3754), [Modifiers](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6) negativeModifiers=[Modifiers.None](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6a6adf97f83acf6453d4a6a4b1070f3754)) |
| bool | [HasModifier](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a5be74ee2eb88b7aa2cacb34f7fda8419) ([Modifiers](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6) modifier) |
| bool | [HasSameModifiers](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a2abd00b5689e52f2ffed3f26ed443dfa) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a6afc243d469da16c0bb7778bfb38d010) other) |
| override string | [ToString](class_tale_worlds_1_1_input_system_1_1_hot_key.html#ad3b771280df61430b7440fe12737fa06) () |
| override bool | [Equals](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a0a0c1ab2b26043b651161755b1b53d05) (object obj) |
| override int | [GetHashCode](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a366b070a63d46f499929b7339fb61ab0) () |

|  |  |
| --- | --- |
| Public Attributes | |
| string | [Id](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acbde4dcefb3296049a09b68e360814df) |
| string | [GroupId](class_tale_worlds_1_1_input_system_1_1_hot_key.html#ae1f39ff1bfd3954f79efb67299230e8b) |

|  |  |
| --- | --- |
| Properties | |
| List< [Key](class_tale_worlds_1_1_input_system_1_1_key.html) > | [Keys](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a9c47ae02f392b318c3ed2d29c96303e7) `[get]` |
| List< [Key](class_tale_worlds_1_1_input_system_1_1_key.html) > | [DefaultKeys](class_tale_worlds_1_1_input_system_1_1_hot_key.html#ae2c5e5aa14664f84be6db9cdac6ba719) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6)Modifiers
---------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.InputSystem.HotKey.Modifiers](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6) |

| Enumerator | |
| --- | --- |
| None |  |
| Shift |  |
| Alt |  |
| Control |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a6afc243d469da16c0bb7778bfb38d010)HotKey() [1/2]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.InputSystem.HotKey.HotKey | ( | string | *id*, |
|  |  | string | *groupId*, |
|  |  | List< [Key](class_tale_worlds_1_1_input_system_1_1_key.html) > | *keys*, |
|  |  | [Modifiers](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6) | *modifiers* = [Modifiers::None](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6a6adf97f83acf6453d4a6a4b1070f3754), |
|  |  | [Modifiers](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6) | *negativeModifiers* = [Modifiers::None](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6a6adf97f83acf6453d4a6a4b1070f3754) ) |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a8e9983b266c6100cedba62802d6ee4ff)HotKey() [2/2]
--------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.InputSystem.HotKey.HotKey | ( | string | *id*, |
|  |  | string | *groupId*, |
|  |  | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *inputKey*, |
|  |  | [Modifiers](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6) | *modifiers* = [Modifiers::None](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6a6adf97f83acf6453d4a6a4b1070f3754), |
|  |  | [Modifiers](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6) | *negativeModifiers* = [Modifiers::None](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6a6adf97f83acf6453d4a6a4b1070f3754) ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a5be74ee2eb88b7aa2cacb34f7fda8419)HasModifier()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.HotKey.HasModifier | ( | [Modifiers](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acca74cc62cc3df5567dee611ad7e56d6) | *modifier* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a2abd00b5689e52f2ffed3f26ed443dfa)HasSameModifiers()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.HotKey.HasSameModifiers | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a6afc243d469da16c0bb7778bfb38d010) | *other* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key.html#ad3b771280df61430b7440fe12737fa06)ToString()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.InputSystem.HotKey.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a0a0c1ab2b26043b651161755b1b53d05)Equals()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.InputSystem.HotKey.Equals | ( | object | *obj* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a366b070a63d46f499929b7339fb61ab0)GetHashCode()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.InputSystem.HotKey.GetHashCode | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key.html#acbde4dcefb3296049a09b68e360814df)Id
--------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.InputSystem.HotKey.Id |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key.html#ae1f39ff1bfd3954f79efb67299230e8b)GroupId
-------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.InputSystem.HotKey.GroupId |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key.html#a9c47ae02f392b318c3ed2d29c96303e7)Keys
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Key](class_tale_worlds_1_1_input_system_1_1_key.html)> TaleWorlds.InputSystem.HotKey.Keys | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_hot_key.html#ae2c5e5aa14664f84be6db9cdac6ba719)DefaultKeys
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Key](class_tale_worlds_1_1_input_system_1_1_key.html)> TaleWorlds.InputSystem.HotKey.DefaultKeys | | get |

