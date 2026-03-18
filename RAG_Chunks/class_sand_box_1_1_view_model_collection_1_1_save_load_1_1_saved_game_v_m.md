--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html ---

SandBox.ViewModelCollection.SaveLoad.SavedGameVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SavedGameVM](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a4b7ee445c521255ba0ecd418441e0ced) (SaveGameFileInfo save, bool isSaving, Action< SavedGameVM > onDelete, Action< SavedGameVM > onSelection, Action onCancelLoadSave, Action onDone, bool isCorruptedSave=false, bool isIronman=false) |
| override void | [RefreshValues](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a70e25a59605d1212280ef829ca43baf0) () |
|  | Used for updating localized texts. |
| void | [ExecuteSaveLoad](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#af769a1af24f90befc564f4fc5b82eeef) () |
| void | [ExecuteUpdate](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ab742caa0951b6a63c524542938649c97) () |
| void | [ExecuteDelete](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a938705744354182a5876782079fdf51e) () |
| void | [ExecuteSelection](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ade54fe4fbc926aa528b816f8058cf817) () |
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
| Properties | |
| SaveGameFileInfo | [Save](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ae8efee3bd1c121a4661ff1fa3a7a9d72) `[get]` |
| bool | [RequiresInquiryOnLoad](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ac8294c9969bb179ddd447f262533247c) `[get]` |
| bool | [IsModuleDiscrepancyDetected](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ac7ba509306dd6177eb407d58748f37d0) `[get]` |
|  | Means the saved game's modules are not the same as the currently loaded modules. Does not check versions of the modules. |
| MBBindingList< [SavedGamePropertyVM](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_property_v_m.html) > | [SavedGameProperties](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ad0d9e6dcea3b820f68780e328ae0d5ad) `[get, set]` |
| MBBindingList< [SavedGameModuleInfoVM](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_module_info_v_m.html) > | [LoadedModulesInSave](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a63f4b05aa3330b5bcac707eb6b2b8b05) `[get, set]` |
| string | [SaveVersionAsString](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a459c8c3a1c87fb57e32ae403cb631443) `[get, set]` |
| string | [DeleteText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ab30a42125920c91a736e572e2217f3ce) `[get, set]` |
| bool | [IsSelected](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ad95101455208b7ef6761ec592973a284) `[get, set]` |
| bool | [IsCorrupted](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#afc1cc8b911e63e223d0f0753923cfc28) `[get, set]` |
| string | [BannerTextCode](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#aa2f7535e0ac5cab091a4ae45a572c974) `[get, set]` |
| string | [SaveLoadText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a75217ddaa038746d51175e73907a3bf8) `[get, set]` |
| string | [OverrideSaveText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#aeb4177122014a6ec2b987d92016844db) `[get, set]` |
| string | [UpdateSaveText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a2210ef5d831a858b6ab9836ffa112d9c) `[get, set]` |
| string | [ModulesText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ab870e0a48955cd2faa4f74b6bf46d0fc) `[get, set]` |
| string | [CorruptedSaveText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a8608a0519840cf45c35d958b63385197) `[get, set]` |
| string | [NameText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a083fb32b7cd1fa0e412e06c075df6d0b) `[get, set]` |
| string | [GameTimeText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ad8e8cb18e1e820df9b431fab11cd06cd) `[get, set]` |
| string | [CharacterNameText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a8c9008031dd355a149b6ed3452e8b43d) `[get, set]` |
| string | [MainHeroVisualCode](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a4b49ed52e408c3bef80e360af16b159b) `[get, set]` |
| [CharacterViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html) | [CharacterVisual](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a8c097490b8acf6e552f92b9cfc330234) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [ClanBanner](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ae3094178dcac0560d861afedb07ee80d) `[get, set]` |
| string | [RealTimeText1](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a1be574d9250ca4a6043b5aa79fc83954) `[get, set]` |
| string | [RealTimeText2](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a35e4fce633e4f1093dacd167eb0a789d) `[get, set]` |
| string | [LevelText](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a0f65a12f71a8d39f0379b86f46b1bf0d) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DateTimeHint](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a6d6893b34f79635a2dac1535b4aa995b) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [UpdateButtonHint](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a8248baa07a6d571eeda551169edc6579) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DisabledReasonHint](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#afd2bf0358c4f65e204b31436e5b91dba) `[get, set]` |
| bool | [IsFilteredOut](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ac20f3c0d1e6e9cc975431677fa811d55) `[get, set]` |
| bool | [IsDisabled](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a68bd8c14de2d06fe24b90c08e9be5648) `[get, set]` |

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

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a4b7ee445c521255ba0ecd418441e0ced)SavedGameVM()
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| SandBox.ViewModelCollection.SaveLoad.SavedGameVM.SavedGameVM | ( | SaveGameFileInfo | *save*, |
|  |  | bool | *isSaving*, |
|  |  | Action< SavedGameVM > | *onDelete*, |
|  |  | Action< SavedGameVM > | *onSelection*, |
|  |  | Action | *onCancelLoadSave*, |
|  |  | Action | *onDone*, |
|  |  | bool | *isCorruptedSave* = false, |
|  |  | bool | *isIronman* = false ) |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a70e25a59605d1212280ef829ca43baf0)RefreshValues()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.SaveLoad.SavedGameVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#af769a1af24f90befc564f4fc5b82eeef)ExecuteSaveLoad()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SaveLoad.SavedGameVM.ExecuteSaveLoad | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ab742caa0951b6a63c524542938649c97)ExecuteUpdate()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SaveLoad.SavedGameVM.ExecuteUpdate | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a938705744354182a5876782079fdf51e)ExecuteDelete()
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SaveLoad.SavedGameVM.ExecuteDelete | ( |  | ) |  |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ade54fe4fbc926aa528b816f8058cf817)ExecuteSelection()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.SaveLoad.SavedGameVM.ExecuteSelection | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ae8efee3bd1c121a4661ff1fa3a7a9d72)Save
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SaveGameFileInfo SandBox.ViewModelCollection.SaveLoad.SavedGameVM.Save | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ac8294c9969bb179ddd447f262533247c)RequiresInquiryOnLoad
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SavedGameVM.RequiresInquiryOnLoad | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ac7ba509306dd6177eb407d58748f37d0)IsModuleDiscrepancyDetected
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SavedGameVM.IsModuleDiscrepancyDetected | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ad0d9e6dcea3b820f68780e328ae0d5ad)SavedGameProperties
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[SavedGamePropertyVM](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_property_v_m.html)> SandBox.ViewModelCollection.SaveLoad.SavedGameVM.SavedGameProperties | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a63f4b05aa3330b5bcac707eb6b2b8b05)LoadedModulesInSave
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[SavedGameModuleInfoVM](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_module_info_v_m.html)> SandBox.ViewModelCollection.SaveLoad.SavedGameVM.LoadedModulesInSave | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a459c8c3a1c87fb57e32ae403cb631443)SaveVersionAsString
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.SaveVersionAsString | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ab30a42125920c91a736e572e2217f3ce)DeleteText
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.DeleteText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ad95101455208b7ef6761ec592973a284)IsSelected
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SavedGameVM.IsSelected | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#afc1cc8b911e63e223d0f0753923cfc28)IsCorrupted
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SavedGameVM.IsCorrupted | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#aa2f7535e0ac5cab091a4ae45a572c974)BannerTextCode
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.BannerTextCode | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a75217ddaa038746d51175e73907a3bf8)SaveLoadText
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.SaveLoadText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#aeb4177122014a6ec2b987d92016844db)OverrideSaveText
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.OverrideSaveText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a2210ef5d831a858b6ab9836ffa112d9c)UpdateSaveText
-----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.UpdateSaveText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ab870e0a48955cd2faa4f74b6bf46d0fc)ModulesText
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.ModulesText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a8608a0519840cf45c35d958b63385197)CorruptedSaveText
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.CorruptedSaveText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a083fb32b7cd1fa0e412e06c075df6d0b)NameText
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.NameText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ad8e8cb18e1e820df9b431fab11cd06cd)GameTimeText
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.GameTimeText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a8c9008031dd355a149b6ed3452e8b43d)CharacterNameText
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.CharacterNameText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a4b49ed52e408c3bef80e360af16b159b)MainHeroVisualCode
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.MainHeroVisualCode | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a8c097490b8acf6e552f92b9cfc330234)CharacterVisual
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html) SandBox.ViewModelCollection.SaveLoad.SavedGameVM.CharacterVisual | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ae3094178dcac0560d861afedb07ee80d)ClanBanner
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) SandBox.ViewModelCollection.SaveLoad.SavedGameVM.ClanBanner | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a1be574d9250ca4a6043b5aa79fc83954)RealTimeText1
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.RealTimeText1 | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a35e4fce633e4f1093dacd167eb0a789d)RealTimeText2
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.RealTimeText2 | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a0f65a12f71a8d39f0379b86f46b1bf0d)LevelText
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.SaveLoad.SavedGameVM.LevelText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a6d6893b34f79635a2dac1535b4aa995b)DateTimeHint
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) SandBox.ViewModelCollection.SaveLoad.SavedGameVM.DateTimeHint | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a8248baa07a6d571eeda551169edc6579)UpdateButtonHint
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) SandBox.ViewModelCollection.SaveLoad.SavedGameVM.UpdateButtonHint | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#afd2bf0358c4f65e204b31436e5b91dba)DisabledReasonHint
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) SandBox.ViewModelCollection.SaveLoad.SavedGameVM.DisabledReasonHint | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#ac20f3c0d1e6e9cc975431677fa811d55)IsFilteredOut
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SavedGameVM.IsFilteredOut | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_save_load_1_1_saved_game_v_m.html#a68bd8c14de2d06fe24b90c08e9be5648)IsDisabled
-------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.SaveLoad.SavedGameVM.IsDisabled | | getset |

