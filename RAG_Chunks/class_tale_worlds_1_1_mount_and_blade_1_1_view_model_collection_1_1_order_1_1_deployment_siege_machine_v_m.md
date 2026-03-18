--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [DeploymentSiegeMachineVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a387ffb0159ace55ee781eba0bdef6dc2) ([DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a168a014e5efbded4d82253ff96168c90) selectedDeploymentPoint, [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a1baf7719ee1ddf836f0ea61051e0660b) siegeMachine, [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) deploymentCamera, Action< DeploymentSiegeMachineVM > onSelectSiegeMachine, Action< [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a168a014e5efbded4d82253ff96168c90) > onHoverSiegeMachine, bool isSelected) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a2db6179e23b4d0a73c189f2688b63264) () |
|  | Used for updating localized texts. |
| void | [Update](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#ad7b9244a85c1e2b903cf429ea5013e0a) () |
| void | [CalculatePosition](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#aac307c385f0c775cd06e5c706efd20a5) () |
| void | [RefreshPosition](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#af7224cdf96c89f600de0fcaee5e66a24) () |
| void | [ExecuteAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a7dd8426bb25c90068b104cb6425a047b) () |
| void | [ExecuteFocusBegin](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a0e6777cbafb6b5faaf7cd3ec970c815a) () |
| void | [ExecuteFocusEnd](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#ab9daa6229096170e9672cebc709e0975) () |
| void | [RefreshWithDeployedWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#ac132c4d09c694be148a4e39dc339ef4a) () |
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
| virtual void | [OnFinalize](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc) () |
| void | [ExecuteCommand](class_tale_worlds_1_1_library_1_1_view_model.html#a857f69ffddc4dc222280b3e2b3c206bb) (string commandName, object[] parameters) |

|  |  |
| --- | --- |
| Public Attributes | |
| [Type](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#afa7c0145184582e3c0827ee4cf86a13d) | [MachineType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a202bfea0694e38b09d29dac7bf6c900e) |
| [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) | [Machine](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#aa0a22bd3c4b219af5372a3bc38d1c438) |
| SiegeWeapon | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a1baf7719ee1ddf836f0ea61051e0660b) |

|  |  |
| --- | --- |
| Properties | |
| DeploymentPoint | [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a168a014e5efbded4d82253ff96168c90) `[get]` |
| int | [Type](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#afa7c0145184582e3c0827ee4cf86a13d) `[get, set]` |
| bool | [IsSelected](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a87be7d9a062b3ac79860354d58a0862b) `[get, set]` |
| bool | [IsPlayerGeneral](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#aaa945b0a5719c5d556504c9661c7b62a) `[get, set]` |
| string | [MachineClass](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#ac97bd0d0ac62a1b62024e586ffcc3899) `[get, set]` |
| string | [BreachedText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#af22c25e41514b13aa28928e7a0c7b663) `[get, set]` |
| int | [RemainingCount](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a8890faf33b57a4cd672c0d0e181570a2) `[get, set]` |
| bool | [IsInside](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#ac6f4d39889dd929ba1254965a522abb7) `[get, set]` |
| bool | [IsInFront](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#abb3d8de88dbddac98595cedcb6bdac24) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [Position](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a870c6e1b7caab3a65a97783f79edbc18) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a387ffb0159ace55ee781eba0bdef6dc2)DeploymentSiegeMachineVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.DeploymentSiegeMachineVM | ( | [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a168a014e5efbded4d82253ff96168c90) | *selectedDeploymentPoint*, |
|  |  | [SiegeWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a1baf7719ee1ddf836f0ea61051e0660b) | *siegeMachine*, |
|  |  | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *deploymentCamera*, |
|  |  | Action< DeploymentSiegeMachineVM > | *onSelectSiegeMachine*, |
|  |  | Action< [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a168a014e5efbded4d82253ff96168c90) > | *onHoverSiegeMachine*, |
|  |  | bool | *isSelected* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a2db6179e23b4d0a73c189f2688b63264)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#ad7b9244a85c1e2b903cf429ea5013e0a)Update()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.Update | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#aac307c385f0c775cd06e5c706efd20a5)CalculatePosition()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.CalculatePosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#af7224cdf96c89f600de0fcaee5e66a24)RefreshPosition()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.RefreshPosition | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a7dd8426bb25c90068b104cb6425a047b)ExecuteAction()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.ExecuteAction | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a0e6777cbafb6b5faaf7cd3ec970c815a)ExecuteFocusBegin()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.ExecuteFocusBegin | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#ab9daa6229096170e9672cebc709e0975)ExecuteFocusEnd()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.ExecuteFocusEnd | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#ac132c4d09c694be148a4e39dc339ef4a)RefreshWithDeployedWeapon()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.RefreshWithDeployedWeapon | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a202bfea0694e38b09d29dac7bf6c900e)MachineType
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [Type](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#afa7c0145184582e3c0827ee4cf86a13d) TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.MachineType |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#aa0a22bd3c4b219af5372a3bc38d1c438)Machine
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [SiegeEngineType](class_tale_worlds_1_1_core_1_1_siege_engine_type.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.Machine |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a1baf7719ee1ddf836f0ea61051e0660b)SiegeWeapon
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| SiegeWeapon TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.SiegeWeapon |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a168a014e5efbded4d82253ff96168c90)DeploymentPoint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | DeploymentPoint TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.DeploymentPoint | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#afa7c0145184582e3c0827ee4cf86a13d)Type
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.Type | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a87be7d9a062b3ac79860354d58a0862b)IsSelected
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.IsSelected | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#aaa945b0a5719c5d556504c9661c7b62a)IsPlayerGeneral
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.IsPlayerGeneral | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#ac97bd0d0ac62a1b62024e586ffcc3899)MachineClass
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.MachineClass | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#af22c25e41514b13aa28928e7a0c7b663)BreachedText
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.BreachedText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a8890faf33b57a4cd672c0d0e181570a2)RemainingCount
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.RemainingCount | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#ac6f4d39889dd929ba1254965a522abb7)IsInside
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.IsInside | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#abb3d8de88dbddac98595cedcb6bdac24)IsInFront
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.IsInFront | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html#a870c6e1b7caab3a65a97783f79edbc18)Position
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.DeploymentSiegeMachineVM.Position | | getset |

