--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| void | [SetMissionParameters](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#af64481d2dcee1cf27967cc50e43e6023) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) deploymentCamera, List< [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html) > deploymentPoints) |
| void | [SetCallbacks](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a460e3eb7366c5a89e92c4f46f00424e7) ([MissionOrderCallbacks](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_callbacks.html) callbacks) |
|  | [MissionOrderDeploymentControllerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a2384ae7fff4134b6424ba6856f5111fa) ([MissionOrderVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html) missionOrder) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a7156936b2e70b4f427377a8e01d1d614) () |
|  | Used for updating localized texts. |
| void | [OnRefreshSelectedDeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#aaec6db86b24eb6462ae754e24b5d1c73) ([DeploymentSiegeMachineVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html) item) |
| void | [OnEntityHover](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a297ac98be2dcccc4b689bc2a585091a6) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) hoveredEntity) |
| void | [OnEntityHover](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#af439c7c5f360c608e42b6ed555fa75c7) ([DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html) deploymentPoint) |
| void | [OnEntitySelect](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a01d62125663e40a02b83e34cf5313707) ([WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) selectedEntity) |
| void | [RefreshSelectedDeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a987934a7be629c5025399fb349fde846) ([DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html) selectedDeploymentPoint) |
| void | [ExecuteCancelSelectedDeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a08a19fdb082f1aefea4b4e91e84333dc) () |
| void | [ExecuteBeginMission](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a0ff18c9b29e044bf2d60c2b881ffbc87) () |
| void | [ExecuteAutoDeploy](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a66aedd4227b954e00d912776a7226fe3) () |
| void | [ExecuteDeployPlayerSide](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a56c02b1fbc46584b345bc6baba25dbba) () |
| void | [FinalizeDeployment](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#acc5b2f0578c21501d73ceb608f353df6) () |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#aa7feabc41eb53a41c9a6141d24eff00e) () |
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

|  |  |
| --- | --- |
| Static Public Attributes | |
| const uint | [\_entityHiglightColor](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a4cf96abdadb2c9621e87aacccd497de9) = 0xFFAE721B |
| const uint | [\_entitySelectedColor](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#ab3cf5d14b435e34ec3c6cbd5b4860fff) = 0xFFE9550F |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |

|  |  |
| --- | --- |
| Properties | |
| OrderController | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a5a3961830ba9f33462a859ebd5e1d52a) `[get]` |
| MBBindingList< [OrderSiegeMachineVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_siege_machine_v_m.html) > | [SiegeMachineList](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a6fd5f2af96458648e35fad3378463613) `[get, set]` |
| MBBindingList< [DeploymentSiegeMachineVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html) > | [DeploymentTargets](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#aabb509abfac76bbb3d4cca49566f456c) `[get, set]` |
| bool | [IsSiegeDeploymentListActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a93df9286425459c40d1263db1d5cef06) `[get, set]` |
| MBBindingList< [DeploymentSiegeMachineVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html) > | [SiegeDeploymentList](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#aacf5a1563a52045e86cb0eb654a94bf2) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a2384ae7fff4134b6424ba6856f5111fa)MissionOrderDeploymentControllerVM()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.MissionOrderDeploymentControllerVM | ( | [MissionOrderVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html) | *missionOrder* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#af64481d2dcee1cf27967cc50e43e6023)SetMissionParameters()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.SetMissionParameters | ( | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *deploymentCamera*, |
|  |  | List< [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html) > | *deploymentPoints* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a460e3eb7366c5a89e92c4f46f00424e7)SetCallbacks()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.SetCallbacks | ( | [MissionOrderCallbacks](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_callbacks.html) | *callbacks* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a7156936b2e70b4f427377a8e01d1d614)RefreshValues()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#aaec6db86b24eb6462ae754e24b5d1c73)OnRefreshSelectedDeploymentPoint()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.OnRefreshSelectedDeploymentPoint | ( | [DeploymentSiegeMachineVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html) | *item* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a297ac98be2dcccc4b689bc2a585091a6)OnEntityHover() [1/2]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.OnEntityHover | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *hoveredEntity* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#af439c7c5f360c608e42b6ed555fa75c7)OnEntityHover() [2/2]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.OnEntityHover | ( | [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html) | *deploymentPoint* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a01d62125663e40a02b83e34cf5313707)OnEntitySelect()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.OnEntitySelect | ( | [WeakGameEntity](struct_tale_worlds_1_1_engine_1_1_weak_game_entity.html) | *selectedEntity* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a987934a7be629c5025399fb349fde846)RefreshSelectedDeploymentPoint()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.RefreshSelectedDeploymentPoint | ( | [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html) | *selectedDeploymentPoint* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a08a19fdb082f1aefea4b4e91e84333dc)ExecuteCancelSelectedDeploymentPoint()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.ExecuteCancelSelectedDeploymentPoint | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a0ff18c9b29e044bf2d60c2b881ffbc87)ExecuteBeginMission()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.ExecuteBeginMission | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a66aedd4227b954e00d912776a7226fe3)ExecuteAutoDeploy()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.ExecuteAutoDeploy | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a56c02b1fbc46584b345bc6baba25dbba)ExecuteDeployPlayerSide()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.ExecuteDeployPlayerSide | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#acc5b2f0578c21501d73ceb608f353df6)FinalizeDeployment()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.FinalizeDeployment | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#aa7feabc41eb53a41c9a6141d24eff00e)OnFinalize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a4cf96abdadb2c9621e87aacccd497de9)\_entityHiglightColor
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const uint TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.\_entityHiglightColor = 0xFFAE721B | | static |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#ab3cf5d14b435e34ec3c6cbd5b4860fff)\_entitySelectedColor
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const uint TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.\_entitySelectedColor = 0xFFE9550F | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a5a3961830ba9f33462a859ebd5e1d52a)OrderController
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | OrderController TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.OrderController | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a6fd5f2af96458648e35fad3378463613)SiegeMachineList
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[OrderSiegeMachineVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_siege_machine_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.SiegeMachineList | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#aabb509abfac76bbb3d4cca49566f456c)DeploymentTargets
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[DeploymentSiegeMachineVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.DeploymentTargets | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#a93df9286425459c40d1263db1d5cef06)IsSiegeDeploymentListActive
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.IsSiegeDeploymentListActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html#aacf5a1563a52045e86cb0eb654a94bf2)SiegeDeploymentList
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[DeploymentSiegeMachineVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_deployment_siege_machine_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderDeploymentControllerVM.SiegeDeploymentList | | getset |

