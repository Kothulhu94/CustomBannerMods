--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Classes | |
| struct | [GameMenuItemCreationData](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_ite4cb2f9192cbeb19f1fb878f4bc8de619.html) |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GameMenuItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a4dc8f17d2024f223239763c95c4bf3ab) () |
| void | [InitializeWith](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a00c19fa508946048fefe858383413c46) (in [GameMenuItemCreationData](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_ite4cb2f9192cbeb19f1fb878f4bc8de619.html) data) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a61dc171759d0eb8e98ac0c350390a9e7) () |
|  | Used for updating localized texts. |
| void | [ExecuteAction](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a6ada39031f20c7cb296caafebec08f02) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a356f07a978a8e3d51307dd1aab7c927f) () |
| void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a11027c0092dc289e7859050384d0f5bf) () |
| void | [UpdateWith](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a921945aa6d1f4e9b54bf3a899573721b) ([GameMenuItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a4dc8f17d2024f223239763c95c4bf3ab) newItem) |
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
| Public Attributes | |
| int | [Index](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a683a9d4309d79162cb2b6b2aa0ecd131) |

|  |  |
| --- | --- |
| Properties | |
| string | [OptionID](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a8f640a15c8546cc8072d49f56105a98f) `[get]` |
| GameMenuOption | [GameMenuOption](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a4715434bcb5ba913afd18eb2cdc4afe3) `[get]` |
| MBBindingList< [QuestMarkerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_marker_v_m.html) > | [Quests](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a6af95f375e4999777cecfd0485d0d5db) `[get, set]` |
| string | [OptionLeaveType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a67595d38c50fa9e63d7d71255760fb46) `[get, set]` |
| int | [ItemType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#aabe7ddc355839c8ec8d9ab384f9754b0) `[get, set]` |
| bool | [IsWaitActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a7d5e00499753ebae68e63e82180a17fd) `[get, set]` |
| bool | [IsEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a0268a435a69e714436ee480eb05e85fe) `[get, set]` |
| bool | [IsHighlightEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a9801171e8d80af659dffb12b6b17fe41) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ItemHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a2b8966c64dec4514fef873a135ab00d0) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [QuestHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a0b4df22cd48c4826f220f4cf2629b251) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [IssueHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#ab738e9de79bc118942afceaa52a5c18c) `[get, set]` |
| string | [GameMenuStringId](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a867d709840e2800f56dc76422ba77513) `[get, set]` |
| string | [Item](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a03d2ca104aa37989b03f58dc399a25be) `[get, set]` |
| int | [BattleSize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#ab6ab64a82cb9da681a39390b9d189584) `[get, set]` |
| bool | [IsNavalBattle](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#ad9431aa3392abe9586558ca873f0bb9c) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [ShortcutKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#adc122c79f47913ee45195a3c29d44d2d) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a4dc8f17d2024f223239763c95c4bf3ab)GameMenuItemVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.GameMenuItemVM | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a00c19fa508946048fefe858383413c46)InitializeWith()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.InitializeWith | ( | in [GameMenuItemCreationData](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_ite4cb2f9192cbeb19f1fb878f4bc8de619.html) | *data* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a61dc171759d0eb8e98ac0c350390a9e7)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a6ada39031f20c7cb296caafebec08f02)ExecuteAction()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.ExecuteAction | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a356f07a978a8e3d51307dd1aab7c927f)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a11027c0092dc289e7859050384d0f5bf)Refresh()
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.Refresh | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a921945aa6d1f4e9b54bf3a899573721b)UpdateWith()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.UpdateWith | ( | [GameMenuItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a4dc8f17d2024f223239763c95c4bf3ab) | *newItem* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a683a9d4309d79162cb2b6b2aa0ecd131)Index
-----------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.Index |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a8f640a15c8546cc8072d49f56105a98f)OptionID
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.OptionID | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a4715434bcb5ba913afd18eb2cdc4afe3)GameMenuOption
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | GameMenuOption TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.GameMenuOption | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a6af95f375e4999777cecfd0485d0d5db)Quests
------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[QuestMarkerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_marker_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.Quests | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a67595d38c50fa9e63d7d71255760fb46)OptionLeaveType
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.OptionLeaveType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#aabe7ddc355839c8ec8d9ab384f9754b0)ItemType
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.ItemType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a7d5e00499753ebae68e63e82180a17fd)IsWaitActive
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.IsWaitActive | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a0268a435a69e714436ee480eb05e85fe)IsEnabled
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.IsEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a9801171e8d80af659dffb12b6b17fe41)IsHighlightEnabled
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.IsHighlightEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a2b8966c64dec4514fef873a135ab00d0)ItemHint
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.ItemHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a0b4df22cd48c4826f220f4cf2629b251)QuestHint
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.QuestHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#ab738e9de79bc118942afceaa52a5c18c)IssueHint
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.IssueHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a867d709840e2800f56dc76422ba77513)GameMenuStringId
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.GameMenuStringId | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#a03d2ca104aa37989b03f58dc399a25be)Item
----------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.Item | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#ab6ab64a82cb9da681a39390b9d189584)BattleSize
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.BattleSize | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#ad9431aa3392abe9586558ca873f0bb9c)IsNavalBattle
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.IsNavalBattle | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_game_menu_item_v_m.html#adc122c79f47913ee45195a3c29d44d2d)ShortcutKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.GameMenuItemVM.ShortcutKey | | getset |

