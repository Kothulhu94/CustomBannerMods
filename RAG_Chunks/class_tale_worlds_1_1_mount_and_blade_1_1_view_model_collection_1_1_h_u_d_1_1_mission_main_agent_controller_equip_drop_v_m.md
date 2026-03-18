--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MissionMainAgentControllerEquipDropVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a1a577ca59923c013c33cdb95dd22dc38) (Action< [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) > toggleItem) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a41f2afdbf91e8f40888136442ab350e7) () |
|  | Used for updating localized texts. |
| void | [InitializeMainAgentPropterties](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#aa2b595a1bb474e9d91bd86834ca3ac53) () |
| void | [OnToggle](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a9137c40963fb8f1463ff053c27979d34) (bool isEnabled) |
| void | [OnCancelHoldController](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a180d084231290c05a880e9c4e6215b61) () |
| void | [OnWeaponDroppedAtIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a222f000cfdbca3c38d2cbba2a1ea7e43) (int droppedWeaponIndex) |
| void | [OnWeaponEquippedAtIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a2ea8f3fe60c17caa1bdffde692339d05) (int equippedWeaponIndex) |
| void | [SetDropProgressForIndex](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a377264375fc647fe7dee4b4cf18d53eb) ([EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) eqIndex, float progress) |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a9a3e06dd0c909f55cd22a8aee4a417c0) () |
| void | [OnGamepadActiveChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#ae87abc270f75b857acb7e4f7b82adb87) (bool isActive) |
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
| MBBindingList< [ControllerEquippedItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_controller_equipped_item_v_m.html) > | [EquippedWeapons](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a3d8d75d7599c97ebe8baae81079cbc91) `[get, set]` |
| [ControllerEquippedItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_controller_equipped_item_v_m.html) | [EquippedExtraWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a907c5ff9b92f9c7de486cc6cd3dcc77f) `[get, set]` |
| string | [HoldToDropText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a3c7b4083d382c370f86ded157c746428) `[get, set]` |
| string | [PressToEquipText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#aa76f09d0417d0f42a1282ff2ee7c01e6) `[get, set]` |
| bool | [IsActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a07d1f088de11c16b5057832e6b6412b8) `[get, set]` |
| bool | [HaveExtraWeapon](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#ad84a8a8fa0e4c23f450fe244595080fe) `[get, set]` |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a1a577ca59923c013c33cdb95dd22dc38)MissionMainAgentControllerEquipDropVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.MissionMainAgentControllerEquipDropVM | ( | Action< [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) > | *toggleItem* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a41f2afdbf91e8f40888136442ab350e7)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#aa2b595a1bb474e9d91bd86834ca3ac53)InitializeMainAgentPropterties()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.InitializeMainAgentPropterties | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a9137c40963fb8f1463ff053c27979d34)OnToggle()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.OnToggle | ( | bool | *isEnabled* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a180d084231290c05a880e9c4e6215b61)OnCancelHoldController()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.OnCancelHoldController | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a222f000cfdbca3c38d2cbba2a1ea7e43)OnWeaponDroppedAtIndex()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.OnWeaponDroppedAtIndex | ( | int | *droppedWeaponIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a2ea8f3fe60c17caa1bdffde692339d05)OnWeaponEquippedAtIndex()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.OnWeaponEquippedAtIndex | ( | int | *equippedWeaponIndex* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a377264375fc647fe7dee4b4cf18d53eb)SetDropProgressForIndex()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.SetDropProgressForIndex | ( | [EquipmentIndex](namespace_tale_worlds_1_1_core.html#abe0029a7be28d338af66324cdb9fba61) | *eqIndex*, |
|  |  | float | *progress* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a9a3e06dd0c909f55cd22a8aee4a417c0)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#ae87abc270f75b857acb7e4f7b82adb87)OnGamepadActiveChanged()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.OnGamepadActiveChanged | ( | bool | *isActive* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a3d8d75d7599c97ebe8baae81079cbc91)EquippedWeapons
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ControllerEquippedItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_controller_equipped_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.EquippedWeapons | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a907c5ff9b92f9c7de486cc6cd3dcc77f)EquippedExtraWeapon
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ControllerEquippedItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_controller_equipped_item_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.EquippedExtraWeapon | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a3c7b4083d382c370f86ded157c746428)HoldToDropText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.HoldToDropText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#aa76f09d0417d0f42a1282ff2ee7c01e6)PressToEquipText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.PressToEquipText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#a07d1f088de11c16b5057832e6b6412b8)IsActive
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.IsActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_h_u_d_1_1_mission_main_agent_controller_equip_drop_v_m.html#ad84a8a8fa0e4c23f450fe244595080fe)HaveExtraWeapon
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.HUD.MissionMainAgentControllerEquipDropVM.HaveExtraWeapon | | getset |

