--- SOURCE: class_tale_worlds_1_1_input_system_1_1_game_axis_key.html ---

TaleWorlds.InputSystem.GameAxisKey Class Reference|  |  |
| --- | --- |
| Public Types | |
| enum | [AxisType](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a15d369a2a815b8bbb31fea4d59758022) {     [X](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a15d369a2a815b8bbb31fea4d59758022a02129bb861061d1a052c592e2dc6b383) ,     [Y](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a15d369a2a815b8bbb31fea4d59758022a57cec4137b614c87cb4e24a3d003a3e0)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a82487f369f651e41c9498def6336b3e9) (string id, [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) axisKey, [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) positiveKey, [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) negativeKey, [AxisType](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a15d369a2a815b8bbb31fea4d59758022) type=[AxisType.X](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a15d369a2a815b8bbb31fea4d59758022a02129bb861061d1a052c592e2dc6b383)) |
| float | [GetAxisState](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a4fec5ec0a038759c00e1b4c847e558d4) (bool isKeysAllowed, bool isMouseButtonAllowed, bool isMouseWheelAllowed, bool isControllerAllowed) |
| override string | [ToString](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a0b8d209ac9f6454ac76ec8e0fa574372) () |

|  |  |
| --- | --- |
| Properties | |
| string | [Id](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a784dddc5760031a7d04f80fd31f5e242) `[get]` |
| [Key](class_tale_worlds_1_1_input_system_1_1_key.html) | [AxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a1459e5e86c88403062ccd83a3f0d893f) `[get]` |
| [Key](class_tale_worlds_1_1_input_system_1_1_key.html) | [DefaultAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a5d90c2ec9fba5d46271755d1f5cc2e9e) `[get]` |
| [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | [PositiveKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a3716c9f9bb8c5a2458d34563062737dc) `[get]` |
| [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | [NegativeKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#afa2ca5f1f584b3938bc7c3d8893a5d1a) `[get]` |
| [AxisType](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a15d369a2a815b8bbb31fea4d59758022) | [Type](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a375afe14842e6a774181d2df4550e7de) `[get]` |

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a15d369a2a815b8bbb31fea4d59758022)AxisType
--------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.InputSystem.GameAxisKey.AxisType](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a15d369a2a815b8bbb31fea4d59758022) |

| Enumerator | |
| --- | --- |
| X |  |
| Y |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a82487f369f651e41c9498def6336b3e9)GameAxisKey()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.InputSystem.GameAxisKey.GameAxisKey | ( | string | *id*, |
|  |  | [InputKey](namespace_tale_worlds_1_1_input_system.html#aaa2d7b4d2fdc240bb624b7fdb6f4ac50) | *axisKey*, |
|  |  | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *positiveKey*, |
|  |  | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *negativeKey*, |
|  |  | [AxisType](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a15d369a2a815b8bbb31fea4d59758022) | *type* = [AxisType::X](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a15d369a2a815b8bbb31fea4d59758022a02129bb861061d1a052c592e2dc6b383) ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a4fec5ec0a038759c00e1b4c847e558d4)GetAxisState()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| float TaleWorlds.InputSystem.GameAxisKey.GetAxisState | ( | bool | *isKeysAllowed*, |
|  |  | bool | *isMouseButtonAllowed*, |
|  |  | bool | *isMouseWheelAllowed*, |
|  |  | bool | *isControllerAllowed* ) |

[◆](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a0b8d209ac9f6454ac76ec8e0fa574372)ToString()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override string TaleWorlds.InputSystem.GameAxisKey.ToString | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a784dddc5760031a7d04f80fd31f5e242)Id
--------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.InputSystem.GameAxisKey.Id | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a1459e5e86c88403062ccd83a3f0d893f)AxisKey
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Key](class_tale_worlds_1_1_input_system_1_1_key.html) TaleWorlds.InputSystem.GameAxisKey.AxisKey | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a5d90c2ec9fba5d46271755d1f5cc2e9e)DefaultAxisKey
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Key](class_tale_worlds_1_1_input_system_1_1_key.html) TaleWorlds.InputSystem.GameAxisKey.DefaultAxisKey | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a3716c9f9bb8c5a2458d34563062737dc)PositiveKey
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) TaleWorlds.InputSystem.GameAxisKey.PositiveKey | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#afa2ca5f1f584b3938bc7c3d8893a5d1a)NegativeKey
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) TaleWorlds.InputSystem.GameAxisKey.NegativeKey | | get |

[◆](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a375afe14842e6a774181d2df4550e7de)Type
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [AxisType](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html#a15d369a2a815b8bbb31fea4d59758022) TaleWorlds.InputSystem.GameAxisKey.Type | | get |

