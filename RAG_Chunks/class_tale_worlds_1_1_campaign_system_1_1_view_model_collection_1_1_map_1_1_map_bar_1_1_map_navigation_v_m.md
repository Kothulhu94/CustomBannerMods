--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [MapNavigationVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a4e1b5284b9f1ab807be0e015b9af32e1) ([INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) navigationHandler, Func< [MapBarShortcuts](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_shortcuts.html) > getMapBarShortcuts) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#ae0b3b1296c6cc015399a65d56fcd8269) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#ace5b2b216147e0195701448fad56b0d4) () |
| void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a148b3824cdb707499937afef03b83097) () |
| void | [Tick](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a7198289338aa62a35bfb92451e1e5b7b) () |
| void | [ExecuteOpenQuests](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a924b2e885a4fff0a629fe61920aa66bb) () |
| void | [ExecuteOpenInventory](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#ab2a30fce9f440db8e4eec74bc77554da) () |
| void | [ExecuteOpenParty](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a17c8e9cae16014ffde7ad9257ccb345d) () |
| void | [ExecuteOpenCharacterDeveloper](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a9dd9e2e35527afdb2f2e436fd499fd19) () |
| void | [ExecuteOpenKingdom](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a082ccd1f6a463b72affa4cca50cc0acf) () |
| void | [ExecuteOpenClan](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a804b5c3f7f8ae1928abcc2a2456001de) () |
| void | [ExecuteOpenEscapeMenu](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#ac274c4f9e3bb9d8372e0053043a41b18) () |
| void | [ExecuteOpenMainHeroKingdomEncyclopedia](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a7adc0338ffa50317a99a6a59e38a1809) () |
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
| virtual void | [RefreshStates](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a7fbf9a0c499160b6766cce90ad7da401) () |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Protected Attributes | |
| [INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) | [\_navigationHandler](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a09ac02b4d31eb7b45ab9645011f2cdcf) |
| Func< [MapBarShortcuts](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_shortcuts.html) > | [\_getMapBarShortcuts](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a3eea4006ee958814b69b39c1a0873893) |
| [MapBarShortcuts](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_shortcuts.html) | [\_shortcuts](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a280e5b207917e1c28a80fe759bd25d31) |
| readonly [IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html) | [\_viewDataTracker](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#ae0146dffc5794581800e26d3738a117e) |

|  |  |
| --- | --- |
| Properties | |
| MBBindingList< [MapNavigationItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_item_v_m.html) > | [NavigationItems](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a91243f288d509114113cc96b1a694c8d) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [FinanceHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a3d491232ebe237f8ae12c3eab8a5da6c) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [EncyclopediaHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a70d3224861a449d32acbb36d3420f60c) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [CenterCameraHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#aeb1922d92fe4e551b45672d6f1bc1e5d) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [CampHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#abb8e6c9ced6f9a67cde6b43509e1be23) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a4e1b5284b9f1ab807be0e015b9af32e1)MapNavigationVM()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.MapNavigationVM | ( | [INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) | *navigationHandler*, |
|  |  | Func< [MapBarShortcuts](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_shortcuts.html) > | *getMapBarShortcuts* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#ae0b3b1296c6cc015399a65d56fcd8269)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#ace5b2b216147e0195701448fad56b0d4)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a148b3824cdb707499937afef03b83097)Refresh()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.Refresh | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a7198289338aa62a35bfb92451e1e5b7b)Tick()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.Tick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a7fbf9a0c499160b6766cce90ad7da401)RefreshStates()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.RefreshStates | ( |  | ) |  | | protectedvirtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a924b2e885a4fff0a629fe61920aa66bb)ExecuteOpenQuests()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.ExecuteOpenQuests | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#ab2a30fce9f440db8e4eec74bc77554da)ExecuteOpenInventory()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.ExecuteOpenInventory | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a17c8e9cae16014ffde7ad9257ccb345d)ExecuteOpenParty()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.ExecuteOpenParty | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a9dd9e2e35527afdb2f2e436fd499fd19)ExecuteOpenCharacterDeveloper()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.ExecuteOpenCharacterDeveloper | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a082ccd1f6a463b72affa4cca50cc0acf)ExecuteOpenKingdom()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.ExecuteOpenKingdom | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a804b5c3f7f8ae1928abcc2a2456001de)ExecuteOpenClan()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.ExecuteOpenClan | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#ac274c4f9e3bb9d8372e0053043a41b18)ExecuteOpenEscapeMenu()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.ExecuteOpenEscapeMenu | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a7adc0338ffa50317a99a6a59e38a1809)ExecuteOpenMainHeroKingdomEncyclopedia()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.ExecuteOpenMainHeroKingdomEncyclopedia | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a09ac02b4d31eb7b45ab9645011f2cdcf)\_navigationHandler
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [INavigationHandler](interface_tale_worlds_1_1_campaign_system_1_1_i_navigation_handler.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.\_navigationHandler | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a3eea4006ee958814b69b39c1a0873893)\_getMapBarShortcuts
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | Func<[MapBarShortcuts](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_shortcuts.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.\_getMapBarShortcuts | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a280e5b207917e1c28a80fe759bd25d31)\_shortcuts
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [MapBarShortcuts](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_bar_shortcuts.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.\_shortcuts | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#ae0146dffc5794581800e26d3738a117e)\_viewDataTracker
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [IViewDataTracker](interface_tale_worlds_1_1_campaign_system_1_1_i_view_data_tracker.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.\_viewDataTracker | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a91243f288d509114113cc96b1a694c8d)NavigationItems
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[MapNavigationItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.NavigationItems | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a3d491232ebe237f8ae12c3eab8a5da6c)FinanceHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.FinanceHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#a70d3224861a449d32acbb36d3420f60c)EncyclopediaHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.EncyclopediaHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#aeb1922d92fe4e551b45672d6f1bc1e5d)CenterCameraHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.CenterCameraHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_map_1_1_map_bar_1_1_map_navigation_v_m.html#abb8e6c9ced6f9a67cde6b43509e1be23)CampHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Map.MapBar.MapNavigationVM.CampHint | | getset |

