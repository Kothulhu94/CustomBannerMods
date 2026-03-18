--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.FormOrders.ArrangementVisualOrder Class ReferenceInherits [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ArrangementVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html#a8348785d1c853c66235ed76f5ad218d6) ([ArrangementOrder.ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) arrangementOrder, string iconId) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html#a4fc065f3bea5a42fde717afc7a3bffa7) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController) |
| override void | [ExecuteOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html#a4b9f49e50ce7c2829950c603d45ab537) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController, [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) executionParameters) |
| override bool | [IsTargeted](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html#aa7ce04ad147bc3196b0eaef988579375) () |
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
| override? bool | [OnGetFormationHasOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html#a384cd3f00472b270c78554294606f8f6) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html) | |
| virtual string | [GetIconId](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a953a77489877c171391b9e5d32591b33) () |
| bool? | [OnGetFormationHasOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a028fe383a202570cd183dfb20acc2727) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |

|  |  |
| --- | --- |
| Properties | |
| [ArrangementOrder.ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) | [ArrangementOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html#a150eda637eff621d88b919d59fcb0e51) `[get]` |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html#a8348785d1c853c66235ed76f5ad218d6)ArrangementVisualOrder()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.FormOrders.ArrangementVisualOrder.ArrangementVisualOrder | ( | [ArrangementOrder.ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) | *arrangementOrder*, |
|  |  | string | *iconId* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html#a4fc065f3bea5a42fde717afc7a3bffa7)GetName()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.FormOrders.ArrangementVisualOrder.GetName | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html#a4b9f49e50ce7c2829950c603d45ab537)ExecuteOrder()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.FormOrders.ArrangementVisualOrder.ExecuteOrder | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController*, |
|  |  | [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) | *executionParameters* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html#aa7ce04ad147bc3196b0eaef988579375)IsTargeted()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.FormOrders.ArrangementVisualOrder.IsTargeted | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html#a384cd3f00472b270c78554294606f8f6)OnGetFormationHasOrder()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override? bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.FormOrders.ArrangementVisualOrder.OnGetFormationHasOrder | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_default1296da2767f8d7eccfffb1cd150e4653.html#a150eda637eff621d88b919d59fcb0e51)ArrangementOrder
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ArrangementOrder.ArrangementOrderEnum](struct_tale_worlds_1_1_mount_and_blade_1_1_arrangement_order.html#a00b6c69ad6e883abdbfc5ed7ff4a2280) TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.Default.Orders.FormOrders.ArrangementVisualOrder.ArrangementOrder | | get |

