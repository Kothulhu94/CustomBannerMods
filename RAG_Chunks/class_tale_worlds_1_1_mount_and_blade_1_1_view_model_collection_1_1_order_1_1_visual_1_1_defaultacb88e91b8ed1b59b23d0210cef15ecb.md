--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.ToggleOrders.GenericToggleVisualOrder Class ReferenceInherits [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GenericToggleVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#a057624983724436b9b9db1ad6b442513) (string stringId, [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) positiveOrder, [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) negativeOrder) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#a97e898ec88b9cea1bd6f6233a7daa685) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController) |
| override bool | [IsTargeted](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#aa37a9f9d683851b83fa683c2f355b439) () |
| override void | [ExecuteOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#ae9f28f0f6f71bfe1326cdf107e673ecd) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController, [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) executionParameters) |
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
| override? bool | [OnGetFormationHasOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#ac19fbfc4c32289666bb58d2a9bdd9a0a) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| override string | [GetIconId](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#a990e6ab182b95afd3f95090c94c12d2c) () |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html) | |
| bool? | [OnGetFormationHasOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a028fe383a202570cd183dfb20acc2727) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |

|  |  |
| --- | --- |
| Properties | |
| [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [PositiveOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#a95254d1df506e379c89b2368a6bcf49c) `[get]` |
| [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | [NegativeOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#a1d1b57a0e6553c149ced7c39e421c58b) `[get]` |
| Properties inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html) | |
| string | [StringId](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a42be9db4896c552b510616d4dc16d70d) `[get]` |
| string | [IconId](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a7bf44a84fb5041e8cc4c49b59a695242) `[get]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Protected Attributes inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html) | |
| [OrderState](namespace_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual.html#a7bece088cf640995b7507b5be02fd7a6) | [\_lastActiveState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#ac543091bf7528be49f43f03d2d2c2e39) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#a057624983724436b9b9db1ad6b442513)GenericToggleVisualOrder()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.ToggleOrders.GenericToggleVisualOrder.GenericToggleVisualOrder | ( | string | *stringId*, |
|  |  | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | *positiveOrder*, |
|  |  | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) | *negativeOrder* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#a97e898ec88b9cea1bd6f6233a7daa685)GetName()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.ToggleOrders.GenericToggleVisualOrder.GetName | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#aa37a9f9d683851b83fa683c2f355b439)IsTargeted()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.ToggleOrders.GenericToggleVisualOrder.IsTargeted | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#ae9f28f0f6f71bfe1326cdf107e673ecd)ExecuteOrder()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.ToggleOrders.GenericToggleVisualOrder.ExecuteOrder | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController*, |
|  |  | [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) | *executionParameters* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#ac19fbfc4c32289666bb58d2a9bdd9a0a)OnGetFormationHasOrder()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override? bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.ToggleOrders.GenericToggleVisualOrder.OnGetFormationHasOrder | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#a990e6ab182b95afd3f95090c94c12d2c)GetIconId()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.ToggleOrders.GenericToggleVisualOrder.GetIconId | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a953a77489877c171391b9e5d32591b33).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#a95254d1df506e379c89b2368a6bcf49c)PositiveOrder
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.ToggleOrders.GenericToggleVisualOrder.PositiveOrder | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_defaultacb88e91b8ed1b59b23d0210cef15ecb.html#a1d1b57a0e6553c149ced7c39e421c58b)NegativeOrder
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderType](namespace_tale_worlds_1_1_mount_and_blade.html#abe8b3d6bab32ea30aa519b34d285b2ec) TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.ToggleOrders.GenericToggleVisualOrder.NegativeOrder | | get |

