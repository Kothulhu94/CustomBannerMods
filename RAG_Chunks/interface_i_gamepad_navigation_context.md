--- SOURCE: interface_i_gamepad_navigation_context.html ---

IGamepadNavigationContext Interface ReferenceInherited by [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html), and [GauntletGamepadNavigationContext](class_gauntlet_gamepad_navigation_context.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [OnFinalize](interface_i_gamepad_navigation_context.html#a7a0b438fe10cf6ffa2fc961f60d74a9b) () |
| bool | [GetIsBlockedAtPosition](interface_i_gamepad_navigation_context.html#a60af982020d43a5bc09cfaa637626c15) (Vector2 position) |
| int | [GetLastScreenOrder](interface_i_gamepad_navigation_context.html#ac7b35dde2b64c0d17c0968aa4f1a61c0) () |
| bool | [IsAvailableForNavigation](interface_i_gamepad_navigation_context.html#aea9ad07d9da18dedcad2b4ce6aebb3fc) () |
| void | [OnWidgetUsedNavigationMovementsUpdated](interface_i_gamepad_navigation_context.html#ac4c8d7caef84c2876d15c13f97ba1022) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget) |
| void | [OnGainNavigation](interface_i_gamepad_navigation_context.html#a1d228827de5c4471fb6998429315afd4) () |
| void | [GainNavigationAfterFrames](interface_i_gamepad_navigation_context.html#a2f57f1b084c53b92d46ee4d326ea00d0) (int frameCount, Func< bool > predicate) |
| void | [GainNavigationAfterTime](interface_i_gamepad_navigation_context.html#a72facd58f3f53397b97bc11d1eeda25d) (float seconds, Func< bool > predicate) |
| void | [OnWidgetNavigationStatusChanged](interface_i_gamepad_navigation_context.html#ab95b4d1c4161c28b317da7b089ec2a03) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget) |
| void | [OnWidgetNavigationIndexUpdated](interface_i_gamepad_navigation_context.html#a04f128bc9c5e096e1e575e6782599fa6) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget) |
| void | [AddNavigationScope](interface_i_gamepad_navigation_context.html#ad0ee7937a912f08bd3b1ba5d66adbcfa) ([GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) scope, bool initialize) |
| void | [RemoveNavigationScope](interface_i_gamepad_navigation_context.html#a1b7475a014fc4d06fc95e9617046c4ec) ([GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) scope) |
| void | [AddForcedScopeCollection](interface_i_gamepad_navigation_context.html#a8331f4e23da106c725208311a45cac39) ([GamepadNavigationForcedScopeCollection](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_forced_scope_collection.html) collection) |
| void | [RemoveForcedScopeCollection](interface_i_gamepad_navigation_context.html#a20efaa0242243d75b3333fa812abc0e9) ([GamepadNavigationForcedScopeCollection](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_forced_scope_collection.html) collection) |
| bool | [HasNavigationScope](interface_i_gamepad_navigation_context.html#a704d78aacdb56ab8737a1e9258446c18) ([GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) scope) |
| bool | [HasNavigationScope](interface_i_gamepad_navigation_context.html#a20e72efdc4bbbe39a25f51b30e3b38af) (Func< [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html), bool > predicate) |
| void | [OnMovieLoaded](interface_i_gamepad_navigation_context.html#a1ae9a3e09b74f4462ee7476a24b4a61c) (string movieName) |
| void | [OnMovieReleased](interface_i_gamepad_navigation_context.html#aa1d52acea452189744e1a19715b368db) (string movieName) |

Member Function Documentation
-----------------------------

[◆](interface_i_gamepad_navigation_context.html#a7a0b438fe10cf6ffa2fc961f60d74a9b)OnFinalize()
----------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void IGamepadNavigationContext.OnFinalize | ( |  | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#a6351b1ff940f627d800a29e5fb5ca19a).

[◆](interface_i_gamepad_navigation_context.html#a60af982020d43a5bc09cfaa637626c15)GetIsBlockedAtPosition()
----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool IGamepadNavigationContext.GetIsBlockedAtPosition | ( | Vector2 | *position* | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#a9ae2bc69bbae0d47c70430ab17296b9f).

[◆](interface_i_gamepad_navigation_context.html#ac7b35dde2b64c0d17c0968aa4f1a61c0)GetLastScreenOrder()
------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| int IGamepadNavigationContext.GetLastScreenOrder | ( |  | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#a6386374c3f669145022f311f43a985a9).

[◆](interface_i_gamepad_navigation_context.html#aea9ad07d9da18dedcad2b4ce6aebb3fc)IsAvailableForNavigation()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool IGamepadNavigationContext.IsAvailableForNavigation | ( |  | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#a2bf1e5a1ce624a369019752baf720833).

[◆](interface_i_gamepad_navigation_context.html#ac4c8d7caef84c2876d15c13f97ba1022)OnWidgetUsedNavigationMovementsUpdated()
--------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void IGamepadNavigationContext.OnWidgetUsedNavigationMovementsUpdated | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget* | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#acf774d16e75289681bac5457b50de13b).

[◆](interface_i_gamepad_navigation_context.html#a1d228827de5c4471fb6998429315afd4)OnGainNavigation()
----------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void IGamepadNavigationContext.OnGainNavigation | ( |  | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#a9b2dc10da959ff242bedd0ba88c7a9eb).

[◆](interface_i_gamepad_navigation_context.html#a2f57f1b084c53b92d46ee4d326ea00d0)GainNavigationAfterFrames()
-------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void IGamepadNavigationContext.GainNavigationAfterFrames | ( | int | *frameCount*, |
|  |  | Func< bool > | *predicate* ) |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#a648678a2320832f8b23ce68c02513210).

[◆](interface_i_gamepad_navigation_context.html#a72facd58f3f53397b97bc11d1eeda25d)GainNavigationAfterTime()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void IGamepadNavigationContext.GainNavigationAfterTime | ( | float | *seconds*, |
|  |  | Func< bool > | *predicate* ) |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#a774f19cfedcd7e7b1922b39a250b6f79).

[◆](interface_i_gamepad_navigation_context.html#ab95b4d1c4161c28b317da7b089ec2a03)OnWidgetNavigationStatusChanged()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void IGamepadNavigationContext.OnWidgetNavigationStatusChanged | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget* | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#ad92d7b5dbdb1d9fb8f268c5bf3fa53b1).

[◆](interface_i_gamepad_navigation_context.html#a04f128bc9c5e096e1e575e6782599fa6)OnWidgetNavigationIndexUpdated()
------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void IGamepadNavigationContext.OnWidgetNavigationIndexUpdated | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget* | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#a5f2f01178e6559ce31b6f650c4cf940d).

[◆](interface_i_gamepad_navigation_context.html#ad0ee7937a912f08bd3b1ba5d66adbcfa)AddNavigationScope()
------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void IGamepadNavigationContext.AddNavigationScope | ( | [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) | *scope*, |
|  |  | bool | *initialize* ) |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#a6307d5704b2b2d2c2461b43c1bcc0905).

[◆](interface_i_gamepad_navigation_context.html#a1b7475a014fc4d06fc95e9617046c4ec)RemoveNavigationScope()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void IGamepadNavigationContext.RemoveNavigationScope | ( | [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) | *scope* | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#ad2612690f32134be956c9571480c31c7).

[◆](interface_i_gamepad_navigation_context.html#a8331f4e23da106c725208311a45cac39)AddForcedScopeCollection()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void IGamepadNavigationContext.AddForcedScopeCollection | ( | [GamepadNavigationForcedScopeCollection](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_forced_scope_collection.html) | *collection* | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#aea989aeefe2bb2f5ceb18e32b7a45d8e).

[◆](interface_i_gamepad_navigation_context.html#a20efaa0242243d75b3333fa812abc0e9)RemoveForcedScopeCollection()
---------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void IGamepadNavigationContext.RemoveForcedScopeCollection | ( | [GamepadNavigationForcedScopeCollection](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_forced_scope_collection.html) | *collection* | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#a59bc4ef6cd1007b456f42f95995c89c5).

[◆](interface_i_gamepad_navigation_context.html#a704d78aacdb56ab8737a1e9258446c18)HasNavigationScope() [1/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool IGamepadNavigationContext.HasNavigationScope | ( | [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html) | *scope* | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#aa0777b1f492372c6aac19f6e7c91cdb4).

[◆](interface_i_gamepad_navigation_context.html#a20e72efdc4bbbe39a25f51b30e3b38af)HasNavigationScope() [2/2]
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool IGamepadNavigationContext.HasNavigationScope | ( | Func< [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html), bool > | *predicate* | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#aa31ee6dbabfa2a920daaa4738a8e978b).

[◆](interface_i_gamepad_navigation_context.html#a1ae9a3e09b74f4462ee7476a24b4a61c)OnMovieLoaded()
-------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void IGamepadNavigationContext.OnMovieLoaded | ( | string | *movieName* | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#ae2c96e31a5ddb7620aecf976e9650665).

[◆](interface_i_gamepad_navigation_context.html#aa1d52acea452189744e1a19715b368db)OnMovieReleased()
---------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void IGamepadNavigationContext.OnMovieReleased | ( | string | *movieName* | ) |  |

Implemented in [EmptyGamepadNavigationContext](class_empty_gamepad_navigation_context.html#a8c07075c4ba50794011196b88145ab06).

