--- SOURCE: class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html ---

SandBox.ViewModelCollection.Nameplate.NameplateVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

Inherited by [SandBox.ViewModelCollection.Nameplate.PartyNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html), and [SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [NameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a555aed693caf5a959be646f772d860b1) () |
| virtual void | [RefreshDynamicProperties](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a847688a81bfee28ed3f2d6717b162458) (bool forceUpdate) |
| virtual void | [RefreshPosition](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a92ea64508163ebed07cdddea2fe8aed6) () |
| virtual void | [RefreshRelationStatus](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a5196fa11609dd40be7f0358de69498ee) () |
| virtual void | [RefreshTutorialStatus](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a15f901a0f8e2736045932aaf23cf0919) (string newTutorialHighlightElementID) |
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
| Protected Types | |
| enum | [NameplateSize](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851) {     [Small](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851a2660064e68655415da2628c2ae2f7592) = 0 ,     [Normal](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851a960b44c579bc2f6818d2daaf9e4c16f0) ,     [Big](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851ad491538da818a2ba11a3195ba035cfd3)   } |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [OnTutorialNotificationElementChanged](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a89978d373bd37016107518fcd6ccc7ed) ([TutorialNotificationElementChangeEvent](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_notification_element_change_event.html) obj) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Protected Attributes | |
| bool | [\_bindIsTargetedByTutorial](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a2a5d76eadfcef4d4c8fe4a87442a4368) |

|  |  |
| --- | --- |
| Properties | |
| double | [Scale](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a5d3dc2225dd7b164c5c5e2df769c239f) `[get, set]` |
| int | [NameplateOrder](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#ad54345e32e89e14af5fa5fbf429496ee) `[get, set]` |
| string | [FactionColor](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#accaefa9664bfd1218bdbb48cfd904b80) `[get, set]` |
| float | [DistanceToCamera](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a52779c8f617c46333429959a24017ba3) `[get, set]` |
| bool | [IsVisibleOnMap](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#abcda4f4f0b3b5c57d3aff2df3247b501) `[get, set]` |
| bool | [IsTargetedByTutorial](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a5bdf373585f449704cc3835ca1c4a915) `[get, set]` |
| [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) | [Position](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#af3d7e1f26eda35561c09398af08e1dec) `[get, set]` |
| bool | [CanParley](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#af176d6782bf1eac58f369e9fa91a67a7) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
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

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851)NameplateSize
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | enum [SandBox.ViewModelCollection.Nameplate.NameplateVM.NameplateSize](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#aaf92261788f69b391875b2cf3f654851) | | protected |

| Enumerator | |
| --- | --- |
| Small |  |
| Normal |  |
| Big |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a555aed693caf5a959be646f772d860b1)NameplateVM()
---------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| SandBox.ViewModelCollection.Nameplate.NameplateVM.NameplateVM | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a89978d373bd37016107518fcd6ccc7ed)OnTutorialNotificationElementChanged()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void SandBox.ViewModelCollection.Nameplate.NameplateVM.OnTutorialNotificationElementChanged | ( | [TutorialNotificationElementChangeEvent](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_tutorial_notification_element_change_event.html) | *obj* | ) |  | | protected |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a847688a81bfee28ed3f2d6717b162458)RefreshDynamicProperties()
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.ViewModelCollection.Nameplate.NameplateVM.RefreshDynamicProperties | ( | bool | *forceUpdate* | ) |  | | virtual |

Reimplemented in [SandBox.ViewModelCollection.Nameplate.PartyNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#a349c6667c2a065521176e6158087af65), [SandBox.ViewModelCollection.Nameplate.PartyPlayerNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_player_nameplate_v_m.html#ae00b0231b5728b31750ee397e53051c9), and [SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#acb8ac69096ccb434e715fd9375a6a5b5).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a92ea64508163ebed07cdddea2fe8aed6)RefreshPosition()
-------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.ViewModelCollection.Nameplate.NameplateVM.RefreshPosition | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.ViewModelCollection.Nameplate.PartyNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#aaa9a34a28364c3c933c90abb98c4a6ca), [SandBox.ViewModelCollection.Nameplate.PartyPlayerNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_player_nameplate_v_m.html#ad0f8861ae9a8921a479dd68835e5e499), and [SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a43e6faac9fcf5995d4dbdbaa891ddd98).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a5196fa11609dd40be7f0358de69498ee)RefreshRelationStatus()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void SandBox.ViewModelCollection.Nameplate.NameplateVM.RefreshRelationStatus | ( |  | ) |  | | virtual |

Reimplemented in [SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a2f5c5fe13e448a2477a86d15939c4811).

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a15f901a0f8e2736045932aaf23cf0919)RefreshTutorialStatus()
-------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void SandBox.ViewModelCollection.Nameplate.NameplateVM.RefreshTutorialStatus | ( | string | *newTutorialHighlightElementID* | ) |  | | virtual |

Reimplemented in [SandBox.ViewModelCollection.Nameplate.PartyNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_party_nameplate_v_m.html#ab26cf13dea711dd40221cbd8784fb8cf), and [SandBox.ViewModelCollection.Nameplate.SettlementNameplateVM](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_settlement_nameplate_v_m.html#a32b2b7523279edc8e74f8aa284bb4873).

Member Data Documentation
-------------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a2a5d76eadfcef4d4c8fe4a87442a4368)\_bindIsTargetedByTutorial
----------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.NameplateVM.\_bindIsTargetedByTutorial | | protected |

Property Documentation
----------------------

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a5d3dc2225dd7b164c5c5e2df769c239f)Scale
-------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double SandBox.ViewModelCollection.Nameplate.NameplateVM.Scale | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#ad54345e32e89e14af5fa5fbf429496ee)NameplateOrder
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int SandBox.ViewModelCollection.Nameplate.NameplateVM.NameplateOrder | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#accaefa9664bfd1218bdbb48cfd904b80)FactionColor
--------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string SandBox.ViewModelCollection.Nameplate.NameplateVM.FactionColor | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a52779c8f617c46333429959a24017ba3)DistanceToCamera
------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float SandBox.ViewModelCollection.Nameplate.NameplateVM.DistanceToCamera | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#abcda4f4f0b3b5c57d3aff2df3247b501)IsVisibleOnMap
----------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.NameplateVM.IsVisibleOnMap | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#a5bdf373585f449704cc3835ca1c4a915)IsTargetedByTutorial
----------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.NameplateVM.IsTargetedByTutorial | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#af3d7e1f26eda35561c09398af08e1dec)Position
----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [Vec2](struct_tale_worlds_1_1_library_1_1_vec2.html) SandBox.ViewModelCollection.Nameplate.NameplateVM.Position | | getset |

[◆](class_sand_box_1_1_view_model_collection_1_1_nameplate_1_1_nameplate_v_m.html#af176d6782bf1eac58f369e9fa91a67a7)CanParley
-----------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool SandBox.ViewModelCollection.Nameplate.NameplateVM.CanParley | | getset |

