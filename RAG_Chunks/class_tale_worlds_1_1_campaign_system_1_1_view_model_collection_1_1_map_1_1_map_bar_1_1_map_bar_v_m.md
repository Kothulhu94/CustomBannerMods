--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapBarVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a0caa5abdaa2268dfe095dd89a46966e3) () |
| void | [Initialize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a5a2baf4fa6b436de7dede537e2a3c30a) ([INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) navigationHandler, [IMapStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html) mapStateHandler, Func< [MapBarShortcuts](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_shortcuts.html) > getMapBarShortcuts, Action openArmyManagement) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a6c4da18e1934ec38c5093d72b97945dd) () |
|  | Used for updating localized texts. |
| void | [OnRefresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a648b601d176ac13a2c4434d739fd7b8c) () |
| void | [Tick](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a07ed64ebe60fcc14cf4fe946bc785d8f) (float dt) |
| void | [ExecuteArmyManagement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a0b164d830312102f3518504c296bfe34) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a812813010212df33e12437de762bded8) () |
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
| Protected Member Functions | |
| virtual [MapInfoVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_info_v_m.html) | [CreateInfoVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a998d9e5226e2b779253b98a7c9a93a09) () |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Protected Attributes | |
| [INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) | [\_navigationHandler](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a3764a01448c6fdd6bb19b7609fa51a94) |

|  |  |
| --- | --- |
| Properties | |
| [MapInfoVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_info_v_m.html) | [MapInfo](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a4435b209d988e424b55859bacab10215) `[get, set]` |
| [MapTimeControlVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html) | [MapTimeControl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#ad07be01cda385879869e3ab2150f1ea0) `[get, set]` |
| [MapNavigationVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html) | [MapNavigation](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#ab8b18e0d4902401bba5ad844439bd4c2) `[get, set]` |
| bool | [IsGatherArmyVisible](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a1ed8c828d6afc4a64ecfe2a44e06dd43) `[get, set]` |
| bool | [IsInInfoMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a3e0e0c42d1c6c8fa9e3dcb719aaaffae) `[get, set]` |
| bool | [IsEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#ad81e85fe4bb6b8e02924d33185030e53) `[get, set]` |
| bool | [CanGatherArmy](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a755bd1fcdc2d9a2ff8c2893b38f738cf) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [GatherArmyHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#ac0b9b207b23772f32f8dd7d9f4fa1e4b) `[get, set]` |
| bool | [IsCameraCentered](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#af1f7836f2ce207e8cb3aaf102ef5ce64) `[get, set]` |
| string | [CurrentScreen](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a9a04d63210585ec0ce7aea5854d17318) `[get, set]` |
| [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) | [TutorialNotification](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a367e0a9ec14ef1524b7f7ff80d287f43) `[get, set]` |

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

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a0caa5abdaa2268dfe095dd89a46966e3)MapBarVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.MapBarVM | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a998d9e5226e2b779253b98a7c9a93a09)CreateInfoVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual [MapInfoVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_info_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.CreateInfoVM | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a5a2baf4fa6b436de7dede537e2a3c30a)Initialize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.Initialize | ( | [INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) | *navigationHandler*, |
|  |  | [IMapStateHandler](interface_tale_worlds_1_1_campaign_system_1_1_game_state_1_1_i_map_state_handler.html) | *mapStateHandler*, |
|  |  | Func< [MapBarShortcuts](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_shortcuts.html) > | *getMapBarShortcuts*, |
|  |  | Action | *openArmyManagement* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a6c4da18e1934ec38c5093d72b97945dd)RefreshValues()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a648b601d176ac13a2c4434d739fd7b8c)OnRefresh()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.OnRefresh | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a07ed64ebe60fcc14cf4fe946bc785d8f)Tick()
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.Tick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a0b164d830312102f3518504c296bfe34)ExecuteArmyManagement()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.ExecuteArmyManagement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a812813010212df33e12437de762bded8)OnFinalize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a3764a01448c6fdd6bb19b7609fa51a94)\_navigationHandler
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.\_navigationHandler | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a4435b209d988e424b55859bacab10215)MapInfo
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapInfoVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_info_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.MapInfo | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#ad07be01cda385879869e3ab2150f1ea0)MapTimeControl
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapTimeControlVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_time_control_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.MapTimeControl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#ab8b18e0d4902401bba5ad844439bd4c2)MapNavigation
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapNavigationVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.MapNavigation | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a1ed8c828d6afc4a64ecfe2a44e06dd43)IsGatherArmyVisible
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.IsGatherArmyVisible | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a3e0e0c42d1c6c8fa9e3dcb719aaaffae)IsInInfoMode
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.IsInInfoMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#ad81e85fe4bb6b8e02924d33185030e53)IsEnabled
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.IsEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a755bd1fcdc2d9a2ff8c2893b38f738cf)CanGatherArmy
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.CanGatherArmy | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#ac0b9b207b23772f32f8dd7d9f4fa1e4b)GatherArmyHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.GatherArmyHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#af1f7836f2ce207e8cb3aaf102ef5ce64)IsCameraCentered
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.IsCameraCentered | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a9a04d63210585ec0ce7aea5854d17318)CurrentScreen
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.CurrentScreen | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_v_m.html#a367e0a9ec14ef1524b7f7ff80d287f43)TutorialNotification
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapBarVM.TutorialNotification | | getset |

