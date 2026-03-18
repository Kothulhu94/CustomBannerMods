--- SOURCE: class_tale_worlds_1_1_input_system_1_1_game_key.html ---

TaleWorlds.InputSystem.GameKey Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html#a66c26742973a99efa3a90756bf5c9c70) (int id, string stringId, string groupId, [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) defaultKeyboardKey, [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) defaultControllerKey, string mainCategoryId="") |
|  | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) object. Contains a default input key for keyboards and a key for controllers. |
|  | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html#a4ba15eeaaebaef1d1bfddaacb060b84e) (int id, string stringId, string groupId, [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) defaultKeyboardKey, string mainCategoryId="") |
|  | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) object. Contains a default input key for keyboards and a key for controllers. |
| override string | [ToString](class_tale_worlds_1_1_input_system_1_1_game_key.html#a7ce6ef0d3c04d9b61572f419c63fb5ec) () |
| override bool | [Equals](class_tale_worlds_1_1_input_system_1_1_game_key.html#aba101ba1a08b2ad2f2bd75730becdb78) (object obj) |
| override int | [GetHashCode](class_tale_worlds_1_1_input_system_1_1_game_key.html#a7aca4529c67557d18d46a4d24a74ef92) () |

|  |  |
| --- | --- |
| Properties | |
| int | [Id](class_tale_worlds_1_1_input_system_1_1_game_key.html#a006f5cc79b0840e21b4ab965555b9b3c) `[get]` |
| string | [StringId](class_tale_worlds_1_1_input_system_1_1_game_key.html#ae9e32f60e88e0b608b7fe2b062012335) `[get]` |
| string | [GroupId](class_tale_worlds_1_1_input_system_1_1_game_key.html#ab2bca0b2dba0c23b659f2a8b56085d7f) `[get]` |
| string | [MainCategoryId](class_tale_worlds_1_1_input_system_1_1_game_key.html#ab4c748cc896f98ad26adbcc2ad871115) `[get]` |
| [Key](class_tale_worlds_1_1_input_system_1_1_key.html) | [KeyboardKey](class_tale_worlds_1_1_input_system_1_1_game_key.html#afd446113724738bb6507b3bcd4f081c5) `[get]` |
| [Key](class_tale_worlds_1_1_input_system_1_1_key.html) | [DefaultKeyboardKey](class_tale_worlds_1_1_input_system_1_1_game_key.html#afdab48afc79ef66763d1afd58ebbd142) `[get]` |
| [Key](class_tale_worlds_1_1_input_system_1_1_key.html) | [ControllerKey](class_tale_worlds_1_1_input_system_1_1_game_key.html#a564d945d25bceead9adee753f38a737e) `[get]` |
| [Key](class_tale_worlds_1_1_input_system_1_1_key.html) | [DefaultControllerKey](class_tale_worlds_1_1_input_system_1_1_game_key.html#a820ea93d1deea116f2af6fc3a5da8674) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_game_key.html#a66c26742973a99efa3a90756bf5c9c70)GameKey() [1/2]
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.InputSystem.GameKey.GameKey | ( | int | *id*, |
|  |  | string | *stringId*, |
|  |  | string | *groupId*, |
|  |  | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *defaultKeyboardKey*, |
|  |  | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *defaultControllerKey*, |
|  |  | string | *mainCategoryId* = "" ) |

Parameters
:   |  |  |
    | --- | --- |
    | id | ID of the game key, unique in all groups. |
    | stringId | string ID of the game key, for saving. |
    | groupId | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) group name of the game key. |
    | defaultKeyboardKey | Default keyboard key that will be set to this gamekey. |
    | defaultControllerKey | Default gamepad key that will be set to this gamekey. |
    | mainCategoryId | Visible filter tag of gamekey. Same category gamekeys appear in the same category. |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key.html#a4ba15eeaaebaef1d1bfddaacb060b84e)GameKey() [2/2]
----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.InputSystem.GameKey.GameKey | ( | int | *id*, |
|  |  | string | *stringId*, |
|  |  | string | *groupId*, |
|  |  | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *defaultKeyboardKey*, |
|  |  | string | *mainCategoryId* = "" ) |

Parameters
:   |  |  |
    | --- | --- |
    | id | ID of the game key, unique in all groups. |
    | stringId | string ID of the game key, for saving. |
    | groupId | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) group name of the game key. |
    | defaultKeyboardKey | Default keyboard key that will be set to this gamekey. |
    | mainCategoryId | Visible filter tag of gamekey. Same category gamekeys appear in the same category. |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_game_key.html#a7ce6ef0d3c04d9b61572f419c63fb5ec)ToString()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.InputSystem.GameKey.ToString | ( |  | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key.html#aba101ba1a08b2ad2f2bd75730becdb78)Equals()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override bool TaleWorlds.InputSystem.GameKey.Equals | ( | object | *obj* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key.html#a7aca4529c67557d18d46a4d24a74ef92)GetHashCode()
--------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override int TaleWorlds.InputSystem.GameKey.GetHashCode | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_input_system_1_1_game_key.html#a006f5cc79b0840e21b4ab965555b9b3c)Id
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.InputSystem.GameKey.Id | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key.html#ae9e32f60e88e0b608b7fe2b062012335)StringId
---------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.InputSystem.GameKey.StringId | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key.html#ab2bca0b2dba0c23b659f2a8b56085d7f)GroupId
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.InputSystem.GameKey.GroupId | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key.html#ab4c748cc896f98ad26adbcc2ad871115)MainCategoryId
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.InputSystem.GameKey.MainCategoryId | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key.html#afd446113724738bb6507b3bcd4f081c5)KeyboardKey
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Key](class_tale_worlds_1_1_input_system_1_1_key.html) TaleWorlds.InputSystem.GameKey.KeyboardKey | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key.html#afdab48afc79ef66763d1afd58ebbd142)DefaultKeyboardKey
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Key](class_tale_worlds_1_1_input_system_1_1_key.html) TaleWorlds.InputSystem.GameKey.DefaultKeyboardKey | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key.html#a564d945d25bceead9adee753f38a737e)ControllerKey
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Key](class_tale_worlds_1_1_input_system_1_1_key.html) TaleWorlds.InputSystem.GameKey.ControllerKey | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_key.html#a820ea93d1deea116f2af6fc3a5da8674)DefaultControllerKey
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Key](class_tale_worlds_1_1_input_system_1_1_key.html) TaleWorlds.InputSystem.GameKey.DefaultControllerKey | | get |

