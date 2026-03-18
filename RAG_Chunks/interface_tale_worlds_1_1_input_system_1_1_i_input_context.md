--- SOURCE: interface_tale_worlds_1_1_input_system_1_1_i_input_context.html ---

TaleWorlds.InputSystem.IInputContext Interface ReferenceInherited by [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| int | [GetPointerX](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ac23f6e5687b8a43a0a631d58b9c029f7) () |
| int | [GetPointerY](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a8e412aa9a026d497beccb1e1e8bf2893) () |
| Vector2 | [GetPointerPosition](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a93019865398ca50c3c9cbd0503cba260) () |
| bool | [IsGameKeyDown](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a6b38b4765601a8c106cae94537bbde08) (int gameKey) |
| bool | [IsGameKeyDownImmediate](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a0989f9d11a0f410d6daa4939e1adc4f0) (int gameKey) |
| bool | [IsGameKeyReleased](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a76f038e9a558ca76e546665d5ec575d8) (int gameKey) |
| bool | [IsGameKeyPressed](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a494fa64ef9de1274bcf175850f2bef82) (int gameKey) |
| float | [GetGameKeyAxis](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a39d377e1d27d9c4a18db782e82df8d5c) (string gameKey) |
| bool | [IsHotKeyDown](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a4bd5b8ac4b063f04c891f7c67ceab515) (string gameKey) |
| bool | [IsHotKeyReleased](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a43f211ef95c2aee812f032f64c737598) (string gameKey) |
| bool | [IsHotKeyPressed](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a6b1d0923ed198fa57768fb820a9f2b5e) (string gameKey) |
| bool | [IsHotKeyDoublePressed](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a3cb6ed9ce9ec876f394156bd84edf7e3) (string gameKey) |
| bool | [IsKeyDown](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a0bf9e505dc79e34210721f7b77099031) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| bool | [IsKeyPressed](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a43ed31a461342e1cf92fc5b7614ebc85) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| bool | [IsKeyReleased](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#aaa372c136b244a51837dc5cf40f497f6) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetKeyState](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a029af1804bc9749a81e2e7d03ccd5cc0) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| float | [GetMouseMoveX](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#afd0c5a024f16c5767f867a009aaf9322) () |
| float | [GetMouseMoveY](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a1119d015c6f868b07366ff79e3bf9a61) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetControllerRightStickState](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ae749cba2fcf9dfcf084f7b2cd58471f5) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetControllerLeftStickState](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ac3e668e53812e6570184059958dfbd95) () |
| float | [GetDeltaMouseScroll](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#adcd4ff317936de705fc24a0b21eac379) () |
| bool | [GetIsControllerConnected](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ae8c443155c754ebc3d143e3c0c9012de) () |
| bool | [GetIsMouseActive](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a872ec1a27759b8427595835871e49a93) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetMousePositionRanged](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#aed32fdaf66a435d6d58e0a3943df5aed) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetMousePositionPixel](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#aee8b0d5e67862c452f0153a192728b77) () |
| float | [GetMouseSensitivity](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a0fc1ad9944df35a8c220fe759e811df2) () |
| bool | [IsControlDown](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ac477f65e514eeac3c03b7f6c2ef590ce) () |
| bool | [IsShiftDown](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a5502b31713561b0acde496a1fa6d1261) () |
| bool | [IsAltDown](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a5e27a21cc36bfe02473bf9e40440d5f7) () |
| [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50)[] | [GetClickKeys](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ae71ea034bac2372cd7aaf83eccc332a6) () |
|  | Represents the click keys. In some regional builds the click key is different. And depending on options LOption can be click. |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ac23f6e5687b8a43a0a631d58b9c029f7)GetPointerX()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.InputSystem.IInputContext.GetPointerX | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a8183f76572a013fb03deedadb90eb6c0), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a2befbf35d2743f2845596d0e9a1b1f3a).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a8e412aa9a026d497beccb1e1e8bf2893)GetPointerY()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.InputSystem.IInputContext.GetPointerY | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a06621b9655df467628e0e073f372d2e3), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#ac80e776bcef32f7e58073e56b5118692).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a93019865398ca50c3c9cbd0503cba260)GetPointerPosition()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Vector2 TaleWorlds.InputSystem.IInputContext.GetPointerPosition | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a87de2ee660e82974d6ec8969c7b15aa6), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#ae582c4a1ad0a6d7fefe1fe532a49c8f8).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a6b38b4765601a8c106cae94537bbde08)IsGameKeyDown()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsGameKeyDown | ( | int | *gameKey* | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a47ce2e757bae090a32932a89d9524032), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a1a330797d2715ec52366b57a237fb540).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a0989f9d11a0f410d6daa4939e1adc4f0)IsGameKeyDownImmediate()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsGameKeyDownImmediate | ( | int | *gameKey* | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#accacdd2e3f905bc26c2776af610c775f), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#acf2d67164d2728793164dbc1fd87658f).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a76f038e9a558ca76e546665d5ec575d8)IsGameKeyReleased()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsGameKeyReleased | ( | int | *gameKey* | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a1129504530f733b9528062c7a8985df8), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a671a6c45a0d736121bf376014019da02).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a494fa64ef9de1274bcf175850f2bef82)IsGameKeyPressed()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsGameKeyPressed | ( | int | *gameKey* | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#acc722f63f4dab30279feeca2a7c6b01e), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#afad8bfdaed7c29c2a89faa5ad5e922ee).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a39d377e1d27d9c4a18db782e82df8d5c)GetGameKeyAxis()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputContext.GetGameKeyAxis | ( | string | *gameKey* | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a03abe56f162339c4f226a12f8c8be9ed), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#aa23f5721cfb368694a415507230ba174).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a4bd5b8ac4b063f04c891f7c67ceab515)IsHotKeyDown()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsHotKeyDown | ( | string | *gameKey* | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#aca945b00c92fd989646dde7e37460b09), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a0eab0eebfff47cdc1692409e48ad84da).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a43f211ef95c2aee812f032f64c737598)IsHotKeyReleased()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsHotKeyReleased | ( | string | *gameKey* | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a7ee44504fa202ddb44e053b382226ca4), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a333ca76901714407309edfc765242d09).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a6b1d0923ed198fa57768fb820a9f2b5e)IsHotKeyPressed()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsHotKeyPressed | ( | string | *gameKey* | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#ac772d5035950130675f7eeefad0ee8ec), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#abba6a1e4eae29bfcca368b117c1c001f).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a3cb6ed9ce9ec876f394156bd84edf7e3)IsHotKeyDoublePressed()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsHotKeyDoublePressed | ( | string | *gameKey* | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a3c2ef535c2c0d709e94b19e10507d029), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a7f9006239ceea39f6d86900e3a6f7bb0).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a0bf9e505dc79e34210721f7b77099031)IsKeyDown()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsKeyDown | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a5923a7272382c1f896a83140797a31b2), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a365c0cf30d37796f8f8ab58e534d8b84).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a43ed31a461342e1cf92fc5b7614ebc85)IsKeyPressed()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsKeyPressed | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#adbeeef3871a8e05c72168445add95214), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a5558ae8c138e5f3d619def8e267b4284).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#aaa372c136b244a51837dc5cf40f497f6)IsKeyReleased()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsKeyReleased | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#aa65621b424d0c0f70782a9c0869080e0), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a9e42f0273d5767a15e903ee039a1fb17).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a029af1804bc9749a81e2e7d03ccd5cc0)GetKeyState()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.IInputContext.GetKeyState | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#aed414b82a205a69d16ef0abe054a49d2), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a3267b0dafb761b735a3329c28bf4c878).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#afd0c5a024f16c5767f867a009aaf9322)GetMouseMoveX()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputContext.GetMouseMoveX | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#ac6c76daebfb19faa3403a12be33cc8ed), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a862074f514d149a9278d0903692cd77e).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a1119d015c6f868b07366ff79e3bf9a61)GetMouseMoveY()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputContext.GetMouseMoveY | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#ad2fee6db753d5c661021e6c203363047), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#ad34b50dba7511ed25706073e09fa1f09).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ae749cba2fcf9dfcf084f7b2cd58471f5)GetControllerRightStickState()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.IInputContext.GetControllerRightStickState | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a4b916b10ee93a4d4ab99ace413595790), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a106a7ed580c1bb4c43b454c979972da5).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ac3e668e53812e6570184059958dfbd95)GetControllerLeftStickState()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.IInputContext.GetControllerLeftStickState | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a12be33d8ea3b13d62d99ca16d7e28390), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#aef7af0fc0d929cb7c69f1b504fcdb294).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#adcd4ff317936de705fc24a0b21eac379)GetDeltaMouseScroll()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputContext.GetDeltaMouseScroll | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#ac2d495e71c7b75107c813b5edc1929dd), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#abf4dccd2d6fb6ec93d24388d73606183).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ae8c443155c754ebc3d143e3c0c9012de)GetIsControllerConnected()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.GetIsControllerConnected | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a5265a71aed832ff8a285d0f61886928b), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a47f6b90549999813a59f47cd76fca573).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a872ec1a27759b8427595835871e49a93)GetIsMouseActive()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.GetIsMouseActive | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a4aba63e6207329661c2c622bddc72ac2), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#afe7b04fa08046c7f21e3404981624c79).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#aed32fdaf66a435d6d58e0a3943df5aed)GetMousePositionRanged()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.IInputContext.GetMousePositionRanged | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a974ca629ec319793650cec58884fd5b3), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a45a2bd9ada2c187e6c86db67c969aa69).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#aee8b0d5e67862c452f0153a192728b77)GetMousePositionPixel()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.IInputContext.GetMousePositionPixel | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a7fd3ffd69711b521a8fc3cebcc520269), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#ac55dfd090790761f866e37e5af12dc2d).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a0fc1ad9944df35a8c220fe759e811df2)GetMouseSensitivity()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputContext.GetMouseSensitivity | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a6a9d1c6b7b3b8fe24642cda307d721fe), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a949f73feace60cfc24f4f64dfd329702).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ac477f65e514eeac3c03b7f6c2ef590ce)IsControlDown()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsControlDown | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#aa4715dc5d16c83d04ee6f0095710295d), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a6921500e71d5f7fce7defd4a5ba7cd51).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a5502b31713561b0acde496a1fa6d1261)IsShiftDown()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsShiftDown | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#aaec0bfad076c8fca7049e1eb9856f728), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a316778d202e1ea3ca08305b5f5ec469d).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a5e27a21cc36bfe02473bf9e40440d5f7)IsAltDown()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputContext.IsAltDown | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a7107b50aa60e2af6cd4ddcc928ccefd9), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a148b7ec47c7c327c397b75c23d276698).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ae71ea034bac2372cd7aaf83eccc332a6)GetClickKeys()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50)[] TaleWorlds.InputSystem.IInputContext.GetClickKeys | ( |  | ) |  |

Implemented in [TaleWorlds.InputSystem.EmptyInputContext](class_tale_worlds_1_1_input_system_1_1_empty_input_context.html#a7f9a824dc87db350a6839153ef9dc4ae), and [TaleWorlds.InputSystem.InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#a8d099dde470d829f89a330be320e251d).

