--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html ---

SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapIncidentVM](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a214f86a4a3757162006c4c4425264a03) ([Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) incident, Action onClose) |
| override void | [RefreshValues](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a268aed56673f1843df7bb68c5abeca97) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#ae0e650b10b48ba9cd2bc1f478043a500) () |
| void | [ExecuteConfirm](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a5f13a27ffee950b7e9e3af8bd07d000b) () |
| void | [SetDoneInputKey](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#aba9331d8f42ba294fbc078b3a37c5ace) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| Properties | |
| bool | [CanConfirm](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a5b7650f1cf48f667dc305fd27b85eca2) `[get, set]` |
| bool | [HasFocusedOption](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a9415960d1f2d080f2257cbccfb466a1a) `[get, set]` |
| bool | [HasSelectedOption](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a6ed6e13c0bcbd28b85c60d3acf482656) `[get, set]` |
| string | [Title](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a02ce41859fab34afcb224692975aaa9f) `[get, set]` |
| string | [Description](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#ae0ca6cec1e5a835697222ad0ee300571) `[get, set]` |
| string | [ConfirmText](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#ae368a6b1ec3a9b313218af6f81299685) `[get, set]` |
| string | [IncidentType](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a18b65243fc0be24a0cecdd75f037d1f2) `[get, set]` |
| string | [ActiveHint](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#af53363a26c24eedeb9effa3fcc986571) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ConfirmHint](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a4e971faac27f23be8f73d827a7b84f7f) `[get, set]` |
| [MapIncidentOptionVM](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_option_v_m.html) | [FocusedOption](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a965175830d2aafb4bfecd7e5301edb79) `[get, set]` |
| [MapIncidentOptionVM](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_option_v_m.html) | [SelectedOption](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a7ed386b9ce7ea22fa8842afc4b012003) `[get, set]` |
| MBBindingList< [MapIncidentOptionVM](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_option_v_m.html) > | [Options](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a724da9dddc2a348ede663dd66e06f4ef) `[get, set]` |
| [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a6b644c0dd6b2d3864495e9366fd3018b) `[get, set]` |

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

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a214f86a4a3757162006c4c4425264a03)MapIncidentVM()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.MapIncidentVM | ( | [Incident](class_tale_worlds_1_1_campaign_system_1_1_incidents_1_1_incident.html) | *incident*, |
|  |  | Action | *onClose* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a268aed56673f1843df7bb68c5abeca97)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#ae0e650b10b48ba9cd2bc1f478043a500)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a5f13a27ffee950b7e9e3af8bd07d000b)ExecuteConfirm()
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.ExecuteConfirm | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#aba9331d8f42ba294fbc078b3a37c5ace)SetDoneInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a5b7650f1cf48f667dc305fd27b85eca2)CanConfirm
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.CanConfirm | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a9415960d1f2d080f2257cbccfb466a1a)HasFocusedOption
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.HasFocusedOption | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a6ed6e13c0bcbd28b85c60d3acf482656)HasSelectedOption
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.HasSelectedOption | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a02ce41859fab34afcb224692975aaa9f)Title
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.Title | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#ae0ca6cec1e5a835697222ad0ee300571)Description
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.Description | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#ae368a6b1ec3a9b313218af6f81299685)ConfirmText
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.ConfirmText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a18b65243fc0be24a0cecdd75f037d1f2)IncidentType
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.IncidentType | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#af53363a26c24eedeb9effa3fcc986571)ActiveHint
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.ActiveHint | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a4e971faac27f23be8f73d827a7b84f7f)ConfirmHint
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.ConfirmHint | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a965175830d2aafb4bfecd7e5301edb79)FocusedOption
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapIncidentOptionVM](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_option_v_m.html) SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.FocusedOption | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a7ed386b9ce7ea22fa8842afc4b012003)SelectedOption
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapIncidentOptionVM](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_option_v_m.html) SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.SelectedOption | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a724da9dddc2a348ede663dd66e06f4ef)Options
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[MapIncidentOptionVM](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_option_v_m.html)> SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.Options | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_map_1_1_incidents_1_1_map_incident_v_m.html#a6b644c0dd6b2d3864495e9366fd3018b)DoneInputKey
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) SandBox.ViewModelCollection.Map.Incidents.MapIncidentVM.DoneInputKey | | getset |

