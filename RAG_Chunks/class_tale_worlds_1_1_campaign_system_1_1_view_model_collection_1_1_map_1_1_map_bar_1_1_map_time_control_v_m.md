--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapTimeControlVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#afa6feb2ffe7758f82d87ecc2e046c167) (Func< [MapBarShortcuts](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_shortcuts.html) > getMapBarShortcuts, Action onTimeFlowStateChange, Action onCameraResetted) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#afe9b48511236ffb7af553010e6e4311e) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a8821bb9178d1e01429ce88479c5b3d2b) () |
| void | [Tick](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a945ffcfa6fda29f2206634ece61b58df) () |
| void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a35ee26509b3e3a305d710d886389406c) () |
| void | [ExecuteTimeControlChange](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a52acbfc25818275a08867d86edaa02b7) (int selectedTimeSpeed) |
| void | [ExecuteResetCamera](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a77bae3ca90123130c40af119626bbb97) () |
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
| bool | [IsInBattleSimulation](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a33790d8165151f1038c541fae6e771a1) `[get, set]` |
| bool | [IsInRecruitment](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a5019feeb2b7b7f25cf8256d926f8a4d4) `[get, set]` |
| bool | [IsEncyclopediaOpen](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a711e50e2a2c5e77130a909069dc40d90) `[get, set]` |
| bool | [IsInArmyManagement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a1224ef2650801ac719d2a5e680b8af54) `[get, set]` |
| bool | [IsInTownManagement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a47dc6380442163de6b7b8a95ac6f1557) `[get, set]` |
| bool | [IsInHideoutTroopManage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a81e66c0c3f8bfdd26203b426ddfc8250) `[get, set]` |
| bool | [IsInMap](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#ac80a0c1d0a6fdb9a82dd8574c4cb8da8) `[get, set]` |
| bool | [IsInCampaignOptions](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a557aa075160a3b9f6c448602275f0cd0) `[get, set]` |
| bool | [IsEscapeMenuOpened](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#abab7fd364240628e8d2ee69a04be6dc7) `[get, set]` |
| bool | [IsMarriageOfferPopupActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#ad19d657a18d46789b5ebe6c52ccee9a3) `[get, set]` |
| bool | [IsHeirSelectionPopupActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a8e77e57102a74274af1bf81fce575269) `[get, set]` |
| bool | [IsMapCheatsActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#af0789e9cac985d7e4343bd7f9daf6921) `[get, set]` |
| bool | [IsMapIncidentActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a765ebe8195811dd85c85b1c6b0dbf02e) `[get, set]` |
| bool | [IsOverlayContextMenuEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#ad8db7c4fe4f994b0b5c6733990397085) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [TimeOfDayHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a251c34b0a6ca1eb1023cc8236f2457c2) `[get, set]` |
| bool | [IsCurrentlyPausedOnMap](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#ab405d1f20aaaf5df29df8dbb209474df) `[get, set]` |
| bool | [IsCenterPanelEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a142a6ff1901b43addd71fe022be9d4d0) `[get, set]` |
| double | [Time](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a656fcc649451d84c7ccf16378e0029c9) `[get, set]` |
| string | [PausedText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a2da6409f06e091813916ecff85b8fa04) `[get, set]` |
| string | [Date](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a6ebf0107615acc190c2f809e30d3b94c) `[get, set]` |
| int | [TimeFlowState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a7f6590f8c5dace244c64a02258a15444) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [PauseHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#adeed3b2af31799102a85074683b3053a) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [PlayHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a78a525b15eef23188a84b7967271930a) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [FastForwardHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#ada5a6fff07164d15e4d5f4bfd493128f) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#afa6feb2ffe7758f82d87ecc2e046c167)MapTimeControlVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.MapTimeControlVM | ( | Func< [MapBarShortcuts](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_shortcuts.html) > | *getMapBarShortcuts*, |
|  |  | Action | *onTimeFlowStateChange*, |
|  |  | Action | *onCameraResetted* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#afe9b48511236ffb7af553010e6e4311e)RefreshValues()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a8821bb9178d1e01429ce88479c5b3d2b)OnFinalize()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a945ffcfa6fda29f2206634ece61b58df)Tick()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.Tick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a35ee26509b3e3a305d710d886389406c)Refresh()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.Refresh | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a52acbfc25818275a08867d86edaa02b7)ExecuteTimeControlChange()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.ExecuteTimeControlChange | ( | int | *selectedTimeSpeed* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a77bae3ca90123130c40af119626bbb97)ExecuteResetCamera()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.ExecuteResetCamera | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a33790d8165151f1038c541fae6e771a1)IsInBattleSimulation
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsInBattleSimulation | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a5019feeb2b7b7f25cf8256d926f8a4d4)IsInRecruitment
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsInRecruitment | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a711e50e2a2c5e77130a909069dc40d90)IsEncyclopediaOpen
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsEncyclopediaOpen | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a1224ef2650801ac719d2a5e680b8af54)IsInArmyManagement
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsInArmyManagement | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a47dc6380442163de6b7b8a95ac6f1557)IsInTownManagement
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsInTownManagement | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a81e66c0c3f8bfdd26203b426ddfc8250)IsInHideoutTroopManage
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsInHideoutTroopManage | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#ac80a0c1d0a6fdb9a82dd8574c4cb8da8)IsInMap
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsInMap | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a557aa075160a3b9f6c448602275f0cd0)IsInCampaignOptions
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsInCampaignOptions | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#abab7fd364240628e8d2ee69a04be6dc7)IsEscapeMenuOpened
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsEscapeMenuOpened | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#ad19d657a18d46789b5ebe6c52ccee9a3)IsMarriageOfferPopupActive
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsMarriageOfferPopupActive | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a8e77e57102a74274af1bf81fce575269)IsHeirSelectionPopupActive
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsHeirSelectionPopupActive | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#af0789e9cac985d7e4343bd7f9daf6921)IsMapCheatsActive
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsMapCheatsActive | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a765ebe8195811dd85c85b1c6b0dbf02e)IsMapIncidentActive
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsMapIncidentActive | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#ad8db7c4fe4f994b0b5c6733990397085)IsOverlayContextMenuEnabled
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsOverlayContextMenuEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a251c34b0a6ca1eb1023cc8236f2457c2)TimeOfDayHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.TimeOfDayHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#ab405d1f20aaaf5df29df8dbb209474df)IsCurrentlyPausedOnMap
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsCurrentlyPausedOnMap | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a142a6ff1901b43addd71fe022be9d4d0)IsCenterPanelEnabled
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.IsCenterPanelEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a656fcc649451d84c7ccf16378e0029c9)Time
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | double TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.Time | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a2da6409f06e091813916ecff85b8fa04)PausedText
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.PausedText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a6ebf0107615acc190c2f809e30d3b94c)Date
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.Date | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a7f6590f8c5dace244c64a02258a15444)TimeFlowState
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.TimeFlowState | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#adeed3b2af31799102a85074683b3053a)PauseHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.PauseHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#a78a525b15eef23188a84b7967271930a)PlayHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.PlayHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html#ada5a6fff07164d15e4d5f4bfd493128f)FastForwardHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapTimeControlVM.FastForwardHint | | getset |

