--- SOURCE: class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html ---

TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SceneNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#aa794e1fec805c6bc64b11e9813ee9c6c) (Action onPositiveTrigger, Action closeNotification, Func< string > getContinueInputText) |
| override void | [RefreshValues](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#ad9a6e871ea444b6d1112a5e887fa73f9) () |
|  | Used for updating localized texts. |
| void | [CreateNotification](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a805a9c25a18fad2968e5285f64c6ba9f) ([SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html) data) |
| void | [ClearData](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a1d55e14332ff03997cf132c49a01ae3a) () |
| void | [ExecuteAffirmativeProcess](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a20d1a8941937c970e23247adf6deb4d5) () |
| void | [ExecuteClose](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a72f1946f3574aee0433da57084cbe317) () |
| void | [ExecuteNegativeProcess](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#afdda66cdff33bbee004838eaa12d83fb) () |
| override void | [OnFinalize](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a173f9d074ed05d4102c491148daadeff) () |
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
| [SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html) | [ActiveData](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a619105b0bf16a436bc9007d54fc88457) `[get]` |
| bool | [IsShown](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a5613c450887a16f204e17236a8fe612c) `[get, set]` |
| bool | [IsReady](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#ab26d5c9bce038dad6b4676659e48fec7) `[get, set]` |
| string | [ClickToContinueText](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a59e9c593fb24192bb2e812deaea88083) `[get, set]` |
| string | [TitleText](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a8df41fb6b25882cf48a930c10352e7e6) `[get]` |
| string | [AffirmativeDescription](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a569c60beb3b7d86031b699f37b84243f) `[get]` |
| string | [CancelDescription](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a84f3b6ec2a8fc0122fe7bab86e5b49bc) `[get]` |
| string | [SceneID](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#ab2946c470f597a22cf66482f477f52d2) `[get]` |
| string | [ButtonOkLabel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a6f86094c58cb511d5785dda2c821f0fc) `[get]` |
| string | [ButtonCancelLabel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a947421497be472c5131410c8b8c69937) `[get]` |
| bool | [IsButtonOkShown](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#ab26bb88472dfdf6a13d5c417216512c1) `[get]` |
| bool | [IsButtonCancelShown](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a802f5a29c915a46366ad3b0cbb05faeb) `[get]` |
| string | [AffirmativeTitleText](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a432c5b0156a1eaed8c7872d170836240) `[get]` |
| string | [NegativeTitleText](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a92b6a92d0425fa5e3043d6faf9840776) `[get]` |
| object | [Scene](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#add71b4b8aabf899926081784c0002aaf) `[get, set]` |
| float | [EndProgress](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a72687ce43a500ef06e3fed3dfb0bea22) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [AffirmativeHint](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a1a3a75c83669720ec3ebf7f6d4f02095) `[get, set]` |

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

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#aa794e1fec805c6bc64b11e9813ee9c6c)SceneNotificationVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.SceneNotificationVM | ( | Action | *onPositiveTrigger*, |
|  |  | Action | *closeNotification*, |
|  |  | Func< string > | *getContinueInputText* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#ad9a6e871ea444b6d1112a5e887fa73f9)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a805a9c25a18fad2968e5285f64c6ba9f)CreateNotification()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.CreateNotification | ( | [SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html) | *data* | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a1d55e14332ff03997cf132c49a01ae3a)ClearData()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.ClearData | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a20d1a8941937c970e23247adf6deb4d5)ExecuteAffirmativeProcess()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.ExecuteAffirmativeProcess | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a72f1946f3574aee0433da57084cbe317)ExecuteClose()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.ExecuteClose | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#afdda66cdff33bbee004838eaa12d83fb)ExecuteNegativeProcess()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.ExecuteNegativeProcess | ( |  | ) |  |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a173f9d074ed05d4102c491148daadeff)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a619105b0bf16a436bc9007d54fc88457)ActiveData
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SceneNotificationData](class_tale_worlds_1_1_core_1_1_scene_notification_data.html) TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.ActiveData | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a5613c450887a16f204e17236a8fe612c)IsShown
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.IsShown | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#ab26d5c9bce038dad6b4676659e48fec7)IsReady
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.IsReady | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a59e9c593fb24192bb2e812deaea88083)ClickToContinueText
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.ClickToContinueText | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a8df41fb6b25882cf48a930c10352e7e6)TitleText
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.TitleText | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a569c60beb3b7d86031b699f37b84243f)AffirmativeDescription
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.AffirmativeDescription | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a84f3b6ec2a8fc0122fe7bab86e5b49bc)CancelDescription
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.CancelDescription | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#ab2946c470f597a22cf66482f477f52d2)SceneID
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.SceneID | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a6f86094c58cb511d5785dda2c821f0fc)ButtonOkLabel
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.ButtonOkLabel | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a947421497be472c5131410c8b8c69937)ButtonCancelLabel
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.ButtonCancelLabel | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#ab26bb88472dfdf6a13d5c417216512c1)IsButtonOkShown
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.IsButtonOkShown | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a802f5a29c915a46366ad3b0cbb05faeb)IsButtonCancelShown
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.IsButtonCancelShown | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a432c5b0156a1eaed8c7872d170836240)AffirmativeTitleText
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.AffirmativeTitleText | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a92b6a92d0425fa5e3043d6faf9840776)NegativeTitleText
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.NegativeTitleText | | get |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#add71b4b8aabf899926081784c0002aaf)Scene
------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.Scene | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a72687ce43a500ef06e3fed3dfb0bea22)EndProgress
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | float TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.EndProgress | | getset |

[◆](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_scene_notification_v_m.html#a1a3a75c83669720ec3ebf7f6d4f02095)AffirmativeHint
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.Core.ViewModelCollection.Information.SceneNotificationVM.AffirmativeHint | | getset |

