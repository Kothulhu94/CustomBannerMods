--- SOURCE: class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html ---

TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [AgentInteractionInterfaceVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#af75f034587d628f4890e63b5326c9d34) ([Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) mission) |
| override void | [RefreshValues](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#abbf208cc8e27992075fb33bb4914f7f5) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a2bd7fcc92d90b8219544db8e3e2bf7b0) () |
| void | [OnFocusedHealthChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a906fc66a69fccf4d247b2c392b7a85cf) ([IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) focusable, float healthPercentage, bool hideHealthbarWhenFull) |
| void | [OnActiveMissionHintChanged](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#ac4b00700493a2a2ae8fe71ddb4b24c05) ([MissionHint](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_hints_1_1_mission_hint.html) previousHint, [MissionHint](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_hints_1_1_mission_hint.html) newHint) |
| void | [AddSecondaryMessage](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a2a85603c796b4a7ba825db33983941f6) ([MissionInteractionItemBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_11271db2dbb91901232b42018fbc924e6.html) message) |
| bool | [RemoveSecondaryMessage](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a4508de42914448ec969a8b64caf62b80) ([MissionInteractionItemBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_11271db2dbb91901232b42018fbc924e6.html) message) |
| bool | [HasSecondaryInteractionMessage](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#ac65f660ca5b1ab7841575fe66768d8ed) ([MissionInteractionItemBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_11271db2dbb91901232b42018fbc924e6.html) message) |
| void | [ResetFocus](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a1f4030b78f3a00d92d605a9e7a54cc67) () |
| void | [SetForcedInteractionTexts](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#ab99d4d865f12cff477d498b4dcde8cfd) ([TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text1, bool isDisabled1, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) text2, bool isDisabled2) |
| void | [ClearForcedInteractionTexts](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#aecffdec37ca03c2d15ae577d9fd462fc) () |
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
| int | [TargetHealth](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a406da4359886ad7eee2b2e24bcccee9b) `[get, set]` |
| bool | [ShowHealthBar](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a6d78acd0d52d8bd496e184178d62c655) `[get, set]` |
| MBBindingList< [MissionPrimaryInteractionItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_160f5830c08e7f3ad4354c6e372f52431.html) > | [PrimaryInteractionMessages](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a514c7ece0ad9c9f65474fc304def6490) `[get, set]` |
| MBBindingList< [MissionInteractionItemBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_11271db2dbb91901232b42018fbc924e6.html) > | [SecondaryInteractionMessages](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a23d5713939e7deb725e3b4c1026d8452) `[get, set]` |
| string | [BackgroundColor](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a68152d2205064fb99f1ac64622fef933) `[get, set]` |
| string | [TextColor](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a079fed4de7d5d4bd44b6be39e4f1b19e) `[get, set]` |
| bool | [IsActive](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a5a96d71ea1f82101aa96eb9fcabf84f6) `[get, set]` |
| bool | [HasSecondaryMessages](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#aa0aa925b62b96691ee44b86fd30a25ee) `[get, set]` |
| bool | [DisplayInteractionText](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a36a3d1e27b59bd8794ba9e8d7ecef25e) `[get, set]` |
| MBBindingList< [MissionPrimaryInteractionItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_160f5830c08e7f3ad4354c6e372f52431.html) > | [ForcedInteractionMessages](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#afec62417196ff69e9b06eaf68c43b930) `[get, set]` |
| bool | [HasForcedMessages](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#ab17f8d5e2b3e99468680d1cb696df27b) `[get, set]` |

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

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#af75f034587d628f4890e63b5326c9d34)AgentInteractionInterfaceVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.AgentInteractionInterfaceVM | ( | [Mission](class_tale_worlds_1_1_mount_and_blade_1_1_mission.html) | *mission* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#abbf208cc8e27992075fb33bb4914f7f5)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a2bd7fcc92d90b8219544db8e3e2bf7b0)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a906fc66a69fccf4d247b2c392b7a85cf)OnFocusedHealthChanged()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.OnFocusedHealthChanged | ( | [IFocusable](interface_tale_worlds_1_1_mount_and_blade_1_1_i_focusable.html) | *focusable*, |
|  |  | float | *healthPercentage*, |
|  |  | bool | *hideHealthbarWhenFull* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#ac4b00700493a2a2ae8fe71ddb4b24c05)OnActiveMissionHintChanged()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.OnActiveMissionHintChanged | ( | [MissionHint](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_hints_1_1_mission_hint.html) | *previousHint*, |
|  |  | [MissionHint](class_tale_worlds_1_1_mount_and_blade_1_1_missions_1_1_hints_1_1_mission_hint.html) | *newHint* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a2a85603c796b4a7ba825db33983941f6)AddSecondaryMessage()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.AddSecondaryMessage | ( | [MissionInteractionItemBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_11271db2dbb91901232b42018fbc924e6.html) | *message* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a4508de42914448ec969a8b64caf62b80)RemoveSecondaryMessage()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.RemoveSecondaryMessage | ( | [MissionInteractionItemBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_11271db2dbb91901232b42018fbc924e6.html) | *message* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#ac65f660ca5b1ab7841575fe66768d8ed)HasSecondaryInteractionMessage()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| bool TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.HasSecondaryInteractionMessage | ( | [MissionInteractionItemBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_11271db2dbb91901232b42018fbc924e6.html) | *message* | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a1f4030b78f3a00d92d605a9e7a54cc67)ResetFocus()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.ResetFocus | ( |  | ) |  |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#ab99d4d865f12cff477d498b4dcde8cfd)SetForcedInteractionTexts()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.SetForcedInteractionTexts | ( | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text1*, |
|  |  | bool | *isDisabled1*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *text2*, |
|  |  | bool | *isDisabled2* ) |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#aecffdec37ca03c2d15ae577d9fd462fc)ClearForcedInteractionTexts()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.ClearForcedInteractionTexts | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a406da4359886ad7eee2b2e24bcccee9b)TargetHealth
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.TargetHealth | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a6d78acd0d52d8bd496e184178d62c655)ShowHealthBar
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.ShowHealthBar | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a514c7ece0ad9c9f65474fc304def6490)PrimaryInteractionMessages
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[MissionPrimaryInteractionItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_160f5830c08e7f3ad4354c6e372f52431.html)> TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.PrimaryInteractionMessages | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a23d5713939e7deb725e3b4c1026d8452)SecondaryInteractionMessages
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[MissionInteractionItemBaseVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_11271db2dbb91901232b42018fbc924e6.html)> TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.SecondaryInteractionMessages | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a68152d2205064fb99f1ac64622fef933)BackgroundColor
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.BackgroundColor | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a079fed4de7d5d4bd44b6be39e4f1b19e)TextColor
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.TextColor | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a5a96d71ea1f82101aa96eb9fcabf84f6)IsActive
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.IsActive | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#aa0aa925b62b96691ee44b86fd30a25ee)HasSecondaryMessages
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.HasSecondaryMessages | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#a36a3d1e27b59bd8794ba9e8d7ecef25e)DisplayInteractionText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.DisplayInteractionText | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#afec62417196ff69e9b06eaf68c43b930)ForcedInteractionMessages
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[MissionPrimaryInteractionItemVM](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_160f5830c08e7f3ad4354c6e372f52431.html)> TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.ForcedInteractionMessages | | getset |

[◆](class_tale_worlds_1_1_mount_and_blade_1_1_view_model_collection_1_1_missions_1_1_interaction_1_16936cb0d041564cce2bd1d2e6b7daa08.html#ab17f8d5e2b3e99468680d1cb696df27b)HasForcedMessages
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.MountAndBlade.ViewModelCollection.Missions.Interaction.AgentInteractionInterfaceVM.HasForcedMessages | | getset |

