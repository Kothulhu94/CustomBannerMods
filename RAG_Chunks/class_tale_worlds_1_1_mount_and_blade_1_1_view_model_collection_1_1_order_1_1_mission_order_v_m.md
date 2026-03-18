--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [ClassConfiguration](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m_1_1_class_configuration.html) |
| struct | [FormationConfiguration](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m_1_1_formation_configuration.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [CursorStates](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a7634b38ea7cba0c1131d53ec998a489e) {     [Move](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a7634b38ea7cba0c1131d53ec998a489ea6bc362dbf494c61ea117fe3c71ca48a5) ,     [Face](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a7634b38ea7cba0c1131d53ec998a489ea8af5861002f3c157f9ba842bba10aa3f) ,     [Form](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a7634b38ea7cba0c1131d53ec998a489ead359c6df99b25183d81f7d728b71de0e)   } |
| enum | [OrderTargets](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a8d60ec0bb82d38d071d04716e24cd5f8) {     [Troops](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a8d60ec0bb82d38d071d04716e24cd5f8a209e7bfff9aa195bd2c6963a3fb33dda) = 0 ,     [SiegeMachines](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a8d60ec0bb82d38d071d04716e24cd5f8a7fefa419f5be0788fa08663a131cdfd8)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionOrderVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a6803dbcf888cab67e8972765bc1e890c) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ad2ef1a01caf515988862d05a1023e731) orderController, bool isDeployment, bool isMultiplayer) |
| void | [SetDeploymentParemeters](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a67ef801b95a9cf83f45356b056149983) ([Camera](class_tale_worlds_1_1_engine_1_1_camera.html) deploymentCamera, List< [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html) > deploymentPoints) |
| void | [SetCallbacks](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a653c14fca06ecff0bef474736b34d5bc) ([MissionOrderCallbacks](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_callbacks.html) callbacks) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ac963e008ca33fa9de9e39a4462d55119) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a13d96152f29f002ec913053be9ef51c9) () |
| void | [OnOrderExecuted](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#aada80eb914666451e3b608ee9abb51f2) ([OrderItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_v_m.html) orderItem) |
| virtual void | [OnOrderLayoutTypeChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a3e95425cdba799c5fc421af0f22c73bb) () |
| void | [OpenToggleOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a9481c244b5bb2b584be179d94f1c4541) (bool fromHold, bool displayMessage=true) |
| bool | [TryCloseToggleOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ac74576d03f7c72b5eab43ca53245986a) (bool applySelectedOrders=false) |
| void | [SetActiveOrders](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ab20f3c186e0dd05af97f0032848bb5c5) () |
| void | [SetFocusedFormations](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a4002bf77ef82f4be66c0c0834528f908) (MBReadOnlyList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > focusedFormationsCache) |
| void | [AfterInitialize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#af2ec4a872df52b7bf1917bcf2cf916d9) () |
| void | [Update](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ab31838bcd49369ed5cf977d2ff25fffb) () |
| void | [OnEscape](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#abcd4350e4083f95e0cbd4a2170b2a756) () |
| void | [ViewOrders](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a9521b2269b385f152beb93c563384948) () |
| [OrderSetVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_set_v_m.html) | [GetOrderSetAtIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a796afda108708b631d9ff59674be21f9) (int orderSetIndex) |
| bool | [TrySelectOrderSet](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a156a82ef2c5140ef7f2126b5de9a7d72) ([OrderSetVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_set_v_m.html) orderSet) |
| void | [OnTroopFormationSelected](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a0842f864d04498effc0d8e903caeaacd) (int formationTroopIndex) |
| void | [ExecuteSelectHighlightedFormation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a2a10d057e1a8ac130cb60c12d727e62f) () |
| void | [OnTroopHighlightSelection](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#abe659d166929f6a9cfd2ed202ffd984f) (bool isDirectionLeft) |
| void | [ExecuteToggleHighlightedFormation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ac5fc0263a01b198e00c0373fdd19edec) () |
| void | [OnDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a83a0060ad3775217cf442776449460de) () |
| void | [OnAfterDeploymentFinished](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#aa6af57cdde999d6479f512a17f424b5b) () |
| void | [OnFiltersSet](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a88e25baafc99864fa5740c5aa56dff92) (List< [FormationConfiguration](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m_1_1_formation_configuration.html) > filterData) |
| void | [UpdateCanUseShortcuts](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a7e30af69abedb0c34e913e71cee28787) (bool value) |
| void | [SetOrderIndexKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a687765f9b637facc050111b837e857a0) (int orderIndex, [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) gameKey) |
| void | [SetReturnKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a1373e33633651e2141a6da4fa17f5937) ([GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) gameKey) |
| void | [SetCancelInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#abc43fef15a43de8de1fc7af79ba5dd36) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| Public Attributes | |
| InputRestrictions | [InputRestrictions](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a2578e0471f1f833b94ac4bdca98ede50) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual [MissionOrderTroopControllerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_troop_controller_v_m.html) | [CreateTroopController](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a0b010de67d61ae595f5dc7ae15c7b29e) ([OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ad2ef1a01caf515988862d05a1023e731) orderController) |
| void | [OnTransferFinished](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ae36d55358aab76c07b6b7cf3a55cbbde) () |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Properties | |
| [CursorStates](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a7634b38ea7cba0c1131d53ec998a489e) | [CursorState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a9e69bf1c2a045a1e8d3f07ea7c489f3c) `[get]` |
| Team | [Team](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ae3edecae9c590a4cda691444cb158dd3) `[get]` |
| OrderController | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ad2ef1a01caf515988862d05a1023e731) `[get]` |
| bool | [IsTroopPlacingActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a4bfbf76212e05fdf24e7a6786f762050) `[get, set]` |
| bool | [PlayerHasAnyTroopUnderThem](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ae4497098d1e6e29d09d0f27f984395d2) `[get]` |
| [OrderSetVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_set_v_m.html) | [SelectedOrderSet](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ad6c920245e5c38134acdddd5ee552d44) `[get]` |
| bool | [DisplayedOrderMessageForLastOrder](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a4d8270b070e6b1561416d859c97b03b1) `[get]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a82ce3daedd2f9562b4c71097becc98df) `[get, set]` |
| MBBindingList< [OrderSetVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_set_v_m.html) > | [OrderSets](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a828d7ce7bd58430553e8b67a99e8432d) `[get, set]` |
| [MissionOrderTroopControllerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_troop_controller_v_m.html) | [TroopController](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a2ca7225007a572aff9aef78c2857a91e) `[get, set]` |
| [MissionOrderDeploymentControllerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html) | [DeploymentController](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a03fb7e177b0b00c6e650c2512c893051) `[get, set]` |
| int | [ActiveTargetState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#afa3ec42f246e71953f45ac16a84b7666) `[get, set]` |
| bool | [IsDeployment](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ac47a6ccf57c92ef7a6b395227747a4e0) `[get, set]` |
| bool | [HasAnyCascadingOrders](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ac3dd60d2e13bf36765505bc49b374131) `[get, set]` |
| bool | [IsToggleOrderShown](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a7678f8037adc876d62d5ab6a29a95c86) `[get, set]` |
| bool | [IsTroopListShown](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#aecbbc58add2174d11e716d299d87cac2) `[get, set]` |
| bool | [CanUseShortcuts](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a6feaead7953252347fdcae5103805898) `[get, set]` |
| bool | [IsHolding](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a722a24dfc3015a5d23e6b3846f351ac9) `[get, set]` |
| bool | [IsAnyOrderSetActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#aadb8e22909932f988ddc1008319d4240) `[get, set]` |
| string | [ReturnText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#aed22eb29b68f6467ee3d74ea4e51032f) `[get, set]` |
| bool | [UseAlternativeFormationLayout](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a08f38d3f0cda3183dcc27e811b020e37) `[get, set]` |

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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a7634b38ea7cba0c1131d53ec998a489e)CursorStates
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.CursorStates](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a7634b38ea7cba0c1131d53ec998a489e) |

| Enumerator | |
| --- | --- |
| Move |  |
| Face |  |
| Form |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a8d60ec0bb82d38d071d04716e24cd5f8)OrderTargets
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OrderTargets](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a8d60ec0bb82d38d071d04716e24cd5f8) |

| Enumerator | |
| --- | --- |
| Troops |  |
| SiegeMachines |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a6803dbcf888cab67e8972765bc1e890c)MissionOrderVM()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.MissionOrderVM | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ad2ef1a01caf515988862d05a1023e731) | *orderController*, |
|  |  | bool | *isDeployment*, |
|  |  | bool | *isMultiplayer* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a0b010de67d61ae595f5dc7ae15c7b29e)CreateTroopController()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual [MissionOrderTroopControllerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_troop_controller_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.CreateTroopController | ( | [OrderController](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ad2ef1a01caf515988862d05a1023e731) | *orderController* | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a67ef801b95a9cf83f45356b056149983)SetDeploymentParemeters()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.SetDeploymentParemeters | ( | [Camera](class_tale_worlds_1_1_engine_1_1_camera.html) | *deploymentCamera*, |
|  |  | List< [DeploymentPoint](class_tale_worlds_1_1_mount_and_blade_1_1_deployment_point.html) > | *deploymentPoints* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a653c14fca06ecff0bef474736b34d5bc)SetCallbacks()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.SetCallbacks | ( | [MissionOrderCallbacks](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_callbacks.html) | *callbacks* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ac963e008ca33fa9de9e39a4462d55119)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a13d96152f29f002ec913053be9ef51c9)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#aada80eb914666451e3b608ee9abb51f2)OnOrderExecuted()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OnOrderExecuted | ( | [OrderItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_item_v_m.html) | *orderItem* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a3e95425cdba799c5fc421af0f22c73bb)OnOrderLayoutTypeChanged()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OnOrderLayoutTypeChanged | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a9481c244b5bb2b584be179d94f1c4541)OpenToggleOrder()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OpenToggleOrder | ( | bool | *fromHold*, |
|  |  | bool | *displayMessage* = true ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ac74576d03f7c72b5eab43ca53245986a)TryCloseToggleOrder()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.TryCloseToggleOrder | ( | bool | *applySelectedOrders* = false | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ab20f3c186e0dd05af97f0032848bb5c5)SetActiveOrders()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.SetActiveOrders | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a4002bf77ef82f4be66c0c0834528f908)SetFocusedFormations()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.SetFocusedFormations | ( | MBReadOnlyList< [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_formation.html) > | *focusedFormationsCache* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#af2ec4a872df52b7bf1917bcf2cf916d9)AfterInitialize()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.AfterInitialize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ab31838bcd49369ed5cf977d2ff25fffb)Update()
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.Update | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#abcd4350e4083f95e0cbd4a2170b2a756)OnEscape()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OnEscape | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a9521b2269b385f152beb93c563384948)ViewOrders()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.ViewOrders | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a796afda108708b631d9ff59674be21f9)GetOrderSetAtIndex()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| [OrderSetVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_set_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.GetOrderSetAtIndex | ( | int | *orderSetIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a156a82ef2c5140ef7f2126b5de9a7d72)TrySelectOrderSet()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.TrySelectOrderSet | ( | [OrderSetVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_set_v_m.html) | *orderSet* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a0842f864d04498effc0d8e903caeaacd)OnTroopFormationSelected()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OnTroopFormationSelected | ( | int | *formationTroopIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a2a10d057e1a8ac130cb60c12d727e62f)ExecuteSelectHighlightedFormation()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.ExecuteSelectHighlightedFormation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#abe659d166929f6a9cfd2ed202ffd984f)OnTroopHighlightSelection()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OnTroopHighlightSelection | ( | bool | *isDirectionLeft* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ac5fc0263a01b198e00c0373fdd19edec)ExecuteToggleHighlightedFormation()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.ExecuteToggleHighlightedFormation | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ae36d55358aab76c07b6b7cf3a55cbbde)OnTransferFinished()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OnTransferFinished | ( |  | ) |  | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a83a0060ad3775217cf442776449460de)OnDeploymentFinished()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OnDeploymentFinished | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#aa6af57cdde999d6479f512a17f424b5b)OnAfterDeploymentFinished()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OnAfterDeploymentFinished | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a88e25baafc99864fa5740c5aa56dff92)OnFiltersSet()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OnFiltersSet | ( | List< [FormationConfiguration](struct_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m_1_1_formation_configuration.html) > | *filterData* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a7e30af69abedb0c34e913e71cee28787)UpdateCanUseShortcuts()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.UpdateCanUseShortcuts | ( | bool | *value* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a687765f9b637facc050111b837e857a0)SetOrderIndexKey()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.SetOrderIndexKey | ( | int | *orderIndex*, |
|  |  | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *gameKey* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a1373e33633651e2141a6da4fa17f5937)SetReturnKey()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.SetReturnKey | ( | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *gameKey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#abc43fef15a43de8de1fc7af79ba5dd36)SetCancelInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a2578e0471f1f833b94ac4bdca98ede50)InputRestrictions
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| InputRestrictions TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.InputRestrictions |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a9e69bf1c2a045a1e8d3f07ea7c489f3c)CursorState
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CursorStates](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a7634b38ea7cba0c1131d53ec998a489e) TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.CursorState | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ae3edecae9c590a4cda691444cb158dd3)Team
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Team TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.Team | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ad2ef1a01caf515988862d05a1023e731)OrderController
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | OrderController TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OrderController | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a4bfbf76212e05fdf24e7a6786f762050)IsTroopPlacingActive
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.IsTroopPlacingActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ae4497098d1e6e29d09d0f27f984395d2)PlayerHasAnyTroopUnderThem
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.PlayerHasAnyTroopUnderThem | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ad6c920245e5c38134acdddd5ee552d44)SelectedOrderSet
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [OrderSetVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_set_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.SelectedOrderSet | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a4d8270b070e6b1561416d859c97b03b1)DisplayedOrderMessageForLastOrder
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.DisplayedOrderMessageForLastOrder | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a82ce3daedd2f9562b4c71097becc98df)CancelInputKey
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a828d7ce7bd58430553e8b67a99e8432d)OrderSets
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[OrderSetVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_order_set_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.OrderSets | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a2ca7225007a572aff9aef78c2857a91e)TroopController
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionOrderTroopControllerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_troop_controller_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.TroopController | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a03fb7e177b0b00c6e650c2512c893051)DeploymentController
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MissionOrderDeploymentControllerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_deployment_controller_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.DeploymentController | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#afa3ec42f246e71953f45ac16a84b7666)ActiveTargetState
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.ActiveTargetState | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ac47a6ccf57c92ef7a6b395227747a4e0)IsDeployment
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.IsDeployment | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#ac3dd60d2e13bf36765505bc49b374131)HasAnyCascadingOrders
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.HasAnyCascadingOrders | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a7678f8037adc876d62d5ab6a29a95c86)IsToggleOrderShown
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.IsToggleOrderShown | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#aecbbc58add2174d11e716d299d87cac2)IsTroopListShown
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.IsTroopListShown | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a6feaead7953252347fdcae5103805898)CanUseShortcuts
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.CanUseShortcuts | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a722a24dfc3015a5d23e6b3846f351ac9)IsHolding
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.IsHolding | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#aadb8e22909932f988ddc1008319d4240)IsAnyOrderSetActive
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.IsAnyOrderSetActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#aed22eb29b68f6467ee3d74ea4e51032f)ReturnText
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.ReturnText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_order_1_1_mission_order_v_m.html#a08f38d3f0cda3183dcc27e811b020e37)UseAlternativeFormationLayout
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Order.MissionOrderVM.UseAlternativeFormationLayout | | getset |

