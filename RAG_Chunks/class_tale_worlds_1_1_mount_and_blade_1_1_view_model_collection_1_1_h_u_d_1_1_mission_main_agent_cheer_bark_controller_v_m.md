--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentCheerBarkControllerVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionMainAgentCheerBarkControllerVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#ac6ec95d7dec8708a855924f0ed22298d) (Action< int > onSelectCheer, Action< int > onSelectBark) |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a911587370146629d7b11784a8f99af64) () |
| void | [SelectItem](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a371a3c65ab5417b754709e6c694eae2f) (int itemIndex, int subNodeIndex=-1) |
| void | [ExecuteActivate](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a5cab954d592019c72d82286edaf6fb90) () |
| void | [ExecuteDeactivate](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a2e7b92e6f5b77ebfdf1c8038622f4034) (bool applySelection) |
| void | [OnNodeFocused](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a807daedc6261ee3b83b82967242494f3) ([CheerBarkNodeItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_cheer_bark_node_item_v_m.html) focusedNode) |
| void | [OnNodeTooltipToggled](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a3947950a0aa058914d34adb5d3ea859b) ([CheerBarkNodeItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_cheer_bark_node_item_v_m.html) node) |
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
| Properties | |
| bool | [IsActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a1fb313fc0a4b9c0f4c20b8d90f8938cc) `[get, set]` |
| string | [DisabledReasonText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a02db1440a97fb93e9b2618bc457ce79c) `[get, set]` |
| string | [SelectedNodeText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#afc6baa4e11c7b9d88aab056376a19fe0) `[get, set]` |
| bool | [IsNodesCategories](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a9ced166a1635150063172fac6c97d614) `[get, set]` |
| MBBindingList< [CheerBarkNodeItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_cheer_bark_node_item_v_m.html) > | [Nodes](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a297d07a79e025076ac09dcde1bd9cc86) `[get, set]` |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#ac6ec95d7dec8708a855924f0ed22298d)MissionMainAgentCheerBarkControllerVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentCheerBarkControllerVM.MissionMainAgentCheerBarkControllerVM | ( | Action< int > | *onSelectCheer*, |
|  |  | Action< int > | *onSelectBark* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a911587370146629d7b11784a8f99af64)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentCheerBarkControllerVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a371a3c65ab5417b754709e6c694eae2f)SelectItem()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentCheerBarkControllerVM.SelectItem | ( | int | *itemIndex*, |
|  |  | int | *subNodeIndex* = -1 ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a5cab954d592019c72d82286edaf6fb90)ExecuteActivate()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentCheerBarkControllerVM.ExecuteActivate | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a2e7b92e6f5b77ebfdf1c8038622f4034)ExecuteDeactivate()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentCheerBarkControllerVM.ExecuteDeactivate | ( | bool | *applySelection* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a807daedc6261ee3b83b82967242494f3)OnNodeFocused()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentCheerBarkControllerVM.OnNodeFocused | ( | [CheerBarkNodeItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_cheer_bark_node_item_v_m.html) | *focusedNode* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a3947950a0aa058914d34adb5d3ea859b)OnNodeTooltipToggled()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentCheerBarkControllerVM.OnNodeTooltipToggled | ( | [CheerBarkNodeItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_cheer_bark_node_item_v_m.html) | *node* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a1fb313fc0a4b9c0f4c20b8d90f8938cc)IsActive
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentCheerBarkControllerVM.IsActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a02db1440a97fb93e9b2618bc457ce79c)DisabledReasonText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentCheerBarkControllerVM.DisabledReasonText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#afc6baa4e11c7b9d88aab056376a19fe0)SelectedNodeText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentCheerBarkControllerVM.SelectedNodeText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a9ced166a1635150063172fac6c97d614)IsNodesCategories
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentCheerBarkControllerVM.IsNodesCategories | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_cheer_bark_controller_v_m.html#a297d07a79e025076ac09dcde1bd9cc86)Nodes
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[CheerBarkNodeItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_cheer_bark_node_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentCheerBarkControllerVM.Nodes | | getset |

