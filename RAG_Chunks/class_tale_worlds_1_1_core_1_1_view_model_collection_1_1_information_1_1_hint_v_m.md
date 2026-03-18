--- SOURCE: class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_v_m.html ---

TaleWorlds.Core.ViewModelCollection.Information.HintVM Class ReferenceInherits [TaleWorlds.Library.TooltipBaseVM](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [HintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_v_m.html#aff692bf21269c74eb8e5cfd7827ccb7a) (Type type, object[] args) |
| Public Member Functions inherited from [TaleWorlds.Library.TooltipBaseVM](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html) | |
|  | [TooltipBaseVM](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html#abd80e0eec3fe7a7313400a9a6fe47e48) (Type invokedType, object[] invokedArgs) |
| override void | [OnFinalize](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html#a665166feedb67daff83ba5850b5215f6) () |
| virtual void | [Tick](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html#a959cd4b874ac5de55082f5f694430a1b) (float dt) |
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
| Static Public Member Functions | |
| static void | [RefreshGenericHintTooltip](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_v_m.html#ae06ac08e2a5304d9142b9d559cf8bf18) ([HintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_v_m.html#aff692bf21269c74eb8e5cfd7827ccb7a) hint, object[] args) |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [OnFinalizeInternal](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_v_m.html#a62874b074ab6ea6d7cc513239546d92a) () |
| Protected Member Functions inherited from [TaleWorlds.Library.TooltipBaseVM](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html) | |
| void | [InvokeRefreshData< T >](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html#a6b1666a0286376c38d2d4a8f19836992) (T tooltip) |
| virtual void | [OnPeriodicRefresh](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html#acdd7e0535455d4df31641101f9e7983b) () |
| virtual void | [OnIsExtendedChanged](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html#a3c7e827faf384c53d16456616403d1b6) () |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Properties | |
| string | [Text](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_v_m.html#a064df83d7b6257b4e584f3c5ac6e50d5) `[get, set]` |
| Properties inherited from [TaleWorlds.Library.TooltipBaseVM](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html) | |
| bool | [IsActive](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html#a4a31a7ddeed19e665ae7fab2125b9893) `[get, set]` |
| bool | [IsExtended](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html#af9332d3b8f61a2ec7f7e6459f43fde9e) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Protected Attributes inherited from [TaleWorlds.Library.TooltipBaseVM](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html) | |
| readonly Type | [\_invokedType](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html#a0b00152f8090a42bae928079c7222a4a) |
| object[] | [\_invokedArgs](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html#a793482afb7654e21e44eafb6c1409842) |
| bool | [\_isPeriodicRefreshEnabled](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html#aff7b7405f0a64b102328938cd3439346) |
| float | [\_periodicRefreshDelay](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html#af87883648e2fd1ca015f54dfa67b5dab) |
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

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_v_m.html#aff692bf21269c74eb8e5cfd7827ccb7a)HintVM()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.Information.HintVM.HintVM | ( | Type | *type*, |
|  |  | object[] | *args* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_v_m.html#a62874b074ab6ea6d7cc513239546d92a)OnFinalizeInternal()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Core.ViewModelCollection.Information.HintVM.OnFinalizeInternal | ( |  | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.Library.TooltipBaseVM](class_tale_worlds_1_1_library_1_1_tooltip_base_v_m.html#a72e7ab9a1fd2c48482b1e1e02bdbc761).

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_v_m.html#ae06ac08e2a5304d9142b9d559cf8bf18)RefreshGenericHintTooltip()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  | | --- | --- | --- | --- | | void TaleWorlds.Core.ViewModelCollection.Information.HintVM.RefreshGenericHintTooltip | ( | [HintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_v_m.html#aff692bf21269c74eb8e5cfd7827ccb7a) | *hint*, | |  |  | object[] | *args* ) | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_v_m.html#a064df83d7b6257b4e584f3c5ac6e50d5)Text
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.Information.HintVM.Text | | getset |

