--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GameMenuVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a036979f3b73d16ad9820d0a2ee09ed02) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ad1f5282ea82b82465060ddd172776dc4) menuContext) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ada582dcd7e692d3be6224a4e75eb6a8f) () |
|  | Used for updating localized texts. |
| void | [SetIdleMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a2f153eeadcbef2574f406873b6cf3a35) (bool isIdle) |
| void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a8377a4aa1784fb815ca3f3b1a2a7f0d0) (bool forceUpdateItems) |
|  | Called once on activate. If is from activation, re-population of items is expected. |
| void | [OnFrameTick](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a1ce9d0d49d3aba4a8de19f6bf43a6ec1) () |
| void | [UpdateMenuContext](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ad63afbf7020a55efea60de3efe12fc76) ([MenuContext](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ad1f5282ea82b82465060ddd172776dc4) newMenuContext) |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a63c6f5fb7b48b86f222a13e9be8d062c) () |
| void | [AddHotKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ac422699f6346219fb1bd91a0612a9063) ([GameMenuOption.LeaveType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2) leaveType, [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) gameKey) |
| void | [ExecuteLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a1dd8fb418db39e95d27e308284fee412) (string link) |
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
| MenuContext | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ad1f5282ea82b82465060ddd172776dc4) `[get]` |
| bool | [IsNight](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a60fcb0d368a1c06282c57979124b3197) `[get, set]` |
| bool | [IsInSiegeMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a5de1d2d64ee88dc677689dd889864523) `[get, set]` |
| bool | [IsEncounterMenu](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a70a6ed098a5b632ef2f008112fbd9864) `[get, set]` |
| string | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ab51f44922e88fc0a0a52795854ee65ea) `[get, set]` |
| string | [ContextText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ab9e8371206cf24db9c8a4074a55ab06f) `[get, set]` |
| MBBindingList< [GameMenuItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html) > | [ItemList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ad5e8e6998f4687f950da8e758e225bce) `[get, set]` |
| MBBindingList< [GameMenuItemProgressVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_progress_v_m.html) > | [ProgressItemList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a15170c69397d346edbf713cd7c5518fc) `[get, set]` |
| string | [Background](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#af7dbf62a03910e5c66b21c3100fac97f) `[get, set]` |
| string | [BackgroundCopy](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#addcdb8c6cd402edc7b37c3e00767def4) `[get, set]` |
| string | [MenuId](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ad21c8ee2ae0c176aaeb93964c486f792) `[get, set]` |
| MBBindingList< [GameMenuPlunderItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_plunder_item_v_m.html) > | [PlunderItems](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a9d96ff2cdb405b626ad79b3bcb3802d7) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a036979f3b73d16ad9820d0a2ee09ed02)GameMenuVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.GameMenuVM | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ad1f5282ea82b82465060ddd172776dc4) | *menuContext* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ada582dcd7e692d3be6224a4e75eb6a8f)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a2f153eeadcbef2574f406873b6cf3a35)SetIdleMode()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.SetIdleMode | ( | bool | *isIdle* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a8377a4aa1784fb815ca3f3b1a2a7f0d0)Refresh()
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.Refresh | ( | bool | *forceUpdateItems* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a1ce9d0d49d3aba4a8de19f6bf43a6ec1)OnFrameTick()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.OnFrameTick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ad63afbf7020a55efea60de3efe12fc76)UpdateMenuContext()
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.UpdateMenuContext | ( | [MenuContext](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ad1f5282ea82b82465060ddd172776dc4) | *newMenuContext* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a63c6f5fb7b48b86f222a13e9be8d062c)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ac422699f6346219fb1bd91a0612a9063)AddHotKey()
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.AddHotKey | ( | [GameMenuOption.LeaveType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu_option.html#a8d5108a3a8e5d42b1fe2063d66a92cd2) | *leaveType*, |
|  |  | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *gameKey* ) |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a1dd8fb418db39e95d27e308284fee412)ExecuteLink()
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.ExecuteLink | ( | string | *link* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ad1f5282ea82b82465060ddd172776dc4)MenuContext
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MenuContext TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.MenuContext | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a60fcb0d368a1c06282c57979124b3197)IsNight
--------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.IsNight | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a5de1d2d64ee88dc677689dd889864523)IsInSiegeMode
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.IsInSiegeMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a70a6ed098a5b632ef2f008112fbd9864)IsEncounterMenu
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.IsEncounterMenu | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ab51f44922e88fc0a0a52795854ee65ea)TitleText
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.TitleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ab9e8371206cf24db9c8a4074a55ab06f)ContextText
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.ContextText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ad5e8e6998f4687f950da8e758e225bce)ItemList
---------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GameMenuItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.ItemList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a15170c69397d346edbf713cd7c5518fc)ProgressItemList
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GameMenuItemProgressVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_progress_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.ProgressItemList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#af7dbf62a03910e5c66b21c3100fac97f)Background
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.Background | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#addcdb8c6cd402edc7b37c3e00767def4)BackgroundCopy
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.BackgroundCopy | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#ad21c8ee2ae0c176aaeb93964c486f792)MenuId
-------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.MenuId | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_v_m.html#a9d96ff2cdb405b626ad79b3bcb3802d7)PlunderItems
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GameMenuPlunderItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_plunder_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuVM.PlunderItems | | getset |

