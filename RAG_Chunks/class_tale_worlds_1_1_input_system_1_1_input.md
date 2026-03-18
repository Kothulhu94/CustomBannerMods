--- SOURCE: class_tale_worlds_1_1_input_system_1_1_input.html ---

TaleWorlds.InputSystem.Input Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [ControllerTypes](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5) {     [None](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5a6adf97f83acf6453d4a6a4b1070f3754) = 0x00 ,     [Xbox](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5a183709ebe3a1d675014d32b94ad7ed94) = 0x01 ,     [PlayStationDualShock](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5a8cbdf57d9a8615a5386c922cdbb36ae9) = 0x02 ,     [PlayStationDualSense](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5a0f8c8ee8ccef7991276909d8120de3da) = 0x04   } |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [IsPlaystation](class_tale_worlds_1_1_input_system_1_1_input.html#a1944672aec30535f8be83aa6a350e261) (this [ControllerTypes](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5) controllerType) |
| static void | [Initialize](class_tale_worlds_1_1_input_system_1_1_input.html#a2a55c500382cb9ee639fe8b1190a7ee2) ([IInputManager](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html) inputManager, [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) debugInput) |
| static void | [UpdateKeyData](class_tale_worlds_1_1_input_system_1_1_input.html#ad7ee53444ad7041a66dbd921f74fa7fd) (byte[] keyData) |
| static float | [GetMouseMoveX](class_tale_worlds_1_1_input_system_1_1_input.html#a3574936dd76d10875c933de0855dc131) () |
| static float | [GetMouseMoveY](class_tale_worlds_1_1_input_system_1_1_input.html#ae1045802b2fb4d1c56260ff7a5df8cd0) () |
| static float | [GetNormalizedMouseMoveX](class_tale_worlds_1_1_input_system_1_1_input.html#a67da133f0eae644249a60ab98dfcbb03) () |
| static float | [GetNormalizedMouseMoveY](class_tale_worlds_1_1_input_system_1_1_input.html#a7d1a71b4133d462b7253b7b090e9007c) () |
| static float | [GetGyroX](class_tale_worlds_1_1_input_system_1_1_input.html#ad2f715dbd8a98f24dd6ad7c64da6c0ae) () |
| static float | [GetGyroY](class_tale_worlds_1_1_input_system_1_1_input.html#ae01ffa9921a2330e159fdb028a218c0a) () |
| static float | [GetGyroZ](class_tale_worlds_1_1_input_system_1_1_input.html#ab634605cb54d19f680213b5d31b32481) () |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [GetKeyState](class_tale_worlds_1_1_input_system_1_1_input.html#abd4ef897bcdd46e0da9a71653690a579) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static bool | [IsKeyPressed](class_tale_worlds_1_1_input_system_1_1_input.html#aeb1ba3bdfca66d073e9af995b54bfedf) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static bool | [IsKeyDown](class_tale_worlds_1_1_input_system_1_1_input.html#a337e304fa955b50149768695efe2c0f1) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static bool | [IsKeyDownImmediate](class_tale_worlds_1_1_input_system_1_1_input.html#a9235acc6bdeb820b48db137a342af09a) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static bool | [IsKeyReleased](class_tale_worlds_1_1_input_system_1_1_input.html#a70bf80632a545f9cb8c771c98984b157) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static bool | [IsControlOrShiftNotDown](class_tale_worlds_1_1_input_system_1_1_input.html#abb3f29b684dd73e4abaac2e624c3eae0) () |
| static [ControllerTypes](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5) | [GetPrimaryControllerType](class_tale_worlds_1_1_input_system_1_1_input.html#a7580d92ae3a683632eaa4c16c7f7321e) () |
| static int | [GetFirstKeyPressedInRange](class_tale_worlds_1_1_input_system_1_1_input.html#a7998a406ea4e47ea82129a6213cfe46b) (int startKeyNo) |
| static int | [GetFirstKeyDownInRange](class_tale_worlds_1_1_input_system_1_1_input.html#a1564760778c5f7f12dfcb4ce056d47bb) (int startKeyNo) |
| static int | [GetFirstKeyReleasedInRange](class_tale_worlds_1_1_input_system_1_1_input.html#a5d8779af1d9a45b3d3fb8db2e2f3d22c) (int startKeyNo) |
| static void | [PressKey](class_tale_worlds_1_1_input_system_1_1_input.html#a18e786a844ebebbaaa80a068102572ca) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static void | [ClearKeys](class_tale_worlds_1_1_input_system_1_1_input.html#a340b0aa40e6a6e22f4f662a8040c946d) () |
| static int | [GetVirtualKeyCode](class_tale_worlds_1_1_input_system_1_1_input.html#ace57fe4dc69784f44479212f0d3a2a7d) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static bool | [IsDown](class_tale_worlds_1_1_input_system_1_1_input.html#a61d04b38ae25750d67ca26840980a29f) (this [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static bool | [IsPressed](class_tale_worlds_1_1_input_system_1_1_input.html#a4bc99b18f0aa1e65986e4d7581c9c034) (this [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static bool | [IsReleased](class_tale_worlds_1_1_input_system_1_1_input.html#a94fc8c4dc6541f65c768de44ec56ed0c) (this [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static void | [SetClipboardText](class_tale_worlds_1_1_input_system_1_1_input.html#a131aedc83fa8c1e5b6e299a916c64e61) (System.String text) |
| static string | [GetClipboardText](class_tale_worlds_1_1_input_system_1_1_input.html#a45a9a3e0d66ce598ceac75e477b6603f) () |
| static void | [Update](class_tale_worlds_1_1_input_system_1_1_input.html#a12231c4e935e36cdda7ddbef280aef91) () |
| static bool | [IsControllerKey](class_tale_worlds_1_1_input_system_1_1_input.html#a9241db00bd2352d2375f6fe7ad22d4e8) ([InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) key) |
| static void | [SetMousePosition](class_tale_worlds_1_1_input_system_1_1_input.html#a1cce44de0146695b5f38a0a84b32eb2a) (int x, int y) |
| static void | [SetCursorFriction](class_tale_worlds_1_1_input_system_1_1_input.html#ae339dc8e4f50e03c1d5e51846e0eefd6) (float frictionValue) |
| static [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50)[] | [GetClickKeys](class_tale_worlds_1_1_input_system_1_1_input.html#a10be6b4dde062212b1193eb6114da49c) () |
|  | Represents the click keys. In some regional builds the click key is different. Sometimes LOption is also click. |
| static void | [SetRumbleEffect](class_tale_worlds_1_1_input_system_1_1_input.html#a2f9b93ce969c65412c8d23e8c992c445) (float[] lowFrequencyLevels, float[] lowFrequencyDurations, int numLowFrequencyElements, float[] highFrequencyLevels, float[] highFrequencyDurations, int numHighFrequencyElements) |
| static void | [SetTriggerFeedback](class_tale_worlds_1_1_input_system_1_1_input.html#a74c22febedeff78e4a0e636d82fda13f) (byte leftTriggerPosition, byte leftTriggerStrength, byte rightTriggerPosition, byte rightTriggerStrength) |
| static void | [SetTriggerWeaponEffect](class_tale_worlds_1_1_input_system_1_1_input.html#a34ab4b1be9c0b90d627f7bc4a626640d) (byte leftStartPosition, byte leftEnd\_position, byte leftStrength, byte rightStartPosition, byte rightEndPosition, byte rightStrength) |
| static void | [SetTriggerVibration](class_tale_worlds_1_1_input_system_1_1_input.html#a1921b7b4032b717cfcaace1b2495256d) (float[] leftTriggerAmplitudes, float[] leftTriggerFrequencies, float[] leftTriggerDurations, int numLeftTriggerElements, float[] rightTriggerAmplitudes, float[] rightTriggerFrequencies, float[] rightTriggerDurations, int numRightTriggerElements) |
| static void | [SetLightbarColor](class_tale_worlds_1_1_input_system_1_1_input.html#ab94b4ec20c71041928e1db5916197fe2) (float red, float green, float blue) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [NumberOfKeys](class_tale_worlds_1_1_input_system_1_1_input.html#a08510f29a5b4b4218a9860254ca1250f) = 256 |
| static Action | [OnGamepadActiveStateChanged](class_tale_worlds_1_1_input_system_1_1_input.html#a9847395ff31625ddfff5067a3e4874e5) |
| static Action< [ControllerTypes](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5) > | [OnControllerTypeChanged](class_tale_worlds_1_1_input_system_1_1_input.html#a2735d20f1acbb2e85f19d88791168ad1) |

|  |  |
| --- | --- |
| Properties | |
| static InputState | [InputState](class_tale_worlds_1_1_input_system_1_1_input.html#afa650e8ad4c22a0a0d5d805fbf15b35c) `[get]` |
| static [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | [DebugInput](class_tale_worlds_1_1_input_system_1_1_input.html#a938339e584229201f80a130f047026ab) `[get]` |
| static [IInputManager](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html) | [InputManager](class_tale_worlds_1_1_input_system_1_1_input.html#a026faf305a54bb882aa1041467f6ccef) `[get]` |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [Resolution](class_tale_worlds_1_1_input_system_1_1_input.html#af327f36afe9333f3e1c29b0fc0bdb2a9) `[get]` |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [DesktopResolution](class_tale_worlds_1_1_input_system_1_1_input.html#a51c30068b57d671f8705f45f898329c8) `[get]` |
| static bool | [IsOnScreenKeyboardActive](class_tale_worlds_1_1_input_system_1_1_input.html#a2cb6b7684213054fadde3524a96911dc) `[get, set]` |
| static bool | [IsMouseActive](class_tale_worlds_1_1_input_system_1_1_input.html#aeaddf8c1f158dcfac7785dde738d74bd) `[get]` |
| static bool | [IsControllerConnected](class_tale_worlds_1_1_input_system_1_1_input.html#a3c5bd2173a9d29e10ac8891304bb2dac) `[get]` |
| static bool | [IsGamepadActive](class_tale_worlds_1_1_input_system_1_1_input.html#a84d9bef312845120183c919565a2e015) `[get]` |
| static bool | [IsAnyTouchActive](class_tale_worlds_1_1_input_system_1_1_input.html#a24ca5744290c4d0b0e29055347a6cff7) `[get]` |
| static [ControllerTypes](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5) | [ControllerType](class_tale_worlds_1_1_input_system_1_1_input.html#abfc4a25d68c0b18eea5a61f657616e97) `[get]` |
| static float | [MouseMoveX](class_tale_worlds_1_1_input_system_1_1_input.html#a0bfa58c96b1e70440970817843fbe8a9) `[get]` |
| static float | [MouseMoveY](class_tale_worlds_1_1_input_system_1_1_input.html#a98e2296b95950e6b7f46629c4a365140) `[get]` |
| static float | [GyroX](class_tale_worlds_1_1_input_system_1_1_input.html#ac22ca24afa136e1afae2cd09f7548731) `[get]` |
| static float | [GyroY](class_tale_worlds_1_1_input_system_1_1_input.html#aaeca7bffeabb43388f9739f221472ef9) `[get]` |
| static float | [GyroZ](class_tale_worlds_1_1_input_system_1_1_input.html#ac039b2bdcc4e3fb7b0ab0dc508878999) `[get]` |
| static float | [MouseSensitivity](class_tale_worlds_1_1_input_system_1_1_input.html#a7b38a11da37e91dc83c06bdd763af430) `[get]` |
| static float | [DeltaMouseScroll](class_tale_worlds_1_1_input_system_1_1_input.html#a8da20d2422c81a46eebea521234d96dc) `[get]` |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [MousePositionRanged](class_tale_worlds_1_1_input_system_1_1_input.html#af78367394492f348af14f1e1a98a3696) `[get]` |
| static [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [MousePositionPixel](class_tale_worlds_1_1_input_system_1_1_input.html#a4263272e367244bbcb1edb114438db75) `[get]` |
| static bool | [IsMousePositionUpdated](class_tale_worlds_1_1_input_system_1_1_input.html#a761a0ad15043b4e9020ef9238330253c) `[get]` |
| static bool | [IsMouseScrollChanged](class_tale_worlds_1_1_input_system_1_1_input.html#a463378f9232857c4320a272963d80d8f) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5)ControllerTypes
-------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.InputSystem.Input.ControllerTypes](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5) |

| Enumerator | |
| --- | --- |
| None |  |
| Xbox |  |
| PlayStationDualShock |  |
| PlayStationDualSense |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a1944672aec30535f8be83aa6a350e261)IsPlaystation()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Input.IsPlaystation | ( | this [ControllerTypes](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5) | *controllerType* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a2a55c500382cb9ee639fe8b1190a7ee2)Initialize()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.InputSystem.Input.Initialize | ( | [IInputManager](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html) | *inputManager*, | |  |  | [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) | *debugInput* ) | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#ad7ee53444ad7041a66dbd921f74fa7fd)UpdateKeyData()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.InputSystem.Input.UpdateKeyData | ( | byte[] | *keyData* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a3574936dd76d10875c933de0855dc131)GetMouseMoveX()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.InputSystem.Input.GetMouseMoveX | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#ae1045802b2fb4d1c56260ff7a5df8cd0)GetMouseMoveY()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.InputSystem.Input.GetMouseMoveY | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a67da133f0eae644249a60ab98dfcbb03)GetNormalizedMouseMoveX()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.InputSystem.Input.GetNormalizedMouseMoveX | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a7d1a71b4133d462b7253b7b090e9007c)GetNormalizedMouseMoveY()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.InputSystem.Input.GetNormalizedMouseMoveY | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#ad2f715dbd8a98f24dd6ad7c64da6c0ae)GetGyroX()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.InputSystem.Input.GetGyroX | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#ae01ffa9921a2330e159fdb028a218c0a)GetGyroY()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.InputSystem.Input.GetGyroY | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#ab634605cb54d19f680213b5d31b32481)GetGyroZ()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | float TaleWorlds.InputSystem.Input.GetGyroZ | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#abd4ef897bcdd46e0da9a71653690a579)GetKeyState()
-----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.Input.GetKeyState | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#aeb1ba3bdfca66d073e9af995b54bfedf)IsKeyPressed()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Input.IsKeyPressed | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a337e304fa955b50149768695efe2c0f1)IsKeyDown()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Input.IsKeyDown | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a9235acc6bdeb820b48db137a342af09a)IsKeyDownImmediate()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Input.IsKeyDownImmediate | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a70bf80632a545f9cb8c771c98984b157)IsKeyReleased()
-------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Input.IsKeyReleased | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#abb3f29b684dd73e4abaac2e624c3eae0)IsControlOrShiftNotDown()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Input.IsControlOrShiftNotDown | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a7580d92ae3a683632eaa4c16c7f7321e)GetPrimaryControllerType()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [ControllerTypes](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5) TaleWorlds.InputSystem.Input.GetPrimaryControllerType | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a7998a406ea4e47ea82129a6213cfe46b)GetFirstKeyPressedInRange()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.InputSystem.Input.GetFirstKeyPressedInRange | ( | int | *startKeyNo* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a1564760778c5f7f12dfcb4ce056d47bb)GetFirstKeyDownInRange()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.InputSystem.Input.GetFirstKeyDownInRange | ( | int | *startKeyNo* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a5d8779af1d9a45b3d3fb8db2e2f3d22c)GetFirstKeyReleasedInRange()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.InputSystem.Input.GetFirstKeyReleasedInRange | ( | int | *startKeyNo* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a18e786a844ebebbaaa80a068102572ca)PressKey()
--------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.InputSystem.Input.PressKey | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a340b0aa40e6a6e22f4f662a8040c946d)ClearKeys()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.InputSystem.Input.ClearKeys | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#ace57fe4dc69784f44479212f0d3a2a7d)GetVirtualKeyCode()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | int TaleWorlds.InputSystem.Input.GetVirtualKeyCode | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a61d04b38ae25750d67ca26840980a29f)IsDown()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Input.IsDown | ( | this [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a4bc99b18f0aa1e65986e4d7581c9c034)IsPressed()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Input.IsPressed | ( | this [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a94fc8c4dc6541f65c768de44ec56ed0c)IsReleased()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Input.IsReleased | ( | this [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a131aedc83fa8c1e5b6e299a916c64e61)SetClipboardText()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.InputSystem.Input.SetClipboardText | ( | System.String | *text* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a45a9a3e0d66ce598ceac75e477b6603f)GetClipboardText()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | string TaleWorlds.InputSystem.Input.GetClipboardText | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a12231c4e935e36cdda7ddbef280aef91)Update()
------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.InputSystem.Input.Update | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a9241db00bd2352d2375f6fe7ad22d4e8)IsControllerKey()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool TaleWorlds.InputSystem.Input.IsControllerKey | ( | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *key* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a1cce44de0146695b5f38a0a84b32eb2a)SetMousePosition()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.InputSystem.Input.SetMousePosition | ( | int | *x*, | |  |  | int | *y* ) | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#ae339dc8e4f50e03c1d5e51846e0eefd6)SetCursorFriction()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.InputSystem.Input.SetCursorFriction | ( | float | *frictionValue* | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a10be6b4dde062212b1193eb6114da49c)GetClickKeys()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50)[] TaleWorlds.InputSystem.Input.GetClickKeys | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a2f9b93ce969c65412c8d23e8c992c445)SetRumbleEffect()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.InputSystem.Input.SetRumbleEffect | ( | float[] | *lowFrequencyLevels*, | |  |  | float[] | *lowFrequencyDurations*, | |  |  | int | *numLowFrequencyElements*, | |  |  | float[] | *highFrequencyLevels*, | |  |  | float[] | *highFrequencyDurations*, | |  |  | int | *numHighFrequencyElements* ) | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a74c22febedeff78e4a0e636d82fda13f)SetTriggerFeedback()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.InputSystem.Input.SetTriggerFeedback | ( | byte | *leftTriggerPosition*, | |  |  | byte | *leftTriggerStrength*, | |  |  | byte | *rightTriggerPosition*, | |  |  | byte | *rightTriggerStrength* ) | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a34ab4b1be9c0b90d627f7bc4a626640d)SetTriggerWeaponEffect()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.InputSystem.Input.SetTriggerWeaponEffect | ( | byte | *leftStartPosition*, | |  |  | byte | *leftEnd\_position*, | |  |  | byte | *leftStrength*, | |  |  | byte | *rightStartPosition*, | |  |  | byte | *rightEndPosition*, | |  |  | byte | *rightStrength* ) | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a1921b7b4032b717cfcaace1b2495256d)SetTriggerVibration()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.InputSystem.Input.SetTriggerVibration | ( | float[] | *leftTriggerAmplitudes*, | |  |  | float[] | *leftTriggerFrequencies*, | |  |  | float[] | *leftTriggerDurations*, | |  |  | int | *numLeftTriggerElements*, | |  |  | float[] | *rightTriggerAmplitudes*, | |  |  | float[] | *rightTriggerFrequencies*, | |  |  | float[] | *rightTriggerDurations*, | |  |  | int | *numRightTriggerElements* ) | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#ab94b4ec20c71041928e1db5916197fe2)SetLightbarColor()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.InputSystem.Input.SetLightbarColor | ( | float | *red*, | |  |  | float | *green*, | |  |  | float | *blue* ) | | static |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a08510f29a5b4b4218a9860254ca1250f)NumberOfKeys
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.InputSystem.Input.NumberOfKeys = 256 | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a9847395ff31625ddfff5067a3e4874e5)OnGamepadActiveStateChanged
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.InputSystem.Input.OnGamepadActiveStateChanged | | static |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a2735d20f1acbb2e85f19d88791168ad1)OnControllerTypeChanged
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<[ControllerTypes](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5)> TaleWorlds.InputSystem.Input.OnControllerTypeChanged | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#afa650e8ad4c22a0a0d5d805fbf15b35c)InputState
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | InputState TaleWorlds.InputSystem.Input.InputState | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a938339e584229201f80a130f047026ab)DebugInput
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IInputContext](interface_tale_worlds_1_1_input_system_1_1_i_input_context.html) TaleWorlds.InputSystem.Input.DebugInput | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a026faf305a54bb882aa1041467f6ccef)InputManager
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [IInputManager](interface_tale_worlds_1_1_input_system_1_1_i_input_manager.html) TaleWorlds.InputSystem.Input.InputManager | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#af327f36afe9333f3e1c29b0fc0bdb2a9)Resolution
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.Input.Resolution | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a51c30068b57d671f8705f45f898329c8)DesktopResolution
---------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.Input.DesktopResolution | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a2cb6b7684213054fadde3524a96911dc)IsOnScreenKeyboardActive
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.Input.IsOnScreenKeyboardActive | | staticgetset |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#aeaddf8c1f158dcfac7785dde738d74bd)IsMouseActive
-----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.Input.IsMouseActive | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a3c5bd2173a9d29e10ac8891304bb2dac)IsControllerConnected
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.Input.IsControllerConnected | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a84d9bef312845120183c919565a2e015)IsGamepadActive
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.Input.IsGamepadActive | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a24ca5744290c4d0b0e29055347a6cff7)IsAnyTouchActive
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.Input.IsAnyTouchActive | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#abfc4a25d68c0b18eea5a61f657616e97)ControllerType
------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ControllerTypes](class_tale_worlds_1_1_input_system_1_1_input.html#ae2f71d4fdf2fe9159affb5afddec30c5) TaleWorlds.InputSystem.Input.ControllerType | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a0bfa58c96b1e70440970817843fbe8a9)MouseMoveX
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.InputSystem.Input.MouseMoveX | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a98e2296b95950e6b7f46629c4a365140)MouseMoveY
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.InputSystem.Input.MouseMoveY | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#ac22ca24afa136e1afae2cd09f7548731)GyroX
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.InputSystem.Input.GyroX | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#aaeca7bffeabb43388f9739f221472ef9)GyroY
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.InputSystem.Input.GyroY | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#ac039b2bdcc4e3fb7b0ab0dc508878999)GyroZ
---------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.InputSystem.Input.GyroZ | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a7b38a11da37e91dc83c06bdd763af430)MouseSensitivity
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.InputSystem.Input.MouseSensitivity | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a8da20d2422c81a46eebea521234d96dc)DeltaMouseScroll
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.InputSystem.Input.DeltaMouseScroll | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#af78367394492f348af14f1e1a98a3696)MousePositionRanged
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.Input.MousePositionRanged | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a4263272e367244bbcb1edb114438db75)MousePositionPixel
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.Input.MousePositionPixel | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a761a0ad15043b4e9020ef9238330253c)IsMousePositionUpdated
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.Input.IsMousePositionUpdated | | staticget |

[◆](class_tale_worlds_1_1_input_system_1_1_input.html#a463378f9232857c4320a272963d80d8f)IsMouseScrollChanged
------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.Input.IsMouseScrollChanged | | staticget |

