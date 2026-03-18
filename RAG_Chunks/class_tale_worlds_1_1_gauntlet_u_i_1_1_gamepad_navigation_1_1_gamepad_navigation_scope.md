--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html ---

TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0d9281dd522b3956c9db9ac23822ff99) () |
| void | [AddWidgetAtIndex](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#aa30b8b344194c676a81f3fefeb410354) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget, int index) |
| void | [AddWidget](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a79e274a4f3b2291d6530d5013f9fa74f) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget) |
| void | [RemoveWidget](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a466988b9988679b47ffb26ada31af0ae) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget) |
| void | [SetParentScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a5f8edfc199949e3318f56ef8a2538349) ([GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0d9281dd522b3956c9db9ac23822ff99) scope) |
| void | [ClearNavigatableWidgets](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ae6975231669ad2f8d91a7f353cf23b0b) () |

|  |  |
| --- | --- |
| Properties | |
| string | [ScopeID](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a38aa307d0173a882af5a74781d08d57b) = "DefaultScopeID" `[get, set]` |
| bool | [IsActiveScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a662eab4bc75c44f5a7d5b12cf6143da9) `[get]` |
| bool | [DoNotAutomaticallyFindChildren](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a9c27f1feee57f5950229a999c9bce782) `[get, set]` |
| [GamepadNavigationTypes](namespace_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation.html#a02b36a0aaf2c5436680800b8e8ef6386) | [ScopeMovements](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#acc74009b53cb29bad9c9cf1cc823a18f) `[get, set]` |
| [GamepadNavigationTypes](namespace_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation.html#a02b36a0aaf2c5436680800b8e8ef6386) | [AlternateScopeMovements](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#aeabbd81520efaf7242d1a0e89c58bb11) `[get, set]` |
| int | [AlternateMovementStepSize](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a33c339cadc0188c3bc8f64fff521c2b2) `[get, set]` |
| bool | [HasCircularMovement](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a519c1ab6003fbb8a8d6575d754c241cc) `[get, set]` |
| ReadOnlyCollection< [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) > | [NavigatableWidgets](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ab4cfb5589aecf896e158bfa673d366e1) `[get]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [ParentWidget](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#af5fda39d5e381a03981b73fc3c544f18) `[get, set]` |
| int | [LatestNavigationElementIndex](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ad3f3f9e296840fc2de8fc1b04cb519ce) `[get, set]` |
| bool | [DoNotAutoGainNavigationOnInit](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ae7efa5e50749c55bd43c5092001ae3dd) `[get, set]` |
| bool | [ForceGainNavigationBasedOnDirection](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a4ac76d9e72dc979728de8ded54246a37) `[get, set]` |
| bool | [ForceGainNavigationOnClosestChild](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a791f2e90240f27fb33a77fbd31200cee) `[get, set]` |
| bool | [ForceGainNavigationOnFirstChild](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a5b42842cfaf7f92eab4609f2b24c5b30) `[get, set]` |
| bool | [NavigateFromScopeEdges](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0347504ad7c41485233c57967361670d) `[get, set]` |
| bool | [UseDiscoveryAreaAsScopeEdges](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ad8a70199dfe4cdddf2739340b9ad590e) `[get, set]` |
| bool | [DoNotAutoNavigateAfterSort](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a2ffaf4ebc0be5155de0df3ffc64dc4f5) `[get, set]` |
| bool | [FollowMobileTargets](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#afa0b4aa9e86da57f36b3ac363e044dca) `[get, set]` |
| bool | [DoNotAutoCollectChildScopes](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a75bb0dfe6dec9fee491988bf884a1402) `[get, set]` |
| bool | [IsDefaultNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a7894062801590070b4bc175cb69450b5) `[get, set]` |
| float | [ExtendDiscoveryAreaRight](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0a01581cb8280a4c4722ca2a43432bac) `[get, set]` |
| float | [ExtendDiscoveryAreaTop](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#af1296c1cbc29a19f25c41f0851e8a54c) `[get, set]` |
| float | [ExtendDiscoveryAreaBottom](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a8b83512347214a565fa8412d6f4c63e9) `[get, set]` |
| float | [ExtendDiscoveryAreaLeft](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a82aa84231e18a1b7882dc8556dcb14b4) `[get, set]` |
| float | [ExtendChildrenCursorAreaLeft](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a7b0e9cc2042d928b19052d0cc834e6f5) `[get, set]` |
| float | [ExtendChildrenCursorAreaRight](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ab93612cee210ab9b571c06136db19d85) `[get, set]` |
| float | [ExtendChildrenCursorAreaTop](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a718fda7dda004979ad94c7af60251127) `[get, set]` |
| float | [ExtendChildrenCursorAreaBottom](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a9ba5814dda7668172bf1d0ca18871590) `[get, set]` |
| float | [DiscoveryAreaOffsetX](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a72e081822ab0b243b34cf50848ca75ad) `[get, set]` |
| float | [DiscoveryAreaOffsetY](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a7b8ebb9ad323fe645a5ffdb0299b7284) `[get, set]` |
| bool | [IsEnabled](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#aa86341fbbe2f790821b6fa7a65ad20cc) `[get, set]` |
| bool | [IsDisabled](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a453418086fcb7dd9e9f9284e5aab2943) `[get, set]` |
| string | [UpNavigationScopeID](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ac276514d3b16990a29426be60a3083af) `[get, set]` |
| string | [RightNavigationScopeID](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a45a05db3e10a748041da994214d3b671) `[get, set]` |
| string | [DownNavigationScopeID](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a2fa50fbaa60d46d9993e78ccd9074e76) `[get, set]` |
| string | [LeftNavigationScopeID](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a5f52573fe8bdc9db8a1d66881ddf44b8) `[get, set]` |
| [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0d9281dd522b3956c9db9ac23822ff99) | [UpNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a547e564abd1124869ec13cbc23ed296d) `[get, set]` |
| [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0d9281dd522b3956c9db9ac23822ff99) | [RightNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#afd4dd8f1373ba5efaca69a42826960a7) `[get, set]` |
| [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0d9281dd522b3956c9db9ac23822ff99) | [DownNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#aeb4973f864461e01de5225e824962b78) `[get, set]` |
| [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0d9281dd522b3956c9db9ac23822ff99) | [LeftNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a1a6168a3102fd0fd97f2f688c0fbc8e8) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0d9281dd522b3956c9db9ac23822ff99)GamepadNavigationScope()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.GamepadNavigationScope | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#aa30b8b344194c676a81f3fefeb410354)AddWidgetAtIndex()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.AddWidgetAtIndex | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget*, |
|  |  | int | *index* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a79e274a4f3b2291d6530d5013f9fa74f)AddWidget()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.AddWidget | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a466988b9988679b47ffb26ada31af0ae)RemoveWidget()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.RemoveWidget | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a5f8edfc199949e3318f56ef8a2538349)SetParentScope()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.SetParentScope | ( | [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0d9281dd522b3956c9db9ac23822ff99) | *scope* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ae6975231669ad2f8d91a7f353cf23b0b)ClearNavigatableWidgets()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ClearNavigatableWidgets | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a38aa307d0173a882af5a74781d08d57b)ScopeID
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ScopeID = "DefaultScopeID" | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a662eab4bc75c44f5a7d5b12cf6143da9)IsActiveScope
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.IsActiveScope | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a9c27f1feee57f5950229a999c9bce782)DoNotAutomaticallyFindChildren
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.DoNotAutomaticallyFindChildren | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#acc74009b53cb29bad9c9cf1cc823a18f)ScopeMovements
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GamepadNavigationTypes](namespace_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation.html#a02b36a0aaf2c5436680800b8e8ef6386) TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ScopeMovements | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#aeabbd81520efaf7242d1a0e89c58bb11)AlternateScopeMovements
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GamepadNavigationTypes](namespace_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation.html#a02b36a0aaf2c5436680800b8e8ef6386) TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.AlternateScopeMovements | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a33c339cadc0188c3bc8f64fff521c2b2)AlternateMovementStepSize
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.AlternateMovementStepSize | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a519c1ab6003fbb8a8d6575d754c241cc)HasCircularMovement
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.HasCircularMovement | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ab4cfb5589aecf896e158bfa673d366e1)NavigatableWidgets
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ReadOnlyCollection<[Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html)> TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.NavigatableWidgets | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#af5fda39d5e381a03981b73fc3c544f18)ParentWidget
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ParentWidget | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ad3f3f9e296840fc2de8fc1b04cb519ce)LatestNavigationElementIndex
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.LatestNavigationElementIndex | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ae7efa5e50749c55bd43c5092001ae3dd)DoNotAutoGainNavigationOnInit
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.DoNotAutoGainNavigationOnInit | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a4ac76d9e72dc979728de8ded54246a37)ForceGainNavigationBasedOnDirection
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ForceGainNavigationBasedOnDirection | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a791f2e90240f27fb33a77fbd31200cee)ForceGainNavigationOnClosestChild
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ForceGainNavigationOnClosestChild | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a5b42842cfaf7f92eab4609f2b24c5b30)ForceGainNavigationOnFirstChild
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ForceGainNavigationOnFirstChild | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0347504ad7c41485233c57967361670d)NavigateFromScopeEdges
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.NavigateFromScopeEdges | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ad8a70199dfe4cdddf2739340b9ad590e)UseDiscoveryAreaAsScopeEdges
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.UseDiscoveryAreaAsScopeEdges | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a2ffaf4ebc0be5155de0df3ffc64dc4f5)DoNotAutoNavigateAfterSort
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.DoNotAutoNavigateAfterSort | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#afa0b4aa9e86da57f36b3ac363e044dca)FollowMobileTargets
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.FollowMobileTargets | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a75bb0dfe6dec9fee491988bf884a1402)DoNotAutoCollectChildScopes
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.DoNotAutoCollectChildScopes | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a7894062801590070b4bc175cb69450b5)IsDefaultNavigationScope
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.IsDefaultNavigationScope | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0a01581cb8280a4c4722ca2a43432bac)ExtendDiscoveryAreaRight
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ExtendDiscoveryAreaRight | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#af1296c1cbc29a19f25c41f0851e8a54c)ExtendDiscoveryAreaTop
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ExtendDiscoveryAreaTop | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a8b83512347214a565fa8412d6f4c63e9)ExtendDiscoveryAreaBottom
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ExtendDiscoveryAreaBottom | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a82aa84231e18a1b7882dc8556dcb14b4)ExtendDiscoveryAreaLeft
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ExtendDiscoveryAreaLeft | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a7b0e9cc2042d928b19052d0cc834e6f5)ExtendChildrenCursorAreaLeft
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ExtendChildrenCursorAreaLeft | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ab93612cee210ab9b571c06136db19d85)ExtendChildrenCursorAreaRight
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ExtendChildrenCursorAreaRight | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a718fda7dda004979ad94c7af60251127)ExtendChildrenCursorAreaTop
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ExtendChildrenCursorAreaTop | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a9ba5814dda7668172bf1d0ca18871590)ExtendChildrenCursorAreaBottom
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.ExtendChildrenCursorAreaBottom | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a72e081822ab0b243b34cf50848ca75ad)DiscoveryAreaOffsetX
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.DiscoveryAreaOffsetX | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a7b8ebb9ad323fe645a5ffdb0299b7284)DiscoveryAreaOffsetY
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.DiscoveryAreaOffsetY | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#aa86341fbbe2f790821b6fa7a65ad20cc)IsEnabled
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.IsEnabled | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a453418086fcb7dd9e9f9284e5aab2943)IsDisabled
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.IsDisabled | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#ac276514d3b16990a29426be60a3083af)UpNavigationScopeID
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.UpNavigationScopeID | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a45a05db3e10a748041da994214d3b671)RightNavigationScopeID
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.RightNavigationScopeID | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a2fa50fbaa60d46d9993e78ccd9074e76)DownNavigationScopeID
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.DownNavigationScopeID | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a5f52573fe8bdc9db8a1d66881ddf44b8)LeftNavigationScopeID
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.LeftNavigationScopeID | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a547e564abd1124869ec13cbc23ed296d)UpNavigationScope
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0d9281dd522b3956c9db9ac23822ff99) TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.UpNavigationScope | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#afd4dd8f1373ba5efaca69a42826960a7)RightNavigationScope
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0d9281dd522b3956c9db9ac23822ff99) TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.RightNavigationScope | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#aeb4973f864461e01de5225e824962b78)DownNavigationScope
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0d9281dd522b3956c9db9ac23822ff99) TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.DownNavigationScope | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a1a6168a3102fd0fd97f2f688c0fbc8e8)LeftNavigationScope
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GamepadNavigationScope](class_tale_worlds_1_1_gauntlet_u_i_1_1_gamepad_navigation_1_1_gamepad_navigation_scope.html#a0d9281dd522b3956c9db9ac23822ff99) TaleWorlds.GauntletUI.GamepadNavigation.GamepadNavigationScope.LeftNavigationScope | | getset |

