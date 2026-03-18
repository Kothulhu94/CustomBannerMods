--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [FaceGenPropertyVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a493b88be5100b724d67dd1b8528f6517) (int keyNo, double min, double max, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) name, int keyTimePoint, int tabId, double value, float initialValue, Action< int, float, bool, bool > updateFace, Action addCommand, Action resetSliderPrevValuesCommand, bool isEnabled=true, bool isDiscrete=false, bool addCommandOnValueChange=true) |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#ade617969931ed3a3508a36581668af5b) () |
| void | [Randomize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a6a773a4c64ae3b001446f6f581e49743) () |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a692170da3127c415717a51a3d94540ba) () |
|  | Used for updating localized texts. |
| void | [AddCommand](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#aae7b6a7e881788e0f90b7ba7702fa742) () |
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
| int | [KeyNo](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a4657dcc27271c96b11bd0a67704177f4) |
| double | [PrevValue](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#ac6a0abbe78b320f118b6e8ecbda355ec) = -1 |

|  |  |
| --- | --- |
| Properties | |
| int | [KeyTimePoint](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a25b3ea9e785b1ac35d2c26317d84bdc6) `[get]` |
| float | [Min](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a4cf21b2a195e244a1287a20fd7e6b54f) `[get, set]` |
| int | [TabID](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#af77b99bda7e6b928d480cbe9fa03d32d) `[get, set]` |
| float | [Max](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a742e731e5bf8c7e875cb4c9e1fc19225) `[get, set]` |
| float | [Value](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a447b52430babb9ffdb12ded162212dfe) `[get, set]` |
| string | [Name](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a61b38cd21eabddc2d0a6eedbdedb90a4) `[get, set]` |
| bool | [IsEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a6efed00449c446e731160fd8168972af) `[get, set]` |
| bool | [IsDiscrete](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a94b9bd37cd11237835420c5b78fc7e8e) `[get, set]` |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a493b88be5100b724d67dd1b8528f6517)FaceGenPropertyVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.FaceGenPropertyVM | ( | int | *keyNo*, |
|  |  | double | *min*, |
|  |  | double | *max*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *name*, |
|  |  | int | *keyTimePoint*, |
|  |  | int | *tabId*, |
|  |  | double | *value*, |
|  |  | float | *initialValue*, |
|  |  | Action< int, float, bool, bool > | *updateFace*, |
|  |  | Action | *addCommand*, |
|  |  | Action | *resetSliderPrevValuesCommand*, |
|  |  | bool | *isEnabled* = true, |
|  |  | bool | *isDiscrete* = false, |
|  |  | bool | *addCommandOnValueChange* = true ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#ade617969931ed3a3508a36581668af5b)Reset()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a6a773a4c64ae3b001446f6f581e49743)Randomize()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.Randomize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a692170da3127c415717a51a3d94540ba)RefreshValues()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#aae7b6a7e881788e0f90b7ba7702fa742)AddCommand()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.AddCommand | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a4657dcc27271c96b11bd0a67704177f4)KeyNo
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.KeyNo |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#ac6a0abbe78b320f118b6e8ecbda355ec)PrevValue
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| double TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.PrevValue = -1 |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a25b3ea9e785b1ac35d2c26317d84bdc6)KeyTimePoint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.KeyTimePoint | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a4cf21b2a195e244a1287a20fd7e6b54f)Min
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.Min | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#af77b99bda7e6b928d480cbe9fa03d32d)TabID
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.TabID | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a742e731e5bf8c7e875cb4c9e1fc19225)Max
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.Max | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a447b52430babb9ffdb12ded162212dfe)Value
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.Value | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a61b38cd21eabddc2d0a6eedbdedb90a4)Name
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.Name | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a6efed00449c446e731160fd8168972af)IsEnabled
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.IsEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_face_generator_1_1_face_gen_property_v_m.html#a94b9bd37cd11237835420c5b78fc7e8e)IsDiscrete
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.FaceGenerator.FaceGenPropertyVM.IsDiscrete | | getset |

