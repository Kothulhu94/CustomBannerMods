--- SOURCE: class_tale_worlds_1_1_input_system_1_1_input_context.html ---

TaleWorlds.InputSystem.InputContext Class ReferenceInherits [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [InputContext](class_tale_worlds_1_1_input_system_1_1_input_context.html#ab21ebe722c606300443a39c02451a2be) () |
| int | [GetPointerX](class_tale_worlds_1_1_input_system_1_1_input_context.html#a2befbf35d2743f2845596d0e9a1b1f3a) () |
| int | [GetPointerY](class_tale_worlds_1_1_input_system_1_1_input_context.html#ac80e776bcef32f7e58073e56b5118692) () |
| Vector2 | [GetPointerPosition](class_tale_worlds_1_1_input_system_1_1_input_context.html#ae582c4a1ad0a6d7fefe1fe532a49c8f8) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetPointerPositionVec2](class_tale_worlds_1_1_input_system_1_1_input_context.html#a90f7869a03b061dd80c99661ade39087) () |
| void | [RegisterHotKeyCategory](class_tale_worlds_1_1_input_system_1_1_input_context.html#af1da49fe754c446ba32fd19c22a8caad) ([GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) category) |
| bool | [IsCategoryRegistered](class_tale_worlds_1_1_input_system_1_1_input_context.html#af779c93f6fbc8eaf755410d205f1c90b) ([GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) category) |
| void | [RegisterDownKeys](class_tale_worlds_1_1_input_system_1_1_input_context.html#a1498b9570c71761655b88478e45623eb) () |
| void | [UnregisterReleasedKeys](class_tale_worlds_1_1_input_system_1_1_input_context.html#a6497d558f62d6b223ab41c3f7c2a6b75) () |
| void | [ResetLastDownKeys](class_tale_worlds_1_1_input_system_1_1_input_context.html#a77ef286909de6f5a663684e61e976a5e) () |
| bool | [IsHotKeyDown](class_tale_worlds_1_1_input_system_1_1_input_context.html#a0eab0eebfff47cdc1692409e48ad84da) (string hotKey) |
| bool | [IsGameKeyDown](class_tale_worlds_1_1_input_system_1_1_input_context.html#a1a330797d2715ec52366b57a237fb540) (int gameKey) |
| bool | [IsGameKeyDownImmediate](class_tale_worlds_1_1_input_system_1_1_input_context.html#acf2d67164d2728793164dbc1fd87658f) (int gameKey) |
| bool | [IsHotKeyPressed](class_tale_worlds_1_1_input_system_1_1_input_context.html#abba6a1e4eae29bfcca368b117c1c001f) (string hotKey) |
| bool | [IsGameKeyPressed](class_tale_worlds_1_1_input_system_1_1_input_context.html#afad8bfdaed7c29c2a89faa5ad5e922ee) (int gameKey) |
| bool | [IsHotKeyReleased](class_tale_worlds_1_1_input_system_1_1_input_context.html#a333ca76901714407309edfc765242d09) (string hotKey) |
| bool | [IsGameKeyReleased](class_tale_worlds_1_1_input_system_1_1_input_context.html#a671a6c45a0d736121bf376014019da02) (int gameKey) |
| float | [GetGameKeyState](class_tale_worlds_1_1_input_system_1_1_input_context.html#ab8ed655e11f73fb6a2b4d99a8e5df1da) (int gameKey) |
| bool | [IsHotKeyDoublePressed](class_tale_worlds_1_1_input_system_1_1_input_context.html#a7f9006239ceea39f6d86900e3a6f7bb0) (string hotKey) |
| float | [GetGameKeyAxis](class_tale_worlds_1_1_input_system_1_1_input_context.html#aee8b84e36dea5853a0cca47bbfd3ad33) ([GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) gameKey) |
| float | [GetGameKeyAxis](class_tale_worlds_1_1_input_system_1_1_input_context.html#aa23f5721cfb368694a415507230ba174) (string gameKey) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetKeyState](class_tale_worlds_1_1_input_system_1_1_input_context.html#a3267b0dafb761b735a3329c28bf4c878) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| bool | [IsKeyDown](class_tale_worlds_1_1_input_system_1_1_input_context.html#a365c0cf30d37796f8f8ab58e534d8b84) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| bool | [IsKeyPressed](class_tale_worlds_1_1_input_system_1_1_input_context.html#a5558ae8c138e5f3d619def8e267b4284) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| bool | [IsKeyReleased](class_tale_worlds_1_1_input_system_1_1_input_context.html#a9e42f0273d5767a15e903ee039a1fb17) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| float | [GetMouseMoveX](class_tale_worlds_1_1_input_system_1_1_input_context.html#a862074f514d149a9278d0903692cd77e) () |
| float | [GetMouseMoveY](class_tale_worlds_1_1_input_system_1_1_input_context.html#ad34b50dba7511ed25706073e09fa1f09) () |
| float | [GetNormalizedMouseMoveX](class_tale_worlds_1_1_input_system_1_1_input_context.html#a9496bb672eaae1e48991371bcd4200f7) () |
| float | [GetNormalizedMouseMoveY](class_tale_worlds_1_1_input_system_1_1_input_context.html#a9582a255247827f5921294779a2f6fb6) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetControllerRightStickState](class_tale_worlds_1_1_input_system_1_1_input_context.html#a106a7ed580c1bb4c43b454c979972da5) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetControllerLeftStickState](class_tale_worlds_1_1_input_system_1_1_input_context.html#aef7af0fc0d929cb7c69f1b504fcdb294) () |
| bool | [GetIsMouseActive](class_tale_worlds_1_1_input_system_1_1_input_context.html#afe7b04fa08046c7f21e3404981624c79) () |
| bool | [GetIsMouseDown](class_tale_worlds_1_1_input_system_1_1_input_context.html#adb54f41c5a762a0892ed8101f6e7bbad) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetMousePositionPixel](class_tale_worlds_1_1_input_system_1_1_input_context.html#ac55dfd090790761f866e37e5af12dc2d) () |
| float | [GetDeltaMouseScroll](class_tale_worlds_1_1_input_system_1_1_input_context.html#abf4dccd2d6fb6ec93d24388d73606183) () |
| bool | [GetIsControllerConnected](class_tale_worlds_1_1_input_system_1_1_input_context.html#a47f6b90549999813a59f47cd76fca573) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetMousePositionRanged](class_tale_worlds_1_1_input_system_1_1_input_context.html#a45a2bd9ada2c187e6c86db67c969aa69) () |
| float | [GetMouseSensitivity](class_tale_worlds_1_1_input_system_1_1_input_context.html#a949f73feace60cfc24f4f64dfd329702) () |
| bool | [IsControlDown](class_tale_worlds_1_1_input_system_1_1_input_context.html#a6921500e71d5f7fce7defd4a5ba7cd51) () |
| bool | [IsShiftDown](class_tale_worlds_1_1_input_system_1_1_input_context.html#a316778d202e1ea3ca08305b5f5ec469d) () |
| bool | [IsAltDown](class_tale_worlds_1_1_input_system_1_1_input_context.html#a148b7ec47c7c327c397b75c23d276698) () |
| [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50)[] | [GetClickKeys](class_tale_worlds_1_1_input_system_1_1_input_context.html#a8d099dde470d829f89a330be320e251d) () |
|  | Represents the click key for controller. In some regional builds the click key is different. |

|  |  |
| --- | --- |
| Protected Member Functions | |
| bool | [IsMouseButton](class_tale_worlds_1_1_input_system_1_1_input_context.html#a1b2775628c6a1fa70ba6b42e294270d2) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsKeysAllowed](class_tale_worlds_1_1_input_system_1_1_input_context.html#a3ca98ee1852237da5c94420fadb6e538) `[get, set]` |
| bool | [IsMouseButtonAllowed](class_tale_worlds_1_1_input_system_1_1_input_context.html#a9d282d49f995f81fb1d82df4a329a6e3) `[get, set]` |
| bool | [IsMouseWheelAllowed](class_tale_worlds_1_1_input_system_1_1_input_context.html#a6dd37fc8866aaca7a7191ecb8a963b39) `[get, set]` |
| bool | [IsControllerAllowed](class_tale_worlds_1_1_input_system_1_1_input_context.html#a6138f5bc4b7bcafc9fbc32984b38b1af) `[get]` |
| bool | [MouseOnMe](class_tale_worlds_1_1_input_system_1_1_input_context.html#a6ce7dc02fffc429988579d2c8c17f68c) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#ab21ebe722c606300443a39c02451a2be)InputContext()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.InputSystem.InputContext.InputContext | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a2befbf35d2743f2845596d0e9a1b1f3a)GetPointerX()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.InputSystem.InputContext.GetPointerX | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ac23f6e5687b8a43a0a631d58b9c029f7).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#ac80e776bcef32f7e58073e56b5118692)GetPointerY()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int TaleWorlds.InputSystem.InputContext.GetPointerY | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a8e412aa9a026d497beccb1e1e8bf2893).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#ae582c4a1ad0a6d7fefe1fe532a49c8f8)GetPointerPosition()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| Vector2 TaleWorlds.InputSystem.InputContext.GetPointerPosition | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a93019865398ca50c3c9cbd0503cba260).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a90f7869a03b061dd80c99661ade39087)GetPointerPositionVec2()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.InputContext.GetPointerPositionVec2 | ( |  | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#af1da49fe754c446ba32fd19c22a8caad)RegisterHotKeyCategory()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.InputSystem.InputContext.RegisterHotKeyCategory | ( | [GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) | *category* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#af779c93f6fbc8eaf755410d205f1c90b)IsCategoryRegistered()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsCategoryRegistered | ( | [GameKeyContext](class_tale_worlds_1_1_input_system_1_1_game_key_context.html) | *category* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a1498b9570c71761655b88478e45623eb)RegisterDownKeys()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.InputSystem.InputContext.RegisterDownKeys | ( |  | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a6497d558f62d6b223ab41c3f7c2a6b75)UnregisterReleasedKeys()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.InputSystem.InputContext.UnregisterReleasedKeys | ( |  | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a77ef286909de6f5a663684e61e976a5e)ResetLastDownKeys()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.InputSystem.InputContext.ResetLastDownKeys | ( |  | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a0eab0eebfff47cdc1692409e48ad84da)IsHotKeyDown()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsHotKeyDown | ( | string | *hotKey* | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a4bd5b8ac4b063f04c891f7c67ceab515).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a1a330797d2715ec52366b57a237fb540)IsGameKeyDown()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsGameKeyDown | ( | int | *gameKey* | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a6b38b4765601a8c106cae94537bbde08).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#acf2d67164d2728793164dbc1fd87658f)IsGameKeyDownImmediate()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsGameKeyDownImmediate | ( | int | *gameKey* | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a0989f9d11a0f410d6daa4939e1adc4f0).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#abba6a1e4eae29bfcca368b117c1c001f)IsHotKeyPressed()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsHotKeyPressed | ( | string | *hotKey* | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a6b1d0923ed198fa57768fb820a9f2b5e).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#afad8bfdaed7c29c2a89faa5ad5e922ee)IsGameKeyPressed()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsGameKeyPressed | ( | int | *gameKey* | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a494fa64ef9de1274bcf175850f2bef82).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a333ca76901714407309edfc765242d09)IsHotKeyReleased()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsHotKeyReleased | ( | string | *hotKey* | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a43f211ef95c2aee812f032f64c737598).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a671a6c45a0d736121bf376014019da02)IsGameKeyReleased()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsGameKeyReleased | ( | int | *gameKey* | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a76f038e9a558ca76e546665d5ec575d8).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#ab8ed655e11f73fb6a2b4d99a8e5df1da)GetGameKeyState()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.InputContext.GetGameKeyState | ( | int | *gameKey* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a7f9006239ceea39f6d86900e3a6f7bb0)IsHotKeyDoublePressed()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsHotKeyDoublePressed | ( | string | *hotKey* | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a3cb6ed9ce9ec876f394156bd84edf7e3).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#aee8b84e36dea5853a0cca47bbfd3ad33)GetGameKeyAxis() [1/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.InputContext.GetGameKeyAxis | ( | [GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) | *gameKey* | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#aa23f5721cfb368694a415507230ba174)GetGameKeyAxis() [2/2]
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.InputContext.GetGameKeyAxis | ( | string | *gameKey* | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a39d377e1d27d9c4a18db782e82df8d5c).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a3267b0dafb761b735a3329c28bf4c878)GetKeyState()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.InputContext.GetKeyState | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a029af1804bc9749a81e2e7d03ccd5cc0).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a1b2775628c6a1fa70ba6b42e294270d2)IsMouseButton()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.InputContext.IsMouseButton | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | protected |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a365c0cf30d37796f8f8ab58e534d8b84)IsKeyDown()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsKeyDown | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a0bf9e505dc79e34210721f7b77099031).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a5558ae8c138e5f3d619def8e267b4284)IsKeyPressed()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsKeyPressed | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a43ed31a461342e1cf92fc5b7614ebc85).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a9e42f0273d5767a15e903ee039a1fb17)IsKeyReleased()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsKeyReleased | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#aaa372c136b244a51837dc5cf40f497f6).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a862074f514d149a9278d0903692cd77e)GetMouseMoveX()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.InputContext.GetMouseMoveX | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#afd0c5a024f16c5767f867a009aaf9322).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#ad34b50dba7511ed25706073e09fa1f09)GetMouseMoveY()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.InputContext.GetMouseMoveY | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a1119d015c6f868b07366ff79e3bf9a61).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a9496bb672eaae1e48991371bcd4200f7)GetNormalizedMouseMoveX()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.InputContext.GetNormalizedMouseMoveX | ( |  | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a9582a255247827f5921294779a2f6fb6)GetNormalizedMouseMoveY()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.InputContext.GetNormalizedMouseMoveY | ( |  | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a106a7ed580c1bb4c43b454c979972da5)GetControllerRightStickState()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.InputContext.GetControllerRightStickState | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ae749cba2fcf9dfcf084f7b2cd58471f5).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#aef7af0fc0d929cb7c69f1b504fcdb294)GetControllerLeftStickState()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.InputContext.GetControllerLeftStickState | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ac3e668e53812e6570184059958dfbd95).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#afe7b04fa08046c7f21e3404981624c79)GetIsMouseActive()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.GetIsMouseActive | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a872ec1a27759b8427595835871e49a93).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#adb54f41c5a762a0892ed8101f6e7bbad)GetIsMouseDown()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.GetIsMouseDown | ( |  | ) |  |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#ac55dfd090790761f866e37e5af12dc2d)GetMousePositionPixel()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.InputContext.GetMousePositionPixel | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#aee8b0d5e67862c452f0153a192728b77).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#abf4dccd2d6fb6ec93d24388d73606183)GetDeltaMouseScroll()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.InputContext.GetDeltaMouseScroll | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#adcd4ff317936de705fc24a0b21eac379).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a47f6b90549999813a59f47cd76fca573)GetIsControllerConnected()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.GetIsControllerConnected | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ae8c443155c754ebc3d143e3c0c9012de).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a45a2bd9ada2c187e6c86db67c969aa69)GetMousePositionRanged()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.InputContext.GetMousePositionRanged | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#aed32fdaf66a435d6d58e0a3943df5aed).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a949f73feace60cfc24f4f64dfd329702)GetMouseSensitivity()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.InputContext.GetMouseSensitivity | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a0fc1ad9944df35a8c220fe759e811df2).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a6921500e71d5f7fce7defd4a5ba7cd51)IsControlDown()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsControlDown | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ac477f65e514eeac3c03b7f6c2ef590ce).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a316778d202e1ea3ca08305b5f5ec469d)IsShiftDown()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsShiftDown | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a5502b31713561b0acde496a1fa6d1261).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a148b7ec47c7c327c397b75c23d276698)IsAltDown()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputContext.IsAltDown | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#a5e27a21cc36bfe02473bf9e40440d5f7).

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a8d099dde470d829f89a330be320e251d)GetClickKeys()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50)[] TaleWorlds.InputSystem.InputContext.GetClickKeys | ( |  | ) |  |

Implements [TaleWorlds.InputSystem.IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html#ae71ea034bac2372cd7aaf83eccc332a6).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a3ca98ee1852237da5c94420fadb6e538)IsKeysAllowed
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.InputContext.IsKeysAllowed | | getset |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a9d282d49f995f81fb1d82df4a329a6e3)IsMouseButtonAllowed
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.InputContext.IsMouseButtonAllowed | | getset |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a6dd37fc8866aaca7a7191ecb8a963b39)IsMouseWheelAllowed
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.InputContext.IsMouseWheelAllowed | | getset |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a6138f5bc4b7bcafc9fbc32984b38b1af)IsControllerAllowed
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.InputContext.IsControllerAllowed | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_input_context.html#a6ce7dc02fffc429988579d2c8c17f68c)MouseOnMe
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.InputContext.MouseOnMe | | getset |

