--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html ---

TaleWorlds.MountAndBlade.View.VisualOrders.Orders.ToggleOrders.ToggleFacingVisualOrder Class ReferenceInherits [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ToggleFacingVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html#add1bd663d1fab4bc3223184b6f018e3a) (string iconId) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html#acd0ea6cfd65d7678752703b898d2010b) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController) |
| override void | [ExecuteOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html#aee6d70b42afe80d3a68f99592e0f9dbf) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController, [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) executionParameters) |
| override bool | [IsTargeted](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html#adead0ffc03b22cf8da4dd6b918bed165) () |
| Public Member Functions inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html) | |
|  | [VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#ade1b066c68b6fd3b92a63d9fb52cb3af) (string stringId) |
| [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#acf6cec3951ee8ef9e57893c01218e726) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController) |
| bool | [IsTargeted](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a2a25c06467afd85886a5abf8635e3383) () |
| void | [ExecuteOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#af41786f9474e33fcc83c08c657fca619) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController, [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) executionParameters) |
| virtual void | [BeforeExecuteOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a2d510c26c7defd092cfb29e2bb0e81b4) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController, [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) executionParameters) |
| virtual void | [AfterExecuteOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a279f2f1b272681096778cc2995d73f8d) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController, [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) executionParameters) |
| bool | [GetFormationHasOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#ae5d9fca162b5fde97bb2c8affd5d1700) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| [OrderState](namespace_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual.html#a7bece088cf640995b7507b5be02fd7a6) | [GetActiveState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a08e1640ee4efed2afca732eb448e2a19) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override? bool | [OnGetFormationHasOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html#af9a4fa84fbf9c08956cf1e273e3ebe40) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| override string | [GetIconId](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html#a33d1cb9d612a04420ef0d893ef916b48) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html) | |
| bool? | [OnGetFormationHasOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a028fe383a202570cd183dfb20acc2727) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html) | |
| [OrderState](namespace_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual.html#a7bece088cf640995b7507b5be02fd7a6) | [\_lastActiveState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#ac543091bf7528be49f43f03d2d2c2e39) |
| Properties inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html) | |
| string | [StringId](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a42be9db4896c552b510616d4dc16d70d) `[get]` |
| string | [IconId](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a7bf44a84fb5041e8cc4c49b59a695242) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html#add1bd663d1fab4bc3223184b6f018e3a)ToggleFacingVisualOrder()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.View.VisualOrders.Orders.ToggleOrders.ToggleFacingVisualOrder.ToggleFacingVisualOrder | ( | string | *iconId* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html#acd0ea6cfd65d7678752703b898d2010b)GetName()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.View.VisualOrders.Orders.ToggleOrders.ToggleFacingVisualOrder.GetName | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html#aee6d70b42afe80d3a68f99592e0f9dbf)ExecuteOrder()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.View.VisualOrders.Orders.ToggleOrders.ToggleFacingVisualOrder.ExecuteOrder | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController*, |
|  |  | [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) | *executionParameters* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html#adead0ffc03b22cf8da4dd6b918bed165)IsTargeted()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.View.VisualOrders.Orders.ToggleOrders.ToggleFacingVisualOrder.IsTargeted | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html#af9a4fa84fbf9c08956cf1e273e3ebe40)OnGetFormationHasOrder()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override? bool TaleWorlds.MountAndBlade.View.VisualOrders.Orders.ToggleOrders.ToggleFacingVisualOrder.OnGetFormationHasOrder | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html#a33d1cb9d612a04420ef0d893ef916b48)GetIconId()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.MountAndBlade.View.VisualOrders.Orders.ToggleOrders.ToggleFacingVisualOrder.GetIconId | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a953a77489877c171391b9e5d32591b33).

