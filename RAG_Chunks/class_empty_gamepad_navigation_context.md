--- SOURCE: class_empty_gamepad_navigation_context.html ---

EmptyGamepadNavigationContext Class ReferenceInherits [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [AddForcedScopeCollection](class_empty_gamepad_navigation_context.html#aea989aeefe2bb2f5ceb18e32b7a45d8e) ([GamepadNavigationForcedScopeCollection](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_forced_scope_collection.html) collection) |
| void | [AddNavigationScope](class_empty_gamepad_navigation_context.html#a6307d5704b2b2d2c2461b43c1bcc0905) ([GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) scope, bool initialize) |
| void | [GainNavigationAfterFrames](class_empty_gamepad_navigation_context.html#a648678a2320832f8b23ce68c02513210) (int frameCount, Func< bool > predicate) |
| void | [GainNavigationAfterTime](class_empty_gamepad_navigation_context.html#a774f19cfedcd7e7b1922b39a250b6f79) (float seconds, Func< bool > predicate) |
| void | [OnFinalize](class_empty_gamepad_navigation_context.html#a6351b1ff940f627d800a29e5fb5ca19a) () |
| bool | [GetIsBlockedAtPosition](class_empty_gamepad_navigation_context.html#a9ae2bc69bbae0d47c70430ab17296b9f) (Vector2 position) |
| int | [GetLastScreenOrder](class_empty_gamepad_navigation_context.html#a6386374c3f669145022f311f43a985a9) () |
| bool | [HasNavigationScope](class_empty_gamepad_navigation_context.html#aa0777b1f492372c6aac19f6e7c91cdb4) ([GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) scope) |
| bool | [HasNavigationScope](class_empty_gamepad_navigation_context.html#aa31ee6dbabfa2a920daaa4738a8e978b) (Func< [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html), bool > predicate) |
| bool | [IsAvailableForNavigation](class_empty_gamepad_navigation_context.html#a2bf1e5a1ce624a369019752baf720833) () |
| void | [OnGainNavigation](class_empty_gamepad_navigation_context.html#a9b2dc10da959ff242bedd0ba88c7a9eb) () |
| void | [OnMovieLoaded](class_empty_gamepad_navigation_context.html#ae2c96e31a5ddb7620aecf976e9650665) (string movieName) |
| void | [OnMovieReleased](class_empty_gamepad_navigation_context.html#a8c07075c4ba50794011196b88145ab06) (string movieName) |
| void | [OnWidgetNavigationIndexUpdated](class_empty_gamepad_navigation_context.html#a5f2f01178e6559ce31b6f650c4cf940d) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget) |
| void | [OnWidgetNavigationStatusChanged](class_empty_gamepad_navigation_context.html#ad92d7b5dbdb1d9fb8f268c5bf3fa53b1) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget) |
| void | [OnWidgetUsedNavigationMovementsUpdated](class_empty_gamepad_navigation_context.html#acf774d16e75289681bac5457b50de13b) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget) |
| void | [RemoveForcedScopeCollection](class_empty_gamepad_navigation_context.html#a59bc4ef6cd1007b456f42f95995c89c5) ([GamepadNavigationForcedScopeCollection](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_forced_scope_collection.html) collection) |
| void | [RemoveNavigationScope](class_empty_gamepad_navigation_context.html#ad2612690f32134be956c9571480c31c7) ([GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) scope) |

Member Function Documentation
-----------------------------

[◆](class_empty_gamepad_navigation_context.html#aea989aeefe2bb2f5ceb18e32b7a45d8e)AddForcedScopeCollection()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void EmptyGamepadNavigationContext.AddForcedScopeCollection | ( | [GamepadNavigationForcedScopeCollection](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_forced_scope_collection.html) | *collection* | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#a8331f4e23da106c725208311a45cac39).

[◆](class_empty_gamepad_navigation_context.html#a6307d5704b2b2d2c2461b43c1bcc0905)AddNavigationScope()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void EmptyGamepadNavigationContext.AddNavigationScope | ( | [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) | *scope*, |
|  |  | bool | *initialize* ) |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#ad0ee7937a912f08bd3b1ba5d66adbcfa).

[◆](class_empty_gamepad_navigation_context.html#a648678a2320832f8b23ce68c02513210)GainNavigationAfterFrames()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void EmptyGamepadNavigationContext.GainNavigationAfterFrames | ( | int | *frameCount*, |
|  |  | Func< bool > | *predicate* ) |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#a2f57f1b084c53b92d46ee4d326ea00d0).

[◆](class_empty_gamepad_navigation_context.html#a774f19cfedcd7e7b1922b39a250b6f79)GainNavigationAfterTime()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void EmptyGamepadNavigationContext.GainNavigationAfterTime | ( | float | *seconds*, |
|  |  | Func< bool > | *predicate* ) |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#a72facd58f3f53397b97bc11d1eeda25d).

[◆](class_empty_gamepad_navigation_context.html#a6351b1ff940f627d800a29e5fb5ca19a)OnFinalize()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void EmptyGamepadNavigationContext.OnFinalize | ( |  | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#a7a0b438fe10cf6ffa2fc961f60d74a9b).

[◆](class_empty_gamepad_navigation_context.html#a9ae2bc69bbae0d47c70430ab17296b9f)GetIsBlockedAtPosition()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool EmptyGamepadNavigationContext.GetIsBlockedAtPosition | ( | Vector2 | *position* | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#a60af982020d43a5bc09cfaa637626c15).

[◆](class_empty_gamepad_navigation_context.html#a6386374c3f669145022f311f43a985a9)GetLastScreenOrder()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int EmptyGamepadNavigationContext.GetLastScreenOrder | ( |  | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#ac7b35dde2b64c0d17c0968aa4f1a61c0).

[◆](class_empty_gamepad_navigation_context.html#aa0777b1f492372c6aac19f6e7c91cdb4)HasNavigationScope() [1/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool EmptyGamepadNavigationContext.HasNavigationScope | ( | [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) | *scope* | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#a704d78aacdb56ab8737a1e9258446c18).

[◆](class_empty_gamepad_navigation_context.html#aa31ee6dbabfa2a920daaa4738a8e978b)HasNavigationScope() [2/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool EmptyGamepadNavigationContext.HasNavigationScope | ( | Func< [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html), bool > | *predicate* | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#a20e72efdc4bbbe39a25f51b30e3b38af).

[◆](class_empty_gamepad_navigation_context.html#a2bf1e5a1ce624a369019752baf720833)IsAvailableForNavigation()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool EmptyGamepadNavigationContext.IsAvailableForNavigation | ( |  | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#aea9ad07d9da18dedcad2b4ce6aebb3fc).

[◆](class_empty_gamepad_navigation_context.html#a9b2dc10da959ff242bedd0ba88c7a9eb)OnGainNavigation()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void EmptyGamepadNavigationContext.OnGainNavigation | ( |  | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#a1d228827de5c4471fb6998429315afd4).

[◆](class_empty_gamepad_navigation_context.html#ae2c96e31a5ddb7620aecf976e9650665)OnMovieLoaded()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void EmptyGamepadNavigationContext.OnMovieLoaded | ( | string | *movieName* | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#a1ae9a3e09b74f4462ee7476a24b4a61c).

[◆](class_empty_gamepad_navigation_context.html#a8c07075c4ba50794011196b88145ab06)OnMovieReleased()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void EmptyGamepadNavigationContext.OnMovieReleased | ( | string | *movieName* | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#aa1d52acea452189744e1a19715b368db).

[◆](class_empty_gamepad_navigation_context.html#a5f2f01178e6559ce31b6f650c4cf940d)OnWidgetNavigationIndexUpdated()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void EmptyGamepadNavigationContext.OnWidgetNavigationIndexUpdated | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget* | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#a04f128bc9c5e096e1e575e6782599fa6).

[◆](class_empty_gamepad_navigation_context.html#ad92d7b5dbdb1d9fb8f268c5bf3fa53b1)OnWidgetNavigationStatusChanged()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void EmptyGamepadNavigationContext.OnWidgetNavigationStatusChanged | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget* | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#ab95b4d1c4161c28b317da7b089ec2a03).

[◆](class_empty_gamepad_navigation_context.html#acf774d16e75289681bac5457b50de13b)OnWidgetUsedNavigationMovementsUpdated()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void EmptyGamepadNavigationContext.OnWidgetUsedNavigationMovementsUpdated | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget* | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#ac4c8d7caef84c2876d15c13f97ba1022).

[◆](class_empty_gamepad_navigation_context.html#a59bc4ef6cd1007b456f42f95995c89c5)RemoveForcedScopeCollection()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void EmptyGamepadNavigationContext.RemoveForcedScopeCollection | ( | [GamepadNavigationForcedScopeCollection](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_forced_scope_collection.html) | *collection* | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#a20efaa0242243d75b3333fa812abc0e9).

[◆](class_empty_gamepad_navigation_context.html#ad2612690f32134be956c9571480c31c7)RemoveNavigationScope()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void EmptyGamepadNavigationContext.RemoveNavigationScope | ( | [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) | *scope* | ) |  |

Implements [IGamepadNavigationContext](interface_i_gamepad_navigation_context.html#a1b7475a014fc4d06fc95e9617046c4ec).

