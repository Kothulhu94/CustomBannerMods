--- SOURCE: interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html ---

TaleWorlds.InputSystem.IInputManager Interface ReferenceInherited by [TaleWorlds.Engine.InputSystem.EngineInputManager](class_tale_worlds_1_1_engine_1_1_input_system_1_1_engine_input_manager.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| float | [GetMousePositionX](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a8b5311a00c88d633b6dbb3908184ffa6) () |
| float | [GetMousePositionY](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a341a5bcc8d65c92d8e9eea77ce4afff8) () |
| float | [GetMouseScrollValue](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#af6a32d6365b32d114fc12a38aa9fd719) () |
| [Input.ControllerTypes](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5) | [GetControllerType](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a8ce601f372e815c5a248e4b390b540f8) () |
| bool | [IsMouseActive](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a8790952e86ebb1d30594df62b915428a) () |
| bool | [IsControllerConnected](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a851120160cc1451117ede27f65ebc482) () |
| bool | [IsAnyTouchActive](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a393b85aa45b9a6b07efafe0017ac6a67) () |
| void | [PressKey](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a284278d0c6d8bd91a1470a0e5540cab9) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| void | [ClearKeys](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#ae34532e5f078cfbd7f4bdc6b6cb2f566) () |
| int | [GetVirtualKeyCode](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a68c87c457b71cdac627abdd5ae3920c0) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| void | [SetClipboardText](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#aa341625fff38a1adf904a610bd08c885) (string text) |
| string | [GetClipboardText](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a5d70cf5ebdf5aee2606e6d96ccee4d0b) () |
| float | [GetMouseMoveX](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a3df21b71cbd43b3c6492e0fd67b1b499) () |
| float | [GetMouseMoveY](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a32e89406016ef90f3fdcc8927f648306) () |
| float | [GetNormalizedMouseMoveX](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a4b91a60a182a91d842885371419fefe3) () |
| float | [GetNormalizedMouseMoveY](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a4fd251bc15a2fd00e9342c52b246324c) () |
| float | [GetGyroX](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#af06c3276e9324e9dc78ae5f125704d45) () |
| float | [GetGyroY](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a6a815aa41c96f7879c31c61f4293268d) () |
| float | [GetGyroZ](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a82c7a58c7ff1db48c80e70a37e9ca6fb) () |
| float | [GetMouseSensitivity](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#ab9f6895f8f343f192b6893c766a8c3b5) () |
| float | [GetMouseDeltaZ](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a798f4141d3a5dedf4fcd0083a4616aa7) () |
| void | [UpdateKeyData](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#add9b7b0a8c398dd768b76fe798385935) (Byte[] keyData) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetKeyState](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#abc74e27f6b3f4e7677bda5748e5b10b4) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| bool | [IsKeyPressed](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a85e536f73a49ea9b132697d1be6988b8) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| bool | [IsKeyDown](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a87db552ff8e55574382657423bcde236) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| bool | [IsKeyDownImmediate](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#ab7c78bc36206bdd5d94500f4fed9367f) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| bool | [IsKeyReleased](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a500810b651f75b25501afa1fc792761a) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetResolution](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a362a6bb0efbefa349d5bf37d85afe7cd) () |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetDesktopResolution](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#ab74d962fcbe6ba3a09ce7091691b6410) () |
| void | [SetCursorPosition](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#aacabaf0fcb91a6f8f038b4085e366d80) (int x, int y) |
| void | [SetCursorFriction](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a1c3e26c4cd9eb8ca5c74e8e6b0e64264) (float frictionValue) |
| [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50)[] | [GetClickKeys](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a633749c685019cd2c13946123656964d) () |
|  | Represents the click key for controller. In some regional builds the click key is different. |
| void | [SetRumbleEffect](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a072a0a006623c3e3166f09651ebea85f) (float[] lowFrequencyLevels, float[] lowFrequencyDurations, int numLowFrequencyElements, float[] highFrequencyLevels, float[] highFrequencyDurations, int numHighFrequencyElements) |
|  | Controller Specific Methods. |
| void | [SetTriggerFeedback](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a30dd26105e5c9bad7d37e5f5b04a0248) (byte leftTriggerPosition, byte leftTriggerStrength, byte rightTriggerPosition, byte rightTriggerStrength) |
| void | [SetTriggerWeaponEffect](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#addc8e555d60c728d67b807d15097d259) (byte leftStartPosition, byte leftEnd\_position, byte leftStrength, byte rightStartPosition, byte rightEndPosition, byte rightStrength) |
| void | [SetTriggerVibration](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a128afde9fd30e4a95995639b76750276) (float[] leftTriggerAmplitudes, float[] leftTriggerFrequencies, float[] leftTriggerDurations, int numLeftTriggerElements, float[] rightTriggerAmplitudes, float[] rightTriggerFrequencies, float[] rightTriggerDurations, int numRightTriggerElements) |
| void | [SetLightbarColor](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#ad5d9f16cab7a02fc429c8409b2d688a5) (float red, float green, float blue) |

Member Function Documentation
-----------------------------

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a8b5311a00c88d633b6dbb3908184ffa6)GetMousePositionX()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputManager.GetMousePositionX | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a341a5bcc8d65c92d8e9eea77ce4afff8)GetMousePositionY()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputManager.GetMousePositionY | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#af6a32d6365b32d114fc12a38aa9fd719)GetMouseScrollValue()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputManager.GetMouseScrollValue | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a8ce601f372e815c5a248e4b390b540f8)GetControllerType()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Input.ControllerTypes](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5) TaleWorlds.InputSystem.IInputManager.GetControllerType | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a8790952e86ebb1d30594df62b915428a)IsMouseActive()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputManager.IsMouseActive | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a851120160cc1451117ede27f65ebc482)IsControllerConnected()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputManager.IsControllerConnected | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a393b85aa45b9a6b07efafe0017ac6a67)IsAnyTouchActive()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputManager.IsAnyTouchActive | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a284278d0c6d8bd91a1470a0e5540cab9)PressKey()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.InputSystem.IInputManager.PressKey | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#ae34532e5f078cfbd7f4bdc6b6cb2f566)ClearKeys()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.InputSystem.IInputManager.ClearKeys | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a68c87c457b71cdac627abdd5ae3920c0)GetVirtualKeyCode()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| int TaleWorlds.InputSystem.IInputManager.GetVirtualKeyCode | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#aa341625fff38a1adf904a610bd08c885)SetClipboardText()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.InputSystem.IInputManager.SetClipboardText | ( | string | *text* | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a5d70cf5ebdf5aee2606e6d96ccee4d0b)GetClipboardText()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| string TaleWorlds.InputSystem.IInputManager.GetClipboardText | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a3df21b71cbd43b3c6492e0fd67b1b499)GetMouseMoveX()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputManager.GetMouseMoveX | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a32e89406016ef90f3fdcc8927f648306)GetMouseMoveY()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputManager.GetMouseMoveY | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a4b91a60a182a91d842885371419fefe3)GetNormalizedMouseMoveX()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputManager.GetNormalizedMouseMoveX | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a4fd251bc15a2fd00e9342c52b246324c)GetNormalizedMouseMoveY()
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputManager.GetNormalizedMouseMoveY | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#af06c3276e9324e9dc78ae5f125704d45)GetGyroX()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputManager.GetGyroX | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a6a815aa41c96f7879c31c61f4293268d)GetGyroY()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputManager.GetGyroY | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a82c7a58c7ff1db48c80e70a37e9ca6fb)GetGyroZ()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputManager.GetGyroZ | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#ab9f6895f8f343f192b6893c766a8c3b5)GetMouseSensitivity()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputManager.GetMouseSensitivity | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a798f4141d3a5dedf4fcd0083a4616aa7)GetMouseDeltaZ()
----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| float TaleWorlds.InputSystem.IInputManager.GetMouseDeltaZ | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#add9b7b0a8c398dd768b76fe798385935)UpdateKeyData()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.InputSystem.IInputManager.UpdateKeyData | ( | Byte[] | *keyData* | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#abc74e27f6b3f4e7677bda5748e5b10b4)GetKeyState()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.IInputManager.GetKeyState | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a85e536f73a49ea9b132697d1be6988b8)IsKeyPressed()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputManager.IsKeyPressed | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a87db552ff8e55574382657423bcde236)IsKeyDown()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputManager.IsKeyDown | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#ab7c78bc36206bdd5d94500f4fed9367f)IsKeyDownImmediate()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputManager.IsKeyDownImmediate | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a500810b651f75b25501afa1fc792761a)IsKeyReleased()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.IInputManager.IsKeyReleased | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a362a6bb0efbefa349d5bf37d85afe7cd)GetResolution()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.IInputManager.GetResolution | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#ab74d962fcbe6ba3a09ce7091691b6410)GetDesktopResolution()
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.IInputManager.GetDesktopResolution | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#aacabaf0fcb91a6f8f038b4085e366d80)SetCursorPosition()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.InputSystem.IInputManager.SetCursorPosition | ( | int | *x*, |
|  |  | int | *y* ) |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a1c3e26c4cd9eb8ca5c74e8e6b0e64264)SetCursorFriction()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.InputSystem.IInputManager.SetCursorFriction | ( | float | *frictionValue* | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a633749c685019cd2c13946123656964d)GetClickKeys()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50)[] TaleWorlds.InputSystem.IInputManager.GetClickKeys | ( |  | ) |  |

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a072a0a006623c3e3166f09651ebea85f)SetRumbleEffect()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.InputSystem.IInputManager.SetRumbleEffect | ( | float[] | *lowFrequencyLevels*, |
|  |  | float[] | *lowFrequencyDurations*, |
|  |  | int | *numLowFrequencyElements*, |
|  |  | float[] | *highFrequencyLevels*, |
|  |  | float[] | *highFrequencyDurations*, |
|  |  | int | *numHighFrequencyElements* ) |

Implemented in [TaleWorlds.Engine.InputSystem.EngineInputManager](class_tale_worlds_1_1_engine_1_1_input_system_1_1_engine_input_manager.html#ab6546f5c9435cb3c0a790d84d5cc77bb).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a30dd26105e5c9bad7d37e5f5b04a0248)SetTriggerFeedback()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.InputSystem.IInputManager.SetTriggerFeedback | ( | byte | *leftTriggerPosition*, |
|  |  | byte | *leftTriggerStrength*, |
|  |  | byte | *rightTriggerPosition*, |
|  |  | byte | *rightTriggerStrength* ) |

Implemented in [TaleWorlds.Engine.InputSystem.EngineInputManager](class_tale_worlds_1_1_engine_1_1_input_system_1_1_engine_input_manager.html#a6241984eed73448211db83002ca5545b).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#addc8e555d60c728d67b807d15097d259)SetTriggerWeaponEffect()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.InputSystem.IInputManager.SetTriggerWeaponEffect | ( | byte | *leftStartPosition*, |
|  |  | byte | *leftEnd\_position*, |
|  |  | byte | *leftStrength*, |
|  |  | byte | *rightStartPosition*, |
|  |  | byte | *rightEndPosition*, |
|  |  | byte | *rightStrength* ) |

Implemented in [TaleWorlds.Engine.InputSystem.EngineInputManager](class_tale_worlds_1_1_engine_1_1_input_system_1_1_engine_input_manager.html#af242c428407f45f76cc9d227bf54cb80).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#a128afde9fd30e4a95995639b76750276)SetTriggerVibration()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.InputSystem.IInputManager.SetTriggerVibration | ( | float[] | *leftTriggerAmplitudes*, |
|  |  | float[] | *leftTriggerFrequencies*, |
|  |  | float[] | *leftTriggerDurations*, |
|  |  | int | *numLeftTriggerElements*, |
|  |  | float[] | *rightTriggerAmplitudes*, |
|  |  | float[] | *rightTriggerFrequencies*, |
|  |  | float[] | *rightTriggerDurations*, |
|  |  | int | *numRightTriggerElements* ) |

Implemented in [TaleWorlds.Engine.InputSystem.EngineInputManager](class_tale_worlds_1_1_engine_1_1_input_system_1_1_engine_input_manager.html#a6d9e46fb085aaef7e4329654a3c2c4d8).

[◆](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html#ad5d9f16cab7a02fc429c8409b2d688a5)SetLightbarColor()
------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.InputSystem.IInputManager.SetLightbarColor | ( | float | *red*, |
|  |  | float | *green*, |
|  |  | float | *blue* ) |

Implemented in [TaleWorlds.Engine.InputSystem.EngineInputManager](class_tale_worlds_1_1_engine_1_1_input_system_1_1_engine_input_manager.html#ad9c37650a27f26de67b76ad4e532ddca).

