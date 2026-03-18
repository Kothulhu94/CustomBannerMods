--- SOURCE: class_tale_worlds_1_1_input_system_1_1_key.html ---

TaleWorlds.InputSystem.Key Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [InputType](class_tale_worlds_1_1_input_system_1_1_key.html#ae41a4f03a31442b7c03852bd643bdf79) {     [Invalid](class_tale_worlds_1_1_input_system_1_1_key.html#ae41a4f03a31442b7c03852bd643bdf79a4bbb8f967da6d1a610596d7257179c2b) = -1 ,     [Keyboard](class_tale_worlds_1_1_input_system_1_1_key.html#ae41a4f03a31442b7c03852bd643bdf79a6ce4d85a628a88bbdb3ac24a8e5a9c2e) = 0 ,     [MouseButton](class_tale_worlds_1_1_input_system_1_1_key.html#ae41a4f03a31442b7c03852bd643bdf79a49dabe49d62a3521f7c10400138c38d5) = 1 ,     [MouseWheel](class_tale_worlds_1_1_input_system_1_1_key.html#ae41a4f03a31442b7c03852bd643bdf79a6924f81750ac471df87fed683bcea516) = 2 ,     [Controller](class_tale_worlds_1_1_input_system_1_1_key.html#ae41a4f03a31442b7c03852bd643bdf79a9bbf373797bf7cf7ba62c80023682e25) = 3   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [Key](class_tale_worlds_1_1_input_system_1_1_key.html#a47dc215097a5a5e13eaa369877cc458b) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
|  | [Key](class_tale_worlds_1_1_input_system_1_1_key.html#a909de8678ccfe884ee1952d1850cac00) () |
| void | [ChangeKey](class_tale_worlds_1_1_input_system_1_1_key.html#a5c547bf5a799a41a23751705e0f9a6b5) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| override string | [ToString](class_tale_worlds_1_1_input_system_1_1_key.html#af1d718dcbd1714b87b0431b43ca05705) () |
| override bool | [Equals](class_tale_worlds_1_1_input_system_1_1_key.html#af6345ec2b3a819fd495a23e6a5c1d8fb) (object obj) |
| override int | [GetHashCode](class_tale_worlds_1_1_input_system_1_1_key.html#a4649a785647f07553d521b2f21c72cd5) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [operator==](class_tale_worlds_1_1_input_system_1_1_key.html#a99be3d18d90c4f45e1f3cb793cd66fa0) ([Key](class_tale_worlds_1_1_input_system_1_1_key.html#a47dc215097a5a5e13eaa369877cc458b) k1, [Key](class_tale_worlds_1_1_input_system_1_1_key.html#a47dc215097a5a5e13eaa369877cc458b) k2) |
| static bool | [operator!=](class_tale_worlds_1_1_input_system_1_1_key.html#a5d08452ab3ddddf878d9cf766257f35e) ([Key](class_tale_worlds_1_1_input_system_1_1_key.html#a47dc215097a5a5e13eaa369877cc458b) k1, [Key](class_tale_worlds_1_1_input_system_1_1_key.html#a47dc215097a5a5e13eaa369877cc458b) k2) |
| static bool | [IsLeftAnalogInput](class_tale_worlds_1_1_input_system_1_1_key.html#aef0bae5f161d03dfde110c9dfaeafcc9) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static bool | [IsLeftBumperOrTriggerInput](class_tale_worlds_1_1_input_system_1_1_key.html#ae1bec756e4bca4b584a0e4c0cc1b26a4) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static bool | [IsRightBumperOrTriggerInput](class_tale_worlds_1_1_input_system_1_1_key.html#a2e0faf44e46e454ee9eda186ae468596) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static bool | [IsFaceKeyInput](class_tale_worlds_1_1_input_system_1_1_key.html#a1c704e3e55e151d7e60b3c6ca5eba5ae) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static bool | [IsRightAnalogInput](class_tale_worlds_1_1_input_system_1_1_key.html#a610a08589f9e975245f412da533d16ac) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static bool | [IsDpadInput](class_tale_worlds_1_1_input_system_1_1_key.html#a6f016900293db2f41c393b27f03e0d52) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static [InputType](class_tale_worlds_1_1_input_system_1_1_key.html#ae41a4f03a31442b7c03852bd643bdf79) | [GetInputType](class_tale_worlds_1_1_input_system_1_1_key.html#a0d17b6e7d965484df161a593b0c35e31) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsKeyboardInput](class_tale_worlds_1_1_input_system_1_1_key.html#a517e126a0ed5969d76f2956581110cf8) `[get]` |
| bool | [IsMouseButtonInput](class_tale_worlds_1_1_input_system_1_1_key.html#a81e2da1693dfaf338a71e5afa302c615) `[get]` |
| bool | [IsMouseWheelInput](class_tale_worlds_1_1_input_system_1_1_key.html#ae9f4f7ef637d16c5a6f803ccf6824919) `[get]` |
| bool | [IsControllerInput](class_tale_worlds_1_1_input_system_1_1_key.html#a53ed9488327bcb9e82b3a9111af8d31f) `[get]` |
| [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | [InputKey](class_tale_worlds_1_1_input_system_1_1_key.html#ac7588f5f3eebc2ee079d73f87daa2e5c) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#ae41a4f03a31442b7c03852bd643bdf79)InputType
-----------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.InputSystem.Key.InputType](class_tale_worlds_1_1_input_system_1_1_key.html#ae41a4f03a31442b7c03852bd643bdf79) |

| Enumerator | |
| --- | --- |
| Invalid |  |
| Keyboard |  |
| MouseButton |  |
| MouseWheel |  |
| Controller |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a47dc215097a5a5e13eaa369877cc458b)Key() [1/2]
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.InputSystem.Key.Key | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a909de8678ccfe884ee1952d1850cac00)Key() [2/2]
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.InputSystem.Key.Key | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a5c547bf5a799a41a23751705e0f9a6b5)ChangeKey()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.InputSystem.Key.ChangeKey | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#af1d718dcbd1714b87b0431b43ca05705)ToString()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.InputSystem.Key.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#af6345ec2b3a819fd495a23e6a5c1d8fb)Equals()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.InputSystem.Key.Equals | ( | object | *obj* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a4649a785647f07553d521b2f21c72cd5)GetHashCode()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.InputSystem.Key.GetHashCode | ( |  | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a99be3d18d90c4f45e1f3cb793cd66fa0)operator==()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Key.operator== | ( | [Key](class_tale_worlds_1_1_input_system_1_1_key.html#a47dc215097a5a5e13eaa369877cc458b) | *k1*, | |  |  | [Key](class_tale_worlds_1_1_input_system_1_1_key.html#a47dc215097a5a5e13eaa369877cc458b) | *k2* ) | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a5d08452ab3ddddf878d9cf766257f35e)operator!=()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Key.operator!= | ( | [Key](class_tale_worlds_1_1_input_system_1_1_key.html#a47dc215097a5a5e13eaa369877cc458b) | *k1*, | |  |  | [Key](class_tale_worlds_1_1_input_system_1_1_key.html#a47dc215097a5a5e13eaa369877cc458b) | *k2* ) | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#aef0bae5f161d03dfde110c9dfaeafcc9)IsLeftAnalogInput()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Key.IsLeftAnalogInput | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#ae1bec756e4bca4b584a0e4c0cc1b26a4)IsLeftBumperOrTriggerInput()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Key.IsLeftBumperOrTriggerInput | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a2e0faf44e46e454ee9eda186ae468596)IsRightBumperOrTriggerInput()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Key.IsRightBumperOrTriggerInput | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a1c704e3e55e151d7e60b3c6ca5eba5ae)IsFaceKeyInput()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Key.IsFaceKeyInput | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a610a08589f9e975245f412da533d16ac)IsRightAnalogInput()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Key.IsRightAnalogInput | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a6f016900293db2f41c393b27f03e0d52)IsDpadInput()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Key.IsDpadInput | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a0d17b6e7d965484df161a593b0c35e31)GetInputType()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [InputType](class_tale_worlds_1_1_input_system_1_1_key.html#ae41a4f03a31442b7c03852bd643bdf79) TaleWorlds.InputSystem.Key.GetInputType | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a517e126a0ed5969d76f2956581110cf8)IsKeyboardInput
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.Key.IsKeyboardInput | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a81e2da1693dfaf338a71e5afa302c615)IsMouseButtonInput
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.Key.IsMouseButtonInput | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#ae9f4f7ef637d16c5a6f803ccf6824919)IsMouseWheelInput
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.Key.IsMouseWheelInput | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#a53ed9488327bcb9e82b3a9111af8d31f)IsControllerInput
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.Key.IsControllerInput | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_key.html#ac7588f5f3eebc2ee079d73f87daa2e5c)InputKey
----------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) TaleWorlds.InputSystem.Key.InputKey | | get |

