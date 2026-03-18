--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html ---

TaleWorlds.GauntletUI.EventManager Class Reference|  |  |
| --- | --- |
| Public Member Functions | |
| void | [AddAfterFinalizedCallback](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a9b4c5de8b6a53bc0b05ef2139b8d0f8a) (Action callback) |
| void | [ClearFocus](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a0170929565edc2c4b4009bababd731f3) () |
| bool | [IsPointInsideUsableArea](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a0b40de279268e7578202aaec1fa28752) (Vector2 p) |
| bool | [FocusTest](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a692fee814a51d0f9ee680af15a4fa130) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) root) |
| void | [AddLateUpdateAction](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#ac5f9b5997f741ddf2fcd93b0739bc1aa) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) owner, Action< float > action, int order) |
| void | [SetHoveredView](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a6c8b5901afcce677ec3601cfa3f46554) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) view) |
| void | [UpdateLayout](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a0ddee590ddca3646e443be8c27e8d41b) () |
| bool | [GetIsHitThisFrame](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a79dcce2e8ea86ec4f6b3664d9bc507de) () |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static bool | [HitTest](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a40e3cb8bc9d993e71c4c05b5b9879c89) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget, Vector2 position) |

|  |  |
| --- | --- |
| Public Attributes | |
| [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) | [AreaRectangle](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a6a4311897a3b386c8ab1e67144f14b06) |
| Func< bool > | [OnGetIsHitThisFrame](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a4ca8e37c4e30a570dc8edeb86b124189) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MinParallelUpdateCount](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#aeee40b7229d5ebe958697e6474d44a48) = 64 |

|  |  |
| --- | --- |
| Properties | |
| float | [Time](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a6f0b187266a27999973414a25f971025) `[get]` |
|  | Time since the creation of [EventManager](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html) in seconds. |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [UsableArea](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a164a76dba649f29a1f8c43c3b5359882) = new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)(1, 1) `[get, set]` |
| float | [LeftUsableAreaStart](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a1c728d6e0c25e642522adb1e95f4e3f7) `[get]` |
| float | [TopUsableAreaStart](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a18f1e115763a7f1fc0bf133c90bc3646) `[get]` |
| Vector2 | [PageSize](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a4d2327518c61a20db90574adb2f407d6) `[get]` |
| static [TaleWorlds.Library.EventSystem.EventManager](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html) | [UIEventManager](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#af59c9c069d1c6dc405257af12872abae) `[get]` |
| Vector2 | [MousePositionInReferenceResolution](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a603062664caefb722f3a86ffa3b17a9b) `[get]` |
| bool | [IsControllerActive](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a763ce14b5c941b65de8263cfd4d219de) `[get]` |
| [UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) | [Context](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a78c5b25fe88b1c7930f714faeeac5b77) `[get]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [Root](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#af19e3582517f245fd5d3bd3029aa8832) `[get]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [FocusedWidget](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a682bf5b3e97d33c9a6bb8b8af4c890b0) `[get, set]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [HoveredView](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a20f0252cd536a32b4e18812d70d7ba77) `[get]` |
| List< [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) > | [MouseOveredViews](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#ac6043cf54a48043b6fe6e7a0e9476caa) `[get]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [DragHoveredView](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a75fbe5b650f20db50a1474ebe5bf1def) `[get]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [DraggedWidget](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#ad29ba19f9d3e79083a56d75bb35db72b) `[get]` |
| Vector2 | [DraggedWidgetPosition](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a3d8beb3917ede29c3de2574efa73ee62) `[get]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [LatestMouseDownWidget](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#afb48af6c66f7422014877b319f012c30) `[get]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [LatestMouseUpWidget](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a55492beb63c94f2d8a67c67301a86c30) `[get]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [LatestMouseAlternateDownWidget](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a5093c7eff226a49bb176ebea8c90e844) `[get]` |
| [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | [LatestMouseAlternateUpWidget](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a7289278d84f42b865bc88ef8d97cab85) `[get]` |
| Vector2 | [MousePosition](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#ad832f03767f9fe0eae1b0e19c9c02570) `[get]` |
| ulong | [LocalFrameNumber](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a36391d32429ff558fc66bcaccd28d82d) `[get]` |
| float | [DeltaMouseScroll](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a4186e961138153eb36f372582dda0faf) `[get]` |
| float | [RightStickVerticalScrollAmount](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#aa10ea635c68108983f88a03527782454) `[get]` |
| float | [RightStickHorizontalScrollAmount](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#ac956e8fe9004193d651e27d7556a445e) `[get]` |

|  |  |
| --- | --- |
| Events | |
| Action | [OnDragStarted](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a547d4e2c065282e4f470870cf3c0f017) |
| Action | [OnDragEnded](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a23e2566001814a1084a9bb8cbe5cd789) |
| Action | [OnFocusedWidgetChanged](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#ad5f97200744251647410313d4a39b5e1) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a9b4c5de8b6a53bc0b05ef2139b8d0f8a)AddAfterFinalizedCallback()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.EventManager.AddAfterFinalizedCallback | ( | Action | *callback* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a0170929565edc2c4b4009bababd731f3)ClearFocus()
------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.EventManager.ClearFocus | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a0b40de279268e7578202aaec1fa28752)IsPointInsideUsableArea()
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.EventManager.IsPointInsideUsableArea | ( | Vector2 | *p* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a40e3cb8bc9d993e71c4c05b5b9879c89)HitTest()
---------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | bool TaleWorlds.GauntletUI.EventManager.HitTest | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget*, | |  |  | Vector2 | *position* ) | | static |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a692fee814a51d0f9ee680af15a4fa130)FocusTest()
-----------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.EventManager.FocusTest | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *root* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#ac5f9b5997f741ddf2fcd93b0739bc1aa)AddLateUpdateAction()
---------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.EventManager.AddLateUpdateAction | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *owner*, |
|  |  | Action< float > | *action*, |
|  |  | int | *order* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a6c8b5901afcce677ec3601cfa3f46554)SetHoveredView()
----------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.EventManager.SetHoveredView | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *view* | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a0ddee590ddca3646e443be8c27e8d41b)UpdateLayout()
--------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.EventManager.UpdateLayout | ( |  | ) |  |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a79dcce2e8ea86ec4f6b3664d9bc507de)GetIsHitThisFrame()
-------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.GauntletUI.EventManager.GetIsHitThisFrame | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#aeee40b7229d5ebe958697e6474d44a48)MinParallelUpdateCount
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.GauntletUI.EventManager.MinParallelUpdateCount = 64 | | static |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a6a4311897a3b386c8ab1e67144f14b06)AreaRectangle
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Rectangle2D](struct_tale_worlds_1_1_two_dimension_1_1_rectangle2_d.html) TaleWorlds.GauntletUI.EventManager.AreaRectangle |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a4ca8e37c4e30a570dc8edeb86b124189)OnGetIsHitThisFrame
-------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Func<bool> TaleWorlds.GauntletUI.EventManager.OnGetIsHitThisFrame |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a6f0b187266a27999973414a25f971025)Time
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.EventManager.Time | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a164a76dba649f29a1f8c43c3b5359882)UsableArea
----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.GauntletUI.EventManager.UsableArea = new [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html)(1, 1) | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a1c728d6e0c25e642522adb1e95f4e3f7)LeftUsableAreaStart
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.EventManager.LeftUsableAreaStart | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a18f1e115763a7f1fc0bf133c90bc3646)TopUsableAreaStart
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.EventManager.TopUsableAreaStart | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a4d2327518c61a20db90574adb2f407d6)PageSize
--------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Vector2 TaleWorlds.GauntletUI.EventManager.PageSize | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#af59c9c069d1c6dc405257af12872abae)UIEventManager
--------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TaleWorlds.Library.EventSystem.EventManager](class_tale_worlds_1_1_library_1_1_event_system_1_1_event_manager.html) TaleWorlds.GauntletUI.EventManager.UIEventManager | | staticget |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a603062664caefb722f3a86ffa3b17a9b)MousePositionInReferenceResolution
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Vector2 TaleWorlds.GauntletUI.EventManager.MousePositionInReferenceResolution | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a763ce14b5c941b65de8263cfd4d219de)IsControllerActive
------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.GauntletUI.EventManager.IsControllerActive | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a78c5b25fe88b1c7930f714faeeac5b77)Context
-------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [UIContext](class_tale_worlds_1_1_gauntlet_u_i_1_1_u_i_context.html) TaleWorlds.GauntletUI.EventManager.Context | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#af19e3582517f245fd5d3bd3029aa8832)Root
----------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.EventManager.Root | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a682bf5b3e97d33c9a6bb8b8af4c890b0)FocusedWidget
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.EventManager.FocusedWidget | | getset |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a20f0252cd536a32b4e18812d70d7ba77)HoveredView
-----------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.EventManager.HoveredView | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#ac6043cf54a48043b6fe6e7a0e9476caa)MouseOveredViews
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | List<[Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html)> TaleWorlds.GauntletUI.EventManager.MouseOveredViews | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a75fbe5b650f20db50a1474ebe5bf1def)DragHoveredView
---------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.EventManager.DragHoveredView | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#ad29ba19f9d3e79083a56d75bb35db72b)DraggedWidget
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.EventManager.DraggedWidget | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a3d8beb3917ede29c3de2574efa73ee62)DraggedWidgetPosition
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Vector2 TaleWorlds.GauntletUI.EventManager.DraggedWidgetPosition | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#afb48af6c66f7422014877b319f012c30)LatestMouseDownWidget
---------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.EventManager.LatestMouseDownWidget | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a55492beb63c94f2d8a67c67301a86c30)LatestMouseUpWidget
-------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.EventManager.LatestMouseUpWidget | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a5093c7eff226a49bb176ebea8c90e844)LatestMouseAlternateDownWidget
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.EventManager.LatestMouseAlternateDownWidget | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a7289278d84f42b865bc88ef8d97cab85)LatestMouseAlternateUpWidget
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) TaleWorlds.GauntletUI.EventManager.LatestMouseAlternateUpWidget | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#ad832f03767f9fe0eae1b0e19c9c02570)MousePosition
-------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Vector2 TaleWorlds.GauntletUI.EventManager.MousePosition | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a36391d32429ff558fc66bcaccd28d82d)LocalFrameNumber
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | ulong TaleWorlds.GauntletUI.EventManager.LocalFrameNumber | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a4186e961138153eb36f372582dda0faf)DeltaMouseScroll
----------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.EventManager.DeltaMouseScroll | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#aa10ea635c68108983f88a03527782454)RightStickVerticalScrollAmount
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.EventManager.RightStickVerticalScrollAmount | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#ac956e8fe9004193d651e27d7556a445e)RightStickHorizontalScrollAmount
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.GauntletUI.EventManager.RightStickHorizontalScrollAmount | | get |

Event Documentation
-------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a547d4e2c065282e4f470870cf3c0f017)OnDragStarted
-------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.GauntletUI.EventManager.OnDragStarted |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#a23e2566001814a1084a9bb8cbe5cd789)OnDragEnded
-----------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.GauntletUI.EventManager.OnDragEnded |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_event_manager.html#ad5f97200744251647410313d4a39b5e1)OnFocusedWidgetChanged
----------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.GauntletUI.EventManager.OnFocusedWidgetChanged |

