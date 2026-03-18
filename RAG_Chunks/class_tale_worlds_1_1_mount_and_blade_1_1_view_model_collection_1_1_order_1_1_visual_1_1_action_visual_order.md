--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.ActionVisualOrder Class ReferencesealedInherits [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OrderActionDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#a4ad02e4648a2f0d488a1ee4fa56769c9) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController, [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) executionParameters) |
|  | [ActionVisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#abe314b351e57eaa279d701bffdd6f981) (string iconId, [OrderActionDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#a4ad02e4648a2f0d488a1ee4fa56769c9) orderAction, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name) |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | [GetName](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#a625c98ff0529bb58c4b6d78f13f46ee4) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController) |
| override bool | [IsTargeted](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#a9591301ccf2448782ba0696144387c74) () |
| override void | [ExecuteOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#a7f38400eae9dcae34548b7907276ba39) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController, [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) executionParameters) |
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
| override? bool | [OnGetFormationHasOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#adf547f9f1e0985b51a63f9864d29ac25) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) formation) |
| Protected Member Functions inherited from [TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.VisualOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html) | |
| virtual string | [GetIconId](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order.html#a953a77489877c171391b9e5d32591b33) () |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#abe314b351e57eaa279d701bffdd6f981)ActionVisualOrder()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.ActionVisualOrder.ActionVisualOrder | ( | string | *iconId*, |
|  |  | [OrderActionDelegate](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#a4ad02e4648a2f0d488a1ee4fa56769c9) | *orderAction*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#a4ad02e4648a2f0d488a1ee4fa56769c9)OrderActionDelegate()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| delegate void TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.ActionVisualOrder.OrderActionDelegate | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController*, |
|  |  | [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) | *executionParameters* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#a625c98ff0529bb58c4b6d78f13f46ee4)GetName()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| override [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.ActionVisualOrder.GetName | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#a9591301ccf2448782ba0696144387c74)IsTargeted()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| override bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.ActionVisualOrder.IsTargeted | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#a7f38400eae9dcae34548b7907276ba39)ExecuteOrder()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| override void TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.ActionVisualOrder.ExecuteOrder | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController*, |
|  |  | [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) | *executionParameters* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_action_visual_order.html#adf547f9f1e0985b51a63f9864d29ac25)OnGetFormationHasOrder()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override? bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.Visual.ActionVisualOrder.OnGetFormationHasOrder | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) | *formation* | ) |  | | protected |

