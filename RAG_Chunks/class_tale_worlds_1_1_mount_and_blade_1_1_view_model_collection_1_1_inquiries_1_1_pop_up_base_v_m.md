--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM Class ReferenceabstractInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

Inherited by [TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.MultiSelectionQueryPopUpVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_multi_selection_query_pop_up_v_m.html), [TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.SingleQueryPopUpVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_single_query_pop_up_v_m.html), and [TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.TextQueryPopUpVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_text_query_pop_up_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PopUpBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ac153d9a87325492d49209e060d522015) (Action closeQuery) |
| void | [ExecuteAffirmativeAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a271e1ff94467eace1bc92f3edd6ee052) () |
| void | [ExecuteNegativeAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a8c080d9c0a0494cb2fe738693c449753) () |
| virtual void | [OnTick](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a043e845f0cd813dd429ec67f5fb52d76) (float dt) |
| virtual void | [OnClearData](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ac286cc996b30efd4bf923a1fa8de5d41) () |
| void | [ForceRefreshKeyVisuals](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a4113b66257b119fc598772f359a36807) () |
| void | [CloseQuery](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ad51c69c1627cb80119bee68356017c12) () |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a8f45a7699645908df343393953e2141c) () |
| void | [SetCancelInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a8ab58b81d7b27d5d16da58ad5798ba48) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetDoneInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ab3b09599341c809b8302a9c611fe1cc2) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| Protected Attributes | |
| Action | [\_affirmativeAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ae68aa3154a5f9ffaea94e5742ee500dd) |
| Action | [\_negativeAction](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#aeeb6fcdcc0b039f59d818fee2ca402ee) |

|  |  |
| --- | --- |
| Properties | |
| string | [TitleText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a8cad285bcedb40f905bea2f5005623c4) `[get, set]` |
| string | [PopUpLabel](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a9d1d0a16c62f25a9b8027a81d21fb4aa) `[get, set]` |
| string | [ButtonOkLabel](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ab9a6403413361c23f1504d4c931af389) `[get, set]` |
| string | [ButtonCancelLabel](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a9db8a105731b7459bb0d961e9266097d) `[get, set]` |
| bool | [IsButtonOkShown](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a85f7f57343d0bbadbf97590c75d83c4d) `[get, set]` |
| bool | [IsButtonCancelShown](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ae7fff932680d07cdce7bce7506548021) `[get, set]` |
| bool | [IsButtonOkEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a5f459e09092879ebefaeca31769b6c5f) `[get, set]` |
| bool | [IsButtonCancelEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a13c9c31dc80807227ff6a33f5633c79a) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ButtonOkHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#afedeff8e90157e2dcfab484b9930f381) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ButtonCancelHint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#af49757950c923ee7730c5b1349a1f6d0) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a6754e3fcabbdec4c18aad1540830c9ae) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#abbcb6b239285823c603226ec90b6ecea) `[get, set]` |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ac153d9a87325492d49209e060d522015)PopUpBaseVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.PopUpBaseVM | ( | Action | *closeQuery* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a271e1ff94467eace1bc92f3edd6ee052)ExecuteAffirmativeAction()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.ExecuteAffirmativeAction | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a8c080d9c0a0494cb2fe738693c449753)ExecuteNegativeAction()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.ExecuteNegativeAction | ( |  | ) |  | | abstract |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a043e845f0cd813dd429ec67f5fb52d76)OnTick()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.OnTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.SingleQueryPopUpVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_single_query_pop_up_v_m.html#a3f604c46ff0fbe65977a2bcd97eaa216).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ac286cc996b30efd4bf923a1fa8de5d41)OnClearData()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.OnClearData | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.MultiSelectionQueryPopUpVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_multi_selection_query_pop_up_v_m.html#a7aed3f10f29c5cfedd5f2254137a7909), [TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.SingleQueryPopUpVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_single_query_pop_up_v_m.html#ae3d6822800aeafd3032cf2723a314d29), and [TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.TextQueryPopUpVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_text_query_pop_up_v_m.html#a3b9fc2a9837f6eb785caa237a3571e58).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a4113b66257b119fc598772f359a36807)ForceRefreshKeyVisuals()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.ForceRefreshKeyVisuals | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ad51c69c1627cb80119bee68356017c12)CloseQuery()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.CloseQuery | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a8f45a7699645908df343393953e2141c)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a8ab58b81d7b27d5d16da58ad5798ba48)SetCancelInputKey()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ab3b09599341c809b8302a9c611fe1cc2)SetDoneInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ae68aa3154a5f9ffaea94e5742ee500dd)\_affirmativeAction
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.\_affirmativeAction | | protected |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#aeeb6fcdcc0b039f59d818fee2ca402ee)\_negativeAction
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.\_negativeAction | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a8cad285bcedb40f905bea2f5005623c4)TitleText
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.TitleText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a9d1d0a16c62f25a9b8027a81d21fb4aa)PopUpLabel
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.PopUpLabel | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ab9a6403413361c23f1504d4c931af389)ButtonOkLabel
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.ButtonOkLabel | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a9db8a105731b7459bb0d961e9266097d)ButtonCancelLabel
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.ButtonCancelLabel | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a85f7f57343d0bbadbf97590c75d83c4d)IsButtonOkShown
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.IsButtonOkShown | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#ae7fff932680d07cdce7bce7506548021)IsButtonCancelShown
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.IsButtonCancelShown | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a5f459e09092879ebefaeca31769b6c5f)IsButtonOkEnabled
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.IsButtonOkEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a13c9c31dc80807227ff6a33f5633c79a)IsButtonCancelEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.IsButtonCancelEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#afedeff8e90157e2dcfab484b9930f381)ButtonOkHint
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.ButtonOkHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#af49757950c923ee7730c5b1349a1f6d0)ButtonCancelHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.ButtonCancelHint | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#a6754e3fcabbdec4c18aad1540830c9ae)CancelInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_inquiries_1_1_pop_up_base_v_m.html#abbcb6b239285823c603226ec90b6ecea)DoneInputKey
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.Inquiries.PopUpBaseVM.DoneInputKey | | getset |

