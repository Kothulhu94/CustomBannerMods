--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [TeamTypes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ad788a5a6fd604badad0e0352fd78c964) {     [PlayerTeam](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ad788a5a6fd604badad0e0352fd78c964a3b9b7df762f22bf2fa0b4268c5aca34f) = 0 ,     [PlayerAllyTeam](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ad788a5a6fd604badad0e0352fd78c964a14fda85c31b5de28696c6327df279ae6) ,     [EnemyTeam](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ad788a5a6fd604badad0e0352fd78c964a898775a544ff6a3fb0a2b7d8758a5e46)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionFormationMarkerTargetVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a2a09334187df91d9bb90b27e042a2e26) ([Formation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a6faf0590a1ea9f50ca3ebbdf6b7861e0) formation) |
| void | [Refresh](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ac9665cc0fbebbcd86a1cafa1611b9b75) () |
| void | [SetTargetedState](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a27ab3f70f922ed5cf15a74fbab56dbc1) (bool isFocused, bool isTargetingAFormation) |
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
| virtual void | [RefreshValues](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd) () |
|  | Used for updating localized texts. |

|  |  |
| --- | --- |
| Static Public Member Functions | |
| static string | [GetFormationType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ac6eba3bcd82d9737ec37fe941c13247d) ([FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) formationType) |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |

|  |  |
| --- | --- |
| Properties | |
| Formation | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a6faf0590a1ea9f50ca3ebbdf6b7861e0) `[get]` |
| bool | [IsEnabled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a4465720d49d73699412c4b144ee949f9) `[get, set]` |
| bool | [IsCenterOfFocus](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#aa62972fdb7f01c1764ab53cbc12abd40) `[get, set]` |
| bool | [IsFormationTargetRelevant](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a609cb5213f539e0d447dcd16bed416b6) `[get, set]` |
| bool | [IsTargetingAFormation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#aef42475190f318b291a519a9de8d6ea9) `[get, set]` |
| bool | [ShowDistanceTexts](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a832b6fc124bd17fe54edecaa69ef1cd3) `[get, set]` |
| string | [FormationType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a9abafcb086614629929a8ee11a1c37ee) `[get, set]` |
| int | [TeamType](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a7b8111f8ab2902b28e9f9779d6cad3fa) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [ScreenPosition](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a7f3af63dd8b260c4d8fa5b84d340b9cd) `[get, set]` |
| float | [Distance](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a385797319b8b2f00ced6be9e7e34d658) `[get, set]` |
| string | [DistanceText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ac1c55e1381d44aa482ec267d0b27a6b4) `[get, set]` |
| int | [Size](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ac00e8605f01b5495f5e40f9ee6b3f385) `[get, set]` |
| int | [WSign](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#aa8f863ad0c096a82d56e574a551019a3) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ad788a5a6fd604badad0e0352fd78c964)TeamTypes
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.TeamTypes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ad788a5a6fd604badad0e0352fd78c964) |

| Enumerator | |
| --- | --- |
| PlayerTeam |  |
| PlayerAllyTeam |  |
| EnemyTeam |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a2a09334187df91d9bb90b27e042a2e26)MissionFormationMarkerTargetVM()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.MissionFormationMarkerTargetVM | ( | [Formation](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a6faf0590a1ea9f50ca3ebbdf6b7861e0) | *formation* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ac9665cc0fbebbcd86a1cafa1611b9b75)Refresh()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.Refresh | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a27ab3f70f922ed5cf15a74fbab56dbc1)SetTargetedState()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.SetTargetedState | ( | bool | *isFocused*, |
|  |  | bool | *isTargetingAFormation* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ac6eba3bcd82d9737ec37fe941c13247d)GetFormationType()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.GetFormationType | ( | [FormationClass](namespace_tale_worlds_1_1_core.html#a6557e2bb854e5a0f5836accf9ba46b90) | *formationType* | ) |  | | static |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a6faf0590a1ea9f50ca3ebbdf6b7861e0)Formation
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Formation TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.Formation | | get |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a4465720d49d73699412c4b144ee949f9)IsEnabled
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.IsEnabled | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#aa62972fdb7f01c1764ab53cbc12abd40)IsCenterOfFocus
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.IsCenterOfFocus | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a609cb5213f539e0d447dcd16bed416b6)IsFormationTargetRelevant
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.IsFormationTargetRelevant | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#aef42475190f318b291a519a9de8d6ea9)IsTargetingAFormation
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.IsTargetingAFormation | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a832b6fc124bd17fe54edecaa69ef1cd3)ShowDistanceTexts
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.ShowDistanceTexts | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a9abafcb086614629929a8ee11a1c37ee)FormationType
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.FormationType | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a7b8111f8ab2902b28e9f9779d6cad3fa)TeamType
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.TeamType | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a7f3af63dd8b260c4d8fa5b84d340b9cd)ScreenPosition
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.ScreenPosition | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#a385797319b8b2f00ced6be9e7e34d658)Distance
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.Distance | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ac1c55e1381d44aa482ec267d0b27a6b4)DistanceText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.DistanceText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#ac00e8605f01b5495f5e40f9ee6b3f385)Size
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.Size | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_formation_marker_174ede453fa32a2afc0c3c3165cba710c.html#aa8f863ad0c096a82d56e574a551019a3)WSign
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.HUD.FormationMarker.MissionFormationMarkerTargetVM.WSign | | getset |

