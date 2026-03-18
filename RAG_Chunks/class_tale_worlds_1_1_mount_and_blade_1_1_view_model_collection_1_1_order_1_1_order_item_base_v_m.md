--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM Class ReferenceabstractInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

Inherited by [TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_v_m.html), and [TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderSetVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_set_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [OrderItemBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a69e7ec8034faedbffda57617198ee8d4) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) orderController) |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a1dc1022f534b27ba39382c8cf14791f0) () |
| void | [RefreshState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#aaa65ddad3cfb42b6918d84d853fb53bf) () |
| void | [ExecuteAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a6bb7be50ac2055d5f2a68b0d278aa3ad) ([VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) executionParameters) |
| void | [SetShortcutKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#aab10b3176238002382d6d51bbd6bf210) ([InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) inputKeyItem) |
| Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| void | [OnPropertyChanged](class_tale_worlds_1_1_library_1_1_view_model.html#a1a9dee9bab5986a33083d31a689dc7fe) ([CallerMemberName] string propertyName=null) |
|  | Method for notifying binded views about the changes in a property. Uses reflection to get the value of the property. If reflection is not needed or updated value of the property is already known, use [OnPropertyChangedWithValue()](class_tale_worlds_1_1_library_1_1_view_model.html#a0d6928eeec2b43ac9ae089830783bd7f) instead. |
| void | [OnPropertyChangedWithValue< T >](class_tale_worlds_1_1_library_1_1_view_model.html#ae5000d209ee6d4e7baec2fa8e8803c7e) (T value, [CallerMemberName]string propertyName=null) |
|  | Faster method for notifying binded views about the changes in a property. To avoid reflection, caller can pass changed value to this method. If caller does not have access rights to the value, use [OnPropertyChanged()](class_tale_worlds_1_1_library_1_1_view_model.html#a1a9dee9bab5986a33083d31a689dc7fe "Method for notifying binded views about the changes in a property. Uses reflection to get the value o...") instead. |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a0d6928eeec2b43ac9ae089830783bd7f) (bool value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#abf208d3c50803f5d1f70fa658c21dc96) (int value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a991eb5001ba6210a9fefb4a69f8883c2) (float value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#ac54722f74e27aa6143d62a9dc589fb95) (uint value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a62ff1ab710820c9583a4b6ee66bb05e8) ([Color](struct_tale_worlds_1_1_library_1_1_color.html) value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#adb40c37120d9480a9c61934104b3b0ee) (double value, [CallerMemberName] string propertyName=null) |
| void | [OnPropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3298a1b9a60a7057cac4df839915f49d) ([Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) value, [CallerMemberName] string propertyName=null) |
| object | [GetViewModelAtPath](class_tale_worlds_1_1_library_1_1_view_model.html#adab1a5fac562c67766ef900113c2fd48) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) path, bool isList) |
| object | [GetViewModelAtPath](class_tale_worlds_1_1_library_1_1_view_model.html#a58ad0a333f63aeb396cf0282a65b3b73) ([BindingPath](class_tale_worlds_1_1_library_1_1_binding_path.html) path) |
| object | [GetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#a870f5daf5e6f307138260ee84406bd4e) (string name, [PropertyTypeFeeder](namespace_tale_worlds_1_1_library.html#a74850bfe0b5488f44574810b7462b0f7) propertyTypeFeeder) |
| object | [GetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#a6c761a8baf9a75c1d8fd65dbaed24055) (string name) |
| Type | [GetPropertyType](class_tale_worlds_1_1_library_1_1_view_model.html#ade14a4f33f7022fa0b20393db6e5f1b1) (string name) |
| void | [SetPropertyValue](class_tale_worlds_1_1_library_1_1_view_model.html#ad53397f315ef866a738a5e65556043df) (string name, object value) |
| void | [ExecuteCommand](class_tale_worlds_1_1_library_1_1_view_model.html#a857f69ffddc4dc222280b3e2b3c206bb) (string commandName, object[] parameters) |
| virtual void | [RefreshValues](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd) () |
|  | Used for updating localized texts. |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual void | [OnSelectedStateChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a0f94451aefe59a89a684c6cb836c32a6) (bool isSelected) |
| void | [OnRefreshState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#af42bf172fa1844f9b23f85b205ecec25) () |
| void | [OnExecuteAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a387c17939ecc752a30283c627a19795e) ([VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) executionParameters) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Protected Attributes | |
| [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | [\_orderController](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a43bfb1a27c64b8fb6343d33061a1f5f7) |

|  |  |
| --- | --- |
| Properties | |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [ShortcutKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a720ac77b69ca19a6a36db5a39e6d4c4b) `[get, set]` |
| bool | [IsActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#ac987e20278d7a0b25ca04bb150583ada) `[get, set]` |
| bool | [IsSelected](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#af08d41049c00f6c9f877fcf6f5425339) `[get, set]` |
| bool | [CanUseShortcuts](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#aaf46380c1f1fc69d48d061a04932ee4e) `[get, set]` |
| string | [OrderIconId](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a3086c6c3003f7bdd6e8e6fa88477b140) `[get, set]` |
| string | [SelectionState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a9fb8c3573f9d2bc5886e638fb4220ef4) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a83af31209d2108b9a7b26691d21e714e) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Events inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| PropertyChangedEventHandler | [PropertyChanged](class_tale_worlds_1_1_library_1_1_view_model.html#a7f8d83700f17f8092632c1eaa406d665) `[add, remove]` |
| [PropertyChangedWithValueEventHandler](namespace_tale_worlds_1_1_library.html#aa511552e184232616e64f386cf1146b5) | [PropertyChangedWithValue](class_tale_worlds_1_1_library_1_1_view_model.html#acad8d628c31163e3022bea1e04675de6) `[add, remove]` |
| [PropertyChangedWithBoolValueEventHandler](namespace_tale_worlds_1_1_library.html#a6b0d7e614739868a8f81c53a64f081bd) | [PropertyChangedWithBoolValue](class_tale_worlds_1_1_library_1_1_view_model.html#a4d3b2d6f05fc919dca9e764b9e36af5d) `[add, remove]` |
| [PropertyChangedWithIntValueEventHandler](namespace_tale_worlds_1_1_library.html#a91bc6d8c78c447d9acf86771f3b3e932) | [PropertyChangedWithIntValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3b31df15300b9652b9b5f664e03a5af9) `[add, remove]` |
| [PropertyChangedWithFloatValueEventHandler](namespace_tale_worlds_1_1_library.html#aa44f77d2af0c3adb609a79640e080914) | [PropertyChangedWithFloatValue](class_tale_worlds_1_1_library_1_1_view_model.html#a3cb9bd971256835c5f6169cb58d67470) `[add, remove]` |
| [PropertyChangedWithUIntValueEventHandler](namespace_tale_worlds_1_1_library.html#aec7149fde7f195f3c4b4f10c4ce23cb8) | [PropertyChangedWithUIntValue](class_tale_worlds_1_1_library_1_1_view_model.html#a197c48c4f8ba00372fc86a548ccb86f7) `[add, remove]` |
| [PropertyChangedWithColorValueEventHandler](namespace_tale_worlds_1_1_library.html#a90de79687e9792b5065a8a4e9c30eeac) | [PropertyChangedWithColorValue](class_tale_worlds_1_1_library_1_1_view_model.html#aea6e76a6562fbdf20688565257699162) `[add, remove]` |
| [PropertyChangedWithDoubleValueEventHandler](namespace_tale_worlds_1_1_library.html#a8ce8e1aa20a71b9da4d1655fe04b089b) | [PropertyChangedWithDoubleValue](class_tale_worlds_1_1_library_1_1_view_model.html#a7d6e829c2ae2ef0147ca5f05e554dfc4) `[add, remove]` |
| [PropertyChangedWithVec2ValueEventHandler](namespace_tale_worlds_1_1_library.html#aa3ec79ffa85e522745c02340a7a41f2e) | [PropertyChangedWithVec2Value](class_tale_worlds_1_1_library_1_1_view_model.html#a8d1fb5f70c9230599a24b5d89a9a18f4) `[add, remove]` |
| Events inherited from [TaleWorlds.Library.IViewModel](interface_tale_worlds_1_1_library_1_1_i_view_model.html) | |
| [PropertyChangedWithValueEventHandler](namespace_tale_worlds_1_1_library.html#aa511552e184232616e64f386cf1146b5) | [PropertyChangedWithValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a19415fe20feafa29a4e6d8d61dd95834) |
| [PropertyChangedWithBoolValueEventHandler](namespace_tale_worlds_1_1_library.html#a6b0d7e614739868a8f81c53a64f081bd) | [PropertyChangedWithBoolValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ae0ed3e57e466612e46fcf77b394b9ba6) |
| [PropertyChangedWithIntValueEventHandler](namespace_tale_worlds_1_1_library.html#a91bc6d8c78c447d9acf86771f3b3e932) | [PropertyChangedWithIntValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#ad33c6216fef22f2e150e0c0673c3c6ef) |
| [PropertyChangedWithFloatValueEventHandler](namespace_tale_worlds_1_1_library.html#aa44f77d2af0c3adb609a79640e080914) | [PropertyChangedWithFloatValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#acef7bf697f161b4c0d742215107b0b8b) |
| [PropertyChangedWithUIntValueEventHandler](namespace_tale_worlds_1_1_library.html#aec7149fde7f195f3c4b4f10c4ce23cb8) | [PropertyChangedWithUIntValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#afd24d3b78a5e7fab669c340045b8533f) |
| [PropertyChangedWithColorValueEventHandler](namespace_tale_worlds_1_1_library.html#a90de79687e9792b5065a8a4e9c30eeac) | [PropertyChangedWithColorValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a3bc123550acc0a47f8c061c5a8300fa1) |
| [PropertyChangedWithDoubleValueEventHandler](namespace_tale_worlds_1_1_library.html#a8ce8e1aa20a71b9da4d1655fe04b089b) | [PropertyChangedWithDoubleValue](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a4b1a715b622570235d8224ecef32dc13) |
| [PropertyChangedWithVec2ValueEventHandler](namespace_tale_worlds_1_1_library.html#aa3ec79ffa85e522745c02340a7a41f2e) | [PropertyChangedWithVec2Value](interface_tale_worlds_1_1_library_1_1_i_view_model.html#a5b8667b3ad8595517ada80e2928bd6ab) |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a69e7ec8034faedbffda57617198ee8d4)OrderItemBaseVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.OrderItemBaseVM | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) | *orderController* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a1dc1022f534b27ba39382c8cf14791f0)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Reimplemented in [TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderSetVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_set_v_m.html#a30056b110f722f9143b9582327092ab3).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#aaa65ddad3cfb42b6918d84d853fb53bf)RefreshState()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.RefreshState | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a6bb7be50ac2055d5f2a68b0d278aa3ad)ExecuteAction()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.ExecuteAction | ( | [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) | *executionParameters* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a0f94451aefe59a89a684c6cb836c32a6)OnSelectedStateChanged()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.OnSelectedStateChanged | ( | bool | *isSelected* | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderSetVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_set_v_m.html#a65f316c1d213b2611e4c69c03fda57f5).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#af42bf172fa1844f9b23f85b205ecec25)OnRefreshState()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.OnRefreshState | ( |  | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a387c17939ecc752a30283c627a19795e)OnExecuteAction()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.OnExecuteAction | ( | [VisualOrderExecutionParameters](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_visual_1_1_visual_order_execution_parameters.html) | *executionParameters* | ) |  | | abstractprotected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#aab10b3176238002382d6d51bbd6bf210)SetShortcutKey()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.SetShortcutKey | ( | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | *inputKeyItem* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a43bfb1a27c64b8fb6343d33061a1f5f7)\_orderController
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_order_controller.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.\_orderController | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a720ac77b69ca19a6a36db5a39e6d4c4b)ShortcutKey
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.ShortcutKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#ac987e20278d7a0b25ca04bb150583ada)IsActive
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.IsActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#af08d41049c00f6c9f877fcf6f5425339)IsSelected
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.IsSelected | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#aaf46380c1f1fc69d48d061a04932ee4e)CanUseShortcuts
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.CanUseShortcuts | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a3086c6c3003f7bdd6e8e6fa88477b140)OrderIconId
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.OrderIconId | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a9fb8c3573f9d2bc5886e638fb4220ef4)SelectionState
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.SelectionState | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_base_v_m.html#a83af31209d2108b9a7b26691d21e714e)Name
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Order.OrderItemBaseVM.Name | | getset |

