--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html ---

TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| bool | [TryNavigateTo](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a85e6655c0346e2a126d8b038500edec8) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget) |
| bool | [TryNavigateTo](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a8ef602eeab69dc30271fc12fe29125d4) ([GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) scope) |
| void | [OnFinalize](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a479dd7531bc980c51cb66b2f6053ca56) () |
| void | [Update](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#ae2722ac096118412856af924faea29a5) (float dt) |
| void | [SetAllDirty](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a8fbb155da525852975d913da992d5f6a) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static void | [Initialize](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a52881c6ba94d2190809ec24737ec29ac) () |

|  |  |
| --- | --- |
| Properties | |
| static GauntletGamepadNavigationManager | [Instance](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a7bba17a55018eda25515cba16c0eacc6) `[get]` |
| bool | [IsTouchpadMouseEnabled](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a62b80da201cc961786cfcb9b22c92d9e) `[get, set]` |
| bool | [IsFollowingMobileTarget](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a0814d6dd3109a0bd2b2da75eecc72f4f) `[get]` |
| bool | [IsHoldingDpadKeysForNavigation](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#ab81b72dbd6cb33a13c3426a6b6c0260d) `[get]` |
| bool | [IsCursorMovingForNavigation](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#ae961f9fc8e278c690502892517e277c5) `[get]` |
| bool | [IsInWrapMovement](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a122ae5807796d2fc729b30ed66728057) `[get]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [LastTargetedWidget](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#afe3ffb002e99d372f5886ea6465f54cf) `[get]` |
| bool | [TargetedWidgetHasAction](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a7349739907dae1e27cc9f43fd308e30f) `[get]` |
| bool | [AnyWidgetUsingNavigation](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#aa104098899dadf17cf063955e71899ec) `[get]` |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a52881c6ba94d2190809ec24737ec29ac)Initialize()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.Initialize | ( |  | ) |  | | static |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a85e6655c0346e2a126d8b038500edec8)TryNavigateTo() [1/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.TryNavigateTo | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a8ef602eeab69dc30271fc12fe29125d4)TryNavigateTo() [2/2]
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.TryNavigateTo | ( | [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) | *scope* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a479dd7531bc980c51cb66b2f6053ca56)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.OnFinalize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#ae2722ac096118412856af924faea29a5)Update()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.Update | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a8fbb155da525852975d913da992d5f6a)SetAllDirty()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.SetAllDirty | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a7bba17a55018eda25515cba16c0eacc6)Instance
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | GauntletGamepadNavigationManager TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.Instance | | staticget |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a62b80da201cc961786cfcb9b22c92d9e)IsTouchpadMouseEnabled
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.IsTouchpadMouseEnabled | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a0814d6dd3109a0bd2b2da75eecc72f4f)IsFollowingMobileTarget
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.IsFollowingMobileTarget | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#ab81b72dbd6cb33a13c3426a6b6c0260d)IsHoldingDpadKeysForNavigation
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.IsHoldingDpadKeysForNavigation | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#ae961f9fc8e278c690502892517e277c5)IsCursorMovingForNavigation
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.IsCursorMovingForNavigation | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a122ae5807796d2fc729b30ed66728057)IsInWrapMovement
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.IsInWrapMovement | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#afe3ffb002e99d372f5886ea6465f54cf)LastTargetedWidget
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.LastTargetedWidget | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#a7349739907dae1e27cc9f43fd308e30f)TargetedWidgetHasAction
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.TargetedWidgetHasAction | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gauntlet_gamepad_navigation_manager.html#aa104098899dadf17cf063955e71899ec)AnyWidgetUsingNavigation
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GauntletGamepadNavigationManager.AnyWidgetUsingNavigation | | get |

