--- SOURCE: class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html ---

StoryMode.ViewModelCollection.Missions.TrainingObjectiveKeyVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [MouseAndClickInput](struct_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m_1_1_mouse_and_click_input.html) |
| struct | [KeyInput](struct_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m_1_1_key_input.html) |
| struct | [ControllerStickInput](struct_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m_1_1_controller_stick_input.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [MovementTypes](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a91e16e9390735c8a9c1491e30439c975) {     [None](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a91e16e9390735c8a9c1491e30439c975a6adf97f83acf6453d4a6a4b1070f3754) ,     [MoveLeft](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a91e16e9390735c8a9c1491e30439c975ae8a98c6fabdea857c20c91e9bfd318ca) ,     [MoveRight](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a91e16e9390735c8a9c1491e30439c975a78af9b7fcdf1574f729de1454e15257b) ,     [MoveUp](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a91e16e9390735c8a9c1491e30439c975aa56a3ff692c679e34e0f52202fd9be5c) ,     [MoveDown](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a91e16e9390735c8a9c1491e30439c975a8c95fa949833ae3c6a217f55dec17dd5)   } |
| enum | [InputTypes](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a0f2effb11be4e0b2a969cd9ff1aa0f23) {     [MouseAndClick](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a0f2effb11be4e0b2a969cd9ff1aa0f23aedce4393a881fdf27c9eeae1f5649ddd) ,     [Key](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a0f2effb11be4e0b2a969cd9ff1aa0f23a897356954c2cd3d41b221e3f24f99bba) ,     [ControllerStick](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a0f2effb11be4e0b2a969cd9ff1aa0f23acba17ea699851a0df01ff5163c39aaaa)   } |
| enum | [MouseClickTypes](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#afef06c7965b5e897560fda7e1d7a3288) {     [Left](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#afef06c7965b5e897560fda7e1d7a3288a945d5e233cf7d6240f6b783b36a374ff) ,     [Middle](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#afef06c7965b5e897560fda7e1d7a3288ab1ca34f82e83c52b010f86955f264e05) ,     [Right](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#afef06c7965b5e897560fda7e1d7a3288a92b09c7c48c520c3c55e497875da437c)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TrainingObjectiveKeyVM](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#ac84e9747f0c6359679e50d59ccd24369) ([MouseAndClickInput](struct_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m_1_1_mouse_and_click_input.html) mouseAndClickInput) |
|  | [TrainingObjectiveKeyVM](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#acaeed129c6d0b0996ea05430b2d4d7a4) ([ControllerStickInput](struct_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m_1_1_controller_stick_input.html) controllerStickInput) |
|  | [TrainingObjectiveKeyVM](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a1dede9b1030b7f96012dbd5428082b04) ([KeyInput](struct_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m_1_1_key_input.html) keyInput) |
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
| Properties | |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [Key](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#add96732fdf40584f5573586b836e280f) `[get, set]` |
| string | [ForcedKeyId](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a84aed653d983675d550860ea61a13b5a) `[get, set]` |
| string | [ForcedKeyName](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a0c26dc331c04247bb598198408f13c91) `[get, set]` |
| int | [MovementType](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#af32568a97d864280680c4d39e0f6b12e) `[get, set]` |
| int | [MouseClick](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a049f7abe96da68debcbfa49964cd0680) `[get, set]` |
| int | [InputType](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a8c5c9842784f1f6f5c14ab62c7bee1f7) `[get, set]` |

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

Member Enumeration Documentation
--------------------------------

[◆](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a91e16e9390735c8a9c1491e30439c975)MovementTypes
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [StoryMode.ViewModelCollection.Missions.TrainingObjectiveKeyVM.MovementTypes](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a91e16e9390735c8a9c1491e30439c975) |

| Enumerator | |
| --- | --- |
| None |  |
| MoveLeft |  |
| MoveRight |  |
| MoveUp |  |
| MoveDown |  |

[◆](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a0f2effb11be4e0b2a969cd9ff1aa0f23)InputTypes
--------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [StoryMode.ViewModelCollection.Missions.TrainingObjectiveKeyVM.InputTypes](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a0f2effb11be4e0b2a969cd9ff1aa0f23) |

| Enumerator | |
| --- | --- |
| MouseAndClick |  |
| Key |  |
| ControllerStick |  |

[◆](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#afef06c7965b5e897560fda7e1d7a3288)MouseClickTypes
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [StoryMode.ViewModelCollection.Missions.TrainingObjectiveKeyVM.MouseClickTypes](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#afef06c7965b5e897560fda7e1d7a3288) |

| Enumerator | |
| --- | --- |
| Left |  |
| Middle |  |
| Right |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#ac84e9747f0c6359679e50d59ccd24369)TrainingObjectiveKeyVM() [1/3]
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| StoryMode.ViewModelCollection.Missions.TrainingObjectiveKeyVM.TrainingObjectiveKeyVM | ( | [MouseAndClickInput](struct_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m_1_1_mouse_and_click_input.html) | *mouseAndClickInput* | ) |  |

[◆](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#acaeed129c6d0b0996ea05430b2d4d7a4)TrainingObjectiveKeyVM() [2/3]
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| StoryMode.ViewModelCollection.Missions.TrainingObjectiveKeyVM.TrainingObjectiveKeyVM | ( | [ControllerStickInput](struct_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m_1_1_controller_stick_input.html) | *controllerStickInput* | ) |  |

[◆](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a1dede9b1030b7f96012dbd5428082b04)TrainingObjectiveKeyVM() [3/3]
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| StoryMode.ViewModelCollection.Missions.TrainingObjectiveKeyVM.TrainingObjectiveKeyVM | ( | [KeyInput](struct_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m_1_1_key_input.html) | *keyInput* | ) |  |

Property Documentation
----------------------

[◆](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#add96732fdf40584f5573586b836e280f)Key
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) StoryMode.ViewModelCollection.Missions.TrainingObjectiveKeyVM.Key | | getset |

[◆](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a84aed653d983675d550860ea61a13b5a)ForcedKeyId
---------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string StoryMode.ViewModelCollection.Missions.TrainingObjectiveKeyVM.ForcedKeyId | | getset |

[◆](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a0c26dc331c04247bb598198408f13c91)ForcedKeyName
-----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string StoryMode.ViewModelCollection.Missions.TrainingObjectiveKeyVM.ForcedKeyName | | getset |

[◆](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#af32568a97d864280680c4d39e0f6b12e)MovementType
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int StoryMode.ViewModelCollection.Missions.TrainingObjectiveKeyVM.MovementType | | getset |

[◆](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a049f7abe96da68debcbfa49964cd0680)MouseClick
--------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int StoryMode.ViewModelCollection.Missions.TrainingObjectiveKeyVM.MouseClick | | getset |

[◆](class_story_mode_1_1_view_model_collection_1_1_missions_1_1_training_objective_key_v_m.html#a8c5c9842784f1f6f5c14ab62c7bee1f7)InputType
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int StoryMode.ViewModelCollection.Missions.TrainingObjectiveKeyVM.InputType | | getset |

