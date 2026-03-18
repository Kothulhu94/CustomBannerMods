--- SOURCE: class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html ---

TaleWorlds.GauntletUI.Layout.StackLayout Class ReferenceInherits [TaleWorlds.GauntletUI.Layout.ILayout](interface_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_i_layout.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [StackLayout](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#a28fcd2155fc1e010db8c2881d87fdd5b) () |
| [ContainerItemDescription](class_tale_worlds_1_1_gauntlet_u_i_1_1_container_item_description.html) | [GetItemDescription](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#a55d066fe721d434830648834bb7b7b87) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) owner, [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) child, int childIndex) |
| Vector2 | [MeasureChildren](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#a03d98a7abf727b751fd2a459e1dc77c4) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget, Vector2 measureSpec, [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) spriteData, float renderScale) |
| void | [OnLayout](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#a1f5aabf4c97bee6d154d278ec80ae413) ([Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) widget, float left, float bottom, float right, float top) |
| int | [GetIndexForDrop](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#ab58afd7b409c8bb922d5d1daf59ecb00) ([Container](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_container.html) widget, Vector2 draggedWidgetPosition) |
| Vector2 | [GetDropGizmoPosition](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#a036bb45d80f04cd84ee764994753425e) ([Container](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_container.html) widget, Vector2 draggedWidgetPosition) |

|  |  |
| --- | --- |
| Properties | |
| [ContainerItemDescription](class_tale_worlds_1_1_gauntlet_u_i_1_1_container_item_description.html) | [DefaultItemDescription](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#ab7bc96d437445991f05e511a798e02f0) `[get]` |
| [LayoutMethod](namespace_tale_worlds_1_1_gauntlet_u_i_1_1_layout.html#a18e662d3e2b91c149107c32d2f0827ea) | [LayoutMethod](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#ab51ebaf5ea7a7a977bd106076d1f76bf) `[get, set]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#a28fcd2155fc1e010db8c2881d87fdd5b)StackLayout()
-----------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.GauntletUI.Layout.StackLayout.StackLayout | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#a55d066fe721d434830648834bb7b7b87)GetItemDescription()
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| [ContainerItemDescription](class_tale_worlds_1_1_gauntlet_u_i_1_1_container_item_description.html) TaleWorlds.GauntletUI.Layout.StackLayout.GetItemDescription | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *owner*, |
|  |  | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *child*, |
|  |  | int | *childIndex* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#a03d98a7abf727b751fd2a459e1dc77c4)MeasureChildren()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| Vector2 TaleWorlds.GauntletUI.Layout.StackLayout.MeasureChildren | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget*, |
|  |  | Vector2 | *measureSpec*, |
|  |  | [SpriteData](class_tale_worlds_1_1_two_dimension_1_1_sprite_data.html) | *spriteData*, |
|  |  | float | *renderScale* ) |

Implements [TaleWorlds.GauntletUI.Layout.ILayout](interface_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_i_layout.html#af7fe59ae4e23afd7892db65b594b8d4c).

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#a1f5aabf4c97bee6d154d278ec80ae413)OnLayout()
--------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.GauntletUI.Layout.StackLayout.OnLayout | ( | [Widget](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_widget.html) | *widget*, |
|  |  | float | *left*, |
|  |  | float | *bottom*, |
|  |  | float | *right*, |
|  |  | float | *top* ) |

Implements [TaleWorlds.GauntletUI.Layout.ILayout](interface_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_i_layout.html#aea226a15962ba6490c7715b42af17d19).

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#ab58afd7b409c8bb922d5d1daf59ecb00)GetIndexForDrop()
---------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| int TaleWorlds.GauntletUI.Layout.StackLayout.GetIndexForDrop | ( | [Container](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_container.html) | *widget*, |
|  |  | Vector2 | *draggedWidgetPosition* ) |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#a036bb45d80f04cd84ee764994753425e)GetDropGizmoPosition()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| Vector2 TaleWorlds.GauntletUI.Layout.StackLayout.GetDropGizmoPosition | ( | [Container](class_tale_worlds_1_1_gauntlet_u_i_1_1_base_types_1_1_container.html) | *widget*, |
|  |  | Vector2 | *draggedWidgetPosition* ) |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#ab7bc96d437445991f05e511a798e02f0)DefaultItemDescription
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ContainerItemDescription](class_tale_worlds_1_1_gauntlet_u_i_1_1_container_item_description.html) TaleWorlds.GauntletUI.Layout.StackLayout.DefaultItemDescription | | get |

[◆](class_tale_worlds_1_1_gauntlet_u_i_1_1_layout_1_1_stack_layout.html#ab51ebaf5ea7a7a977bd106076d1f76bf)LayoutMethod
----------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [LayoutMethod](namespace_tale_worlds_1_1_gauntlet_u_i_1_1_layout.html#a18e662d3e2b91c149107c32d2f0827ea) TaleWorlds.GauntletUI.Layout.StackLayout.LayoutMethod | | getset |

