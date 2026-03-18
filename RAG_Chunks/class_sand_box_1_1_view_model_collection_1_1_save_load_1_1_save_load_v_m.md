--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html ---

SandBox.ViewModelCollection.SaveLoad.SaveLoadVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SaveLoadVM](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a09f1615ba0f5430f555c2f13e8938421) (bool isSaving, bool isCampaignMapOnStack) |
| async void | [Initialize](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#ad1d3c69fa0e18fa0c6bb3b82e3cb00f1) () |
| override void | [RefreshValues](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a4eb90d27e398483335744d6c603366f0) () |
|  | Used for updating localized texts. |
| void | [ExecuteCreateNewSaveGame](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a59acb8a32c70be152bdfeb042a33aa8e) () |
| void | [ExecuteDone](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a013f07c0e9fcf4d178e204cb6d2b9a65) () |
| void | [ExecuteLoadSave](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a7678a9b4bd094d6fdc7e99aa5b3498a9) () |
| void | [DeleteSelectedSave](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a59d614a3d17dfc14e9590e95be6fa7db) () |
| override void | [OnFinalize](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#af7c318aeafcfe9c9165352447a167d47) () |
| void | [SetDoneInputKey](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#adb03e01d804dc4a577c3c086eccc9e85) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
| void | [SetCancelInputKey](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#af8fa6077ac6763f7ebd9a3adaf55252a) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
| void | [SetDeleteInputKey](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a3d0618d711d357477dd93c9a5b7df621) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
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
| bool | [IsLoadingSaves](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a0f7b97d134b1d21319c2ad41a5bf27e4) `[get, set]` |
| bool | [IsBusyWithAnAction](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a2de2b236b016426556d508f0e249851f) `[get, set]` |
| bool | [IsSearchAvailable](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a458a6d2e78d99553f5fbdd7a7ecc80ea) `[get, set]` |
| string | [SearchText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a9081d750e6f06071126922b8c1c52f0a) `[get, set]` |
| string | [SearchPlaceholderText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a6a36189992ff3143052b8337a85b9996) `[get, set]` |
| string | [VisualDisabledText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a8939b9b0416b7d6a18089fab90adaa7e) `[get, set]` |
| MBBindingList< [SavedGameGroupVM](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_group_v_m.html) > | [SaveGroups](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#aa24ddd627adc8a5b1539bca3c722f75b) `[get, set]` |
| [SavedGameVM](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html) | [CurrentSelectedSave](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a240fa4d9d22e517f4c67cbaded70d0d5) `[get, set]` |
| string | [CreateNewSaveSlotText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#ac22c1987e88109e0a73038eed9bc9e6f) `[get, set]` |
| string | [TitleText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#ad62a804c46e75dbfdf56874da50b1d56) `[get, set]` |
| string | [CancelText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a1f491d5ca047b459ec982b712abb249a) `[get, set]` |
| bool | [IsSaving](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a8279a6f47ab225d42a3c4a30163396bd) `[get, set]` |
| bool | [CanCreateNewSave](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#ac5035d0140894170af5c5550ba6b628e) `[get, set]` |
| bool | [IsVisualDisabled](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#af6e0c067a92041e437df271c25db6ff1) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [CreateNewSaveHint](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a00eb72a4e15149d9fb846a365b7448fc) `[get, set]` |
| bool | [IsActionEnabled](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a8e98f4ac4e7878dabfc6f639d7b2baeb) `[get, set]` |
| bool | [IsAnyItemSelected](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#ac21bbf7495309acaa9af8e9d89f04fd4) `[get, set]` |
| string | [DoneText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a6dfada8640008508d4293eae2e904a9a) `[get, set]` |
| string | [SaveLoadText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#addd69eaef3dfd8541d45a437ae1c7c88) `[get, set]` |
| [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#ac0b099d521417612be1da85adbb74b58) `[get, set]` |
| [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#abbf448a22b96d3f73cfb17fd2348856a) `[get, set]` |
| [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DeleteInputKey](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a53d4a0207598f1e485b30053dd8c6bc7) `[get, set]` |

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

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a09f1615ba0f5430f555c2f13e8938421)SaveLoadVM()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.SaveLoadVM | ( | bool | *isSaving*, |
|  |  | bool | *isCampaignMapOnStack* ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#ad1d3c69fa0e18fa0c6bb3b82e3cb00f1)Initialize()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| async void SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.Initialize | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a4eb90d27e398483335744d6c603366f0)RefreshValues()
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a59acb8a32c70be152bdfeb042a33aa8e)ExecuteCreateNewSaveGame()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.ExecuteCreateNewSaveGame | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a013f07c0e9fcf4d178e204cb6d2b9a65)ExecuteDone()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.ExecuteDone | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a7678a9b4bd094d6fdc7e99aa5b3498a9)ExecuteLoadSave()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.ExecuteLoadSave | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a59d614a3d17dfc14e9590e95be6fa7db)DeleteSelectedSave()
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.DeleteSelectedSave | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#af7c318aeafcfe9c9165352447a167d47)OnFinalize()
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#adb03e01d804dc4a577c3c086eccc9e85)SetDoneInputKey()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#af8fa6077ac6763f7ebd9a3adaf55252a)SetCancelInputKey()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a3d0618d711d357477dd93c9a5b7df621)SetDeleteInputKey()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.SetDeleteInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a0f7b97d134b1d21319c2ad41a5bf27e4)IsLoadingSaves
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.IsLoadingSaves | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a2de2b236b016426556d508f0e249851f)IsBusyWithAnAction
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.IsBusyWithAnAction | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a458a6d2e78d99553f5fbdd7a7ecc80ea)IsSearchAvailable
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.IsSearchAvailable | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a9081d750e6f06071126922b8c1c52f0a)SearchText
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.SearchText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a6a36189992ff3143052b8337a85b9996)SearchPlaceholderText
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.SearchPlaceholderText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a8939b9b0416b7d6a18089fab90adaa7e)VisualDisabledText
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.VisualDisabledText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#aa24ddd627adc8a5b1539bca3c722f75b)SaveGroups
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[SavedGameGroupVM](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_group_v_m.html)> SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.SaveGroups | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a240fa4d9d22e517f4c67cbaded70d0d5)CurrentSelectedSave
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SavedGameVM](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html) SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.CurrentSelectedSave | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#ac22c1987e88109e0a73038eed9bc9e6f)CreateNewSaveSlotText
-----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.CreateNewSaveSlotText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#ad62a804c46e75dbfdf56874da50b1d56)TitleText
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.TitleText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a1f491d5ca047b459ec982b712abb249a)CancelText
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.CancelText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a8279a6f47ab225d42a3c4a30163396bd)IsSaving
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.IsSaving | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#ac5035d0140894170af5c5550ba6b628e)CanCreateNewSave
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.CanCreateNewSave | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#af6e0c067a92041e437df271c25db6ff1)IsVisualDisabled
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.IsVisualDisabled | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a00eb72a4e15149d9fb846a365b7448fc)CreateNewSaveHint
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.CreateNewSaveHint | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a8e98f4ac4e7878dabfc6f639d7b2baeb)IsActionEnabled
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.IsActionEnabled | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#ac21bbf7495309acaa9af8e9d89f04fd4)IsAnyItemSelected
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.IsAnyItemSelected | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a6dfada8640008508d4293eae2e904a9a)DoneText
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.DoneText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#addd69eaef3dfd8541d45a437ae1c7c88)SaveLoadText
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.SaveLoadText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#ac0b099d521417612be1da85adbb74b58)DoneInputKey
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.DoneInputKey | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#abbf448a22b96d3f73cfb17fd2348856a)CancelInputKey
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.CancelInputKey | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_save_load_v_m.html#a53d4a0207598f1e485b30053dd8c6bc7)DeleteInputKey
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_sand_box_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) SandBox.ViewModelCollection.SaveLoad.SaveLoadVM.DeleteInputKey | | getset |

