--- SOURCE: class_tale_worlds_1_1_input_system_1_1_input_state.html ---

TaleWorlds.InputSystem.InputState Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [InputState](class_tale_worlds_1_1_input_system_1_1_input_state.html#a95d7f7caa9a6ca4bff02ecda3687e1df) () |
| bool | [UpdateMousePosition](class_tale_worlds_1_1_input_system_1_1_input_state.html#a2d1753416682a0818b09f6aa72038ec7) (float mousePositionX, float mousePositionY) |
| bool | [UpdateMouseScroll](class_tale_worlds_1_1_input_system_1_1_input_state.html#a9947fd6d62f0791fe71a3c08853ddb7a) (float mouseScrollValue) |

|  |  |
| --- | --- |
| Properties | |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [NativeResolution](class_tale_worlds_1_1_input_system_1_1_input_state.html#ab946df5e5e607606e70bcbaa937f3ea6) `[get]` |
|  | Base resolution for all widgets. Widget system not depended on game's real resolution. So every contribution must be made according to native resolution. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [MousePositionRanged](class_tale_worlds_1_1_input_system_1_1_input_state.html#add0ed78221fdefc38e7e6395bb5a8bcf) `[get, set]` |
|  | Represents mouse position value in range [0,1] for game window. If game is not full screen and mouse is outside receiving values like -0.322 or 1.34 possible. Values will be still true according to game screen's width and height. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [OldMousePositionRanged](class_tale_worlds_1_1_input_system_1_1_input_state.html#a04ccc7aeabca9ff31b3a757fd2e2c824) `[get]` |
| bool | [MousePositionChanged](class_tale_worlds_1_1_input_system_1_1_input_state.html#a793f8759ecbf93a7ecca7061e739c45c) `[get]` |
|  | "Is mouse in a different position than the last tick call?" This value returns true if mousePositionRanged and oldMousePositionRanged are different. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [MousePositionPixel](class_tale_worlds_1_1_input_system_1_1_input_state.html#a4fba9e902603ee287c9e5fa621757ee7) `[get, set]` |
|  | Represents mouse position value in pixel coordinates according to nativeResolution. This value result of (mousePositionRanged \* NativeResolution) which gives pixel based position. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [OldMousePositionPixel](class_tale_worlds_1_1_input_system_1_1_input_state.html#ad6e35cd78da505b93cd799b6c677b298) `[get]` |
| float | [MouseScrollValue](class_tale_worlds_1_1_input_system_1_1_input_state.html#a678c20983bf8c28ea72bb2b60f7b2799) `[get]` |
|  | Represents mouse scroll value in range [?,?]. |
| bool | [MouseScrollChanged](class_tale_worlds_1_1_input_system_1_1_input_state.html#acc18083ebb7ae30d634b174afc97d55f) `[get]` |
|  | This value returns true if mouseScrollValue is different than the value of previous tick. |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_input_state.html#a95d7f7caa9a6ca4bff02ecda3687e1df)InputState()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.InputSystem.InputState.InputState | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_input_state.html#a2d1753416682a0818b09f6aa72038ec7)UpdateMousePosition()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputState.UpdateMousePosition | ( | float | *mousePositionX*, |
|  |  | float | *mousePositionY* ) |

[◆](class_tale_worlds_1_1_input_system_1_1_input_state.html#a9947fd6d62f0791fe71a3c08853ddb7a)UpdateMouseScroll()
-----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.InputSystem.InputState.UpdateMouseScroll | ( | float | *mouseScrollValue* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_input_system_1_1_input_state.html#ab946df5e5e607606e70bcbaa937f3ea6)NativeResolution
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.InputState.NativeResolution | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_input_state.html#add0ed78221fdefc38e7e6395bb5a8bcf)MousePositionRanged
-----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.InputState.MousePositionRanged | | getset |

[◆](class_tale_worlds_1_1_input_system_1_1_input_state.html#a04ccc7aeabca9ff31b3a757fd2e2c824)OldMousePositionRanged
--------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.InputState.OldMousePositionRanged | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_input_state.html#a793f8759ecbf93a7ecca7061e739c45c)MousePositionChanged
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.InputState.MousePositionChanged | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_input_state.html#a4fba9e902603ee287c9e5fa621757ee7)MousePositionPixel
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.InputState.MousePositionPixel | | getset |

[◆](class_tale_worlds_1_1_input_system_1_1_input_state.html#ad6e35cd78da505b93cd799b6c677b298)OldMousePositionPixel
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.InputSystem.InputState.OldMousePositionPixel | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_input_state.html#a678c20983bf8c28ea72bb2b60f7b2799)MouseScrollValue
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.InputSystem.InputState.MouseScrollValue | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_input_state.html#acc18083ebb7ae30d634b174afc97d55f)MouseScrollChanged
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.InputSystem.InputState.MouseScrollChanged | | get |

