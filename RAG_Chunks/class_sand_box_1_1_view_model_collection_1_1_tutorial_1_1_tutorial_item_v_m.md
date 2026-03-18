--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html ---

SandBox.ViewModelCollection.Tutorial.TutorialItemVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Types | |
| enum | [ItemPlacements](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a381f7a32604184fa266568352e00a2eb) {     [Left](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a381f7a32604184fa266568352e00a2eba945d5e233cf7d6240f6b783b36a374ff) ,     [Right](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a381f7a32604184fa266568352e00a2eba92b09c7c48c520c3c55e497875da437c) ,     [Top](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a381f7a32604184fa266568352e00a2ebaa4ffdcf0dc1f31b9acaf295d75b51d00) ,     [Bottom](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a381f7a32604184fa266568352e00a2eba2ad9d63b69c4a10a5cc9cad923133bc4) ,     [TopLeft](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a381f7a32604184fa266568352e00a2ebab32beb056fbfe36afbabc6c88c81ab36) ,     [TopRight](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a381f7a32604184fa266568352e00a2eba1d85a557894c340c318493f33bfa8efb) ,     [BottomLeft](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a381f7a32604184fa266568352e00a2eba98e5a1c44509157ebcaf46c515c78875) ,     [BottomRight](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a381f7a32604184fa266568352e00a2eba9146bfc669fddc88db2c4d89297d0e9a) ,     [Center](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a381f7a32604184fa266568352e00a2eba4f1f6016fc9f3f2353c0cc7c67b292bd)   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TutorialItemVM](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a963da1c6a9e23fb2e46a5750fc89b61e) () |
| void | [Init](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a521cdc59a85a374f2702f45145c1d3f5) (string tutorialTypeId, bool requiresMouse, Action onFinishTutorial) |
| override void | [RefreshValues](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a2ce9a17997f3692beb77b0738ad06a6e) () |
|  | Used for updating localized texts. |
| void | [CloseTutorialPanel](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#ad9e633a418b00a5468ad586df1d44c2d) () |
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
| Action< bool > | [SetIsActive](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#ad012f3335fcc88bc3d36d671f03f68f7) `[get]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DisableCurrentTutorialHint](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#abe42918565dbf15a7d95fc73b4a2d996) `[get, set]` |
| bool | [AreTutorialsEnabled](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a4046b0f5662f9b18c0a1522387210625) `[get, set]` |
| string | [TutorialsEnabledText](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#ac29199257f5fc6d01be65cd73a3a2b59) `[get, set]` |
| string | [TutorialTitleText](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#acbee823956d108a62c8b90105c584cd3) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DisableAllTutorialsHint](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a617341e336c993e03c2e331019c8bd0b) `[get, set]` |
| string | [TitleText](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a7a8310d8b0a6fd16752e839d91524380) `[get, set]` |
| string | [StepCountText](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a906b2a2ed14c41542563d5797387f25d) `[get, set]` |
| bool | [IsEnabled](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a00e884d9532c1485b941d38993cfa63f) `[get, set]` |
| string | [DescriptionText](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#ade6358e4e4d8d4f988cfe55c96bffbc2) `[get, set]` |
| string | [SoundId](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#aaf81eed0fb44affe83c045105d67c5e9) `[get, set]` |
| [ImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_image_identifier_v_m.html) | [CenterImage](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a0f37ef7bed00c06cacf2093e708ef4d0) `[get, set]` |
| bool | [RequiresMouse](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a802bc60c544bb1c887dfe2e46eb1a88a) `[get, set]` |

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

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a381f7a32604184fa266568352e00a2eb)ItemPlacements
-------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum [SandBox.ViewModelCollection.Tutorial.TutorialItemVM.ItemPlacements](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a381f7a32604184fa266568352e00a2eb) |

| Enumerator | |
| --- | --- |
| Left |  |
| Right |  |
| Top |  |
| Bottom |  |
| TopLeft |  |
| TopRight |  |
| BottomLeft |  |
| BottomRight |  |
| Center |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a963da1c6a9e23fb2e46a5750fc89b61e)TutorialItemVM()
---------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.ViewModelCollection.Tutorial.TutorialItemVM.TutorialItemVM | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a521cdc59a85a374f2702f45145c1d3f5)Init()
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tutorial.TutorialItemVM.Init | ( | string | *tutorialTypeId*, |
|  |  | bool | *requiresMouse*, |
|  |  | Action | *onFinishTutorial* ) |

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a2ce9a17997f3692beb77b0738ad06a6e)RefreshValues()
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void SandBox.ViewModelCollection.Tutorial.TutorialItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#ad9e633a418b00a5468ad586df1d44c2d)CloseTutorialPanel()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void SandBox.ViewModelCollection.Tutorial.TutorialItemVM.CloseTutorialPanel | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#ad012f3335fcc88bc3d36d671f03f68f7)SetIsActive
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Action<bool> SandBox.ViewModelCollection.Tutorial.TutorialItemVM.SetIsActive | | get |

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#abe42918565dbf15a7d95fc73b4a2d996)DisableCurrentTutorialHint
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) SandBox.ViewModelCollection.Tutorial.TutorialItemVM.DisableCurrentTutorialHint | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a4046b0f5662f9b18c0a1522387210625)AreTutorialsEnabled
------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Tutorial.TutorialItemVM.AreTutorialsEnabled | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#ac29199257f5fc6d01be65cd73a3a2b59)TutorialsEnabledText
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tutorial.TutorialItemVM.TutorialsEnabledText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#acbee823956d108a62c8b90105c584cd3)TutorialTitleText
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tutorial.TutorialItemVM.TutorialTitleText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a617341e336c993e03c2e331019c8bd0b)DisableAllTutorialsHint
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) SandBox.ViewModelCollection.Tutorial.TutorialItemVM.DisableAllTutorialsHint | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a7a8310d8b0a6fd16752e839d91524380)TitleText
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tutorial.TutorialItemVM.TitleText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a906b2a2ed14c41542563d5797387f25d)StepCountText
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tutorial.TutorialItemVM.StepCountText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a00e884d9532c1485b941d38993cfa63f)IsEnabled
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Tutorial.TutorialItemVM.IsEnabled | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#ade6358e4e4d8d4f988cfe55c96bffbc2)DescriptionText
--------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tutorial.TutorialItemVM.DescriptionText | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#aaf81eed0fb44affe83c045105d67c5e9)SoundId
------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Tutorial.TutorialItemVM.SoundId | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a0f37ef7bed00c06cacf2093e708ef4d0)CenterImage
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_image_identifier_v_m.html) SandBox.ViewModelCollection.Tutorial.TutorialItemVM.CenterImage | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_item_v_m.html#a802bc60c544bb1c887dfe2e46eb1a88a)RequiresMouse
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Tutorial.TutorialItemVM.RequiresMouse | | getset |

