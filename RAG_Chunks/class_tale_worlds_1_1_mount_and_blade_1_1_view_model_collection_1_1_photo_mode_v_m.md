--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [PhotoModeVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a00a31f56e21eb6ee0b15a51f2d0ea07b) ([Scene](class_tale_worlds_1_1_engine_1_1_scene.html) missionScene, Func< bool > getVignetteOn, Func< bool > getHideAgentsOn) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a3f0d283f22ec3e50775990cafd141a00) () |
|  | Used for updating localized texts. |
| void | [AddTakePictureKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#ada58d77bd416fe6cfd0ac4fe4cb0261b) ([GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) key) |
| void | [AddFasterCameraKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a0024be7103daa37a08a214d8511f9f25) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
| void | [AddKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a89ba137bbafbba9a1c7e4544aac6fdad) ([GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) key) |
| void | [AddHotkey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a044f824e8a27c78c01a25ed7c2cdd710) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
| void | [AddHotkeyWithForcedName](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a8dd1d81553b043b408b19c39473f7539) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) forcedName) |
| void | [AddCustomKey](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a23931d828a6b52475a25430070b90016) (string keyID, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) forcedName) |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a140c1b7bf03d9c3f149b0e87f334b229) () |
| void | [Reset](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a31a37202ed335f531e0e1d5614ed75a3) () |
| void | [UpdateTakePictureKeyVisibility](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a06740e0972568d24885db6461fa016e8) (bool canTakePicture) |
| void | [UpdateFasterCameraKeyVisibility](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#acf5cfab532308227445cc2660069d5fa) (bool canMoveCamera) |
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
| MBBindingList< [InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) > | [Keys](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#ad4b759d914a56f3a21e3704ba425a7cc) `[get, set]` |
| SelectorVM< [SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html) > | [ColorGradeSelector](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a343523fa28fa1fe260f977681fdad867) `[get, set]` |
| SelectorVM< [SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html) > | [OverlaySelector](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a696a1666b65657ce640398958b0c6905) `[get, set]` |
| [PhotoModeValueOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_value_option_v_m.html) | [FocusEndValueOption](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a7ff614ff3df60496ba05546f6aebb4f8) `[get, set]` |
| [PhotoModeValueOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_value_option_v_m.html) | [FocusStartValueOption](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a456bb18d924631dbe247a2fea2954db5) `[get, set]` |
| [PhotoModeValueOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_value_option_v_m.html) | [FocusValueOption](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a9124d81a65ad396d03763a746660724c) `[get, set]` |
| [PhotoModeValueOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_value_option_v_m.html) | [ExposureOption](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a88bef32fb7831cff10dac0ad8eef1ea1) `[get, set]` |
| [PhotoModeValueOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_value_option_v_m.html) | [VerticalFovOption](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a80bae4b79caacd7544340455a0ab226c) `[get, set]` |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a00a31f56e21eb6ee0b15a51f2d0ea07b)PhotoModeVM()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.PhotoModeVM | ( | [Scene](class_tale_worlds_1_1_engine_1_1_scene.html) | *missionScene*, |
|  |  | Func< bool > | *getVignetteOn*, |
|  |  | Func< bool > | *getHideAgentsOn* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a3f0d283f22ec3e50775990cafd141a00)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#ada58d77bd416fe6cfd0ac4fe4cb0261b)AddTakePictureKey()
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.AddTakePictureKey | ( | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *key* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a0024be7103daa37a08a214d8511f9f25)AddFasterCameraKey()
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.AddFasterCameraKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a89ba137bbafbba9a1c7e4544aac6fdad)AddKey()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.AddKey | ( | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *key* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a044f824e8a27c78c01a25ed7c2cdd710)AddHotkey()
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.AddHotkey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a8dd1d81553b043b408b19c39473f7539)AddHotkeyWithForcedName()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.AddHotkeyWithForcedName | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *forcedName* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a23931d828a6b52475a25430070b90016)AddCustomKey()
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.AddCustomKey | ( | string | *keyID*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *forcedName* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a140c1b7bf03d9c3f149b0e87f334b229)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a31a37202ed335f531e0e1d5614ed75a3)Reset()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.Reset | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a06740e0972568d24885db6461fa016e8)UpdateTakePictureKeyVisibility()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.UpdateTakePictureKeyVisibility | ( | bool | *canTakePicture* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#acf5cfab532308227445cc2660069d5fa)UpdateFasterCameraKeyVisibility()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.UpdateFasterCameraKeyVisibility | ( | bool | *canMoveCamera* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#ad4b759d914a56f3a21e3704ba425a7cc)Keys
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[InputKeyItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.Keys | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a343523fa28fa1fe260f977681fdad867)ColorGradeSelector
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.ColorGradeSelector | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a696a1666b65657ce640398958b0c6905)OverlaySelector
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[SelectorItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_selector_1_1_selector_item_v_m.html)> TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.OverlaySelector | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a7ff614ff3df60496ba05546f6aebb4f8)FocusEndValueOption
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PhotoModeValueOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_value_option_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.FocusEndValueOption | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a456bb18d924631dbe247a2fea2954db5)FocusStartValueOption
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PhotoModeValueOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_value_option_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.FocusStartValueOption | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a9124d81a65ad396d03763a746660724c)FocusValueOption
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PhotoModeValueOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_value_option_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.FocusValueOption | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a88bef32fb7831cff10dac0ad8eef1ea1)ExposureOption
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PhotoModeValueOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_value_option_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.ExposureOption | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_v_m.html#a80bae4b79caacd7544340455a0ab226c)VerticalFovOption
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PhotoModeValueOptionVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_photo_mode_value_option_v_m.html) TaleWorlds.MountAndBlade.ViewModelCollection.PhotoModeVM.VerticalFovOption | | getset |

