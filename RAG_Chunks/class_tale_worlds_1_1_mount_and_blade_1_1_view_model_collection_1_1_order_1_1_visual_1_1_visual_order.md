--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder Class ReferenceabstractInherited by [TaleWorlds.MountAndBlade.View.VisualOrders.Orders.SingleVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_single_visual_order.html), [TaleWorlds.MountAndBlade.View.VisualOrders.Orders.ToggleOrders.ToggleFacingVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html), [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.ActionVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html), [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.FormOrders.ArrangementVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html), [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.MovementOrders.AdvanceVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default314016a74a721c744fb1afdee45a07f8.html), [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.MovementOrders.ChargeVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default72e6ed78a94a1bd4b278544bff1a5018.html), [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.MovementOrders.FallbackVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default04436948c9b6d83058775e60182f0c03.html), [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.MovementOrders.FollowMeVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default732f70d546e971724a26d1c92abf75e9.html), [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.MovementOrders.MoveVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default4bbdfc107990c0fd577e8a62fc644521.html), [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.MovementOrders.RetreatVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultaac182f96bc3d16f063f20f9f8d7d34c.html), [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.MovementOrders.StopVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default83833a7a59dbfd98e4c48ce16ad36520.html), [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.ToggleOrders.GenericToggleVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html), [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.ReturnVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_return_visual_order.html), and [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.TransferTroopsVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_transfer_troops_visual_order.html).

|  |  |
| --- | --- |
| Public Member Functions | |
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
| virtual string | [GetIconId](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a953a77489877c171391b9e5d32591b33) () |
| bool? | [OnGetFormationHasOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a028fe383a202570cd183dfb20acc2727) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |

|  |  |
| --- | --- |
| Protected Attributes | |
| [OrderState](namespace_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual.html#a7bece088cf640995b7507b5be02fd7a6) | [\_lastActiveState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#ac543091bf7528be49f43f03d2d2c2e39) |

|  |  |
| --- | --- |
| Properties | |
| string | [StringId](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a42be9db4896c552b510616d4dc16d70d) `[get]` |
| string | [IconId](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a7bf44a84fb5041e8cc4c49b59a695242) `[get]` |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#ade1b066c68b6fd3b92a63d9fb52cb3af)VisualOrder()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder.VisualOrder | ( | string | *stringId* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a953a77489877c171391b9e5d32591b33)GetIconId()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual string TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder.GetIconId | ( |  | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.View.VisualOrders.Orders.ToggleOrders.ToggleFacingVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_1_1_visual_orders_1_1_orders_1_1_toggle_orders_1_1_toggle_facing_visual_order.html#a33d1cb9d612a04420ef0d893ef916b48), and [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.ToggleOrders.GenericToggleVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#a990e6ab182b95afd3f95090c94c12d2c).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#acf6cec3951ee8ef9e57893c01218e726)GetName()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder.GetName | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController* | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a2a25c06467afd85886a5abf8635e3383)IsTargeted()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder.IsTargeted | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#af41786f9474e33fcc83c08c657fca619)ExecuteOrder()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder.ExecuteOrder | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController*, | |  |  | [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) | *executionParameters* ) | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a2d510c26c7defd092cfb29e2bb0e81b4)BeforeExecuteOrder()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder.BeforeExecuteOrder | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController*, | |  |  | [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) | *executionParameters* ) | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a279f2f1b272681096778cc2995d73f8d)AfterExecuteOrder()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder.AfterExecuteOrder | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController*, | |  |  | [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) | *executionParameters* ) | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a028fe383a202570cd183dfb20acc2727)OnGetFormationHasOrder()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | bool? TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder.OnGetFormationHasOrder | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#ae5d9fca162b5fde97bb2c8affd5d1700)GetFormationHasOrder()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder.GetFormationHasOrder | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a08e1640ee4efed2afca732eb448e2a19)GetActiveState()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [OrderState](namespace_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual.html#a7bece088cf640995b7507b5be02fd7a6) TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder.GetActiveState | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#ac543091bf7528be49f43f03d2d2c2e39)\_lastActiveState
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderState](namespace_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual.html#a7bece088cf640995b7507b5be02fd7a6) TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder.\_lastActiveState | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a42be9db4896c552b510616d4dc16d70d)StringId
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder.StringId | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a7bf44a84fb5041e8cc4c49b59a695242)IconId
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder.IconId | | get |

