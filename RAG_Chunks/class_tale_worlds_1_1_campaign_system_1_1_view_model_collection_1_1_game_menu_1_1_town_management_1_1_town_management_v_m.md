--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [TownManagementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#adad89c1a0897dbe9c26df945425251ed) () |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#af5d1203900530eb82a26a3d22331907c) () |
|  | Used for updating localized texts. |
| void | [ExecuteDone](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a3f969150026efd299bfe1ddd6e474ce4) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a0071d1fd392957af8d24ffca7a60da5a) () |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a84eec4799141ca78681259d871a3bbff) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a2d09aa416be31299ed5d2cfb8a58a197) `[get, set]` |
| string | [CompletionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a20c404b01c8dc9dfb5380da825d64d0e) `[get, set]` |
| string | [GovernorText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#af67d597906f86b8dbc3efe91ca55465a) `[get, set]` |
| string | [ManageText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#adf917af2025044c19d51bae5cff9a936) `[get, set]` |
| string | [DoneText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a3455f4942b790c060bad22aac06759ce) `[get, set]` |
| string | [WallsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a98a246bd1879854ecf92a1bac52763f4) `[get, set]` |
| string | [CurrentProjectText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a8f020043bbe216d3d6484e2254a2dd25) `[get, set]` |
| string | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a84bb6ced2899d9ce9c8123549cbd7fe4) `[get, set]` |
| bool | [HasGovernor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a16055730c537bdfab57c2f2ab390432f) `[get, set]` |
| bool | [IsGovernorSelectionEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a85e32c21192e193812aae92d6a7d8582) `[get, set]` |
| bool | [IsTown](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#aa4231b905ee1770f331f4988b0a0b799) `[get, set]` |
| bool | [Show](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#ae6053b0bbc8231a0ef11607d2849c7a7) `[get, set]` |
| bool | [IsThereCurrentProject](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a48cf40fce2199ebb49dee58534234a24) `[get, set]` |
| bool | [IsSelectingGovernor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#ad13ea6e583c5666826bcfb7a77c3ecda) `[get, set]` |
| MBBindingList< [TownManagementDescriptionItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemena5ad8a54e7c9d65fbf57462861e2a05d.html) > | [MiddleFirstTextList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#ab4c5426ad2a15c27091ecc8a6c8b756a) `[get, set]` |
| MBBindingList< [TownManagementDescriptionItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemena5ad8a54e7c9d65fbf57462861e2a05d.html) > | [MiddleSecondTextList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a962bfc5136b0a33bb2e8074886fbfcb4) `[get, set]` |
| MBBindingList< [TownManagementShopItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemen5a86bea8eaec7a328393c8734fa47bdc.html) > | [Shops](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a7fdbfec57030df7ccfc875280225465c) `[get, set]` |
| MBBindingList< [TownManagementVillageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemen3a32d6774d55aaa042a7aaafff55445e.html) > | [Villages](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#ab467cab6d6733991c5167fdde89be267) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [GovernorSelectionDisabledHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a8a60f9d543b3a12adde8c3fb9c0b08e1) `[get, set]` |
| string | [VillagesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a01f8c3a24b55441cb9dab1dbded780ed) `[get, set]` |
| string | [ShopsInSettlementText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#abd868aca8430be2d272add4af64e2378) `[get, set]` |
| bool | [IsCurrentProjectDaily](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a3572a73b1fab2b61b97cc64e243ad0d5) `[get, set]` |
| int | [CurrentProjectProgress](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a8e94868447da4005bd7c9542a816a16b) `[get, set]` |
| [SettlementProjectSelectionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemenfd9bc948df03949d947126ede2893357.html) | [ProjectSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#aa09694ace443440ab28e26889e9c083f) `[get, set]` |
| [SettlementGovernorSelectionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemen1c7f9ac287af2d6cb164de2993217f04.html) | [GovernorSelection](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#aad0d904511a23f0bb86925baa1d84cc5) `[get, set]` |
| [TownManagementReserveControlVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemen683d22e7e7be8764b79a1208ac13f080.html) | [ReserveControl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a4953a4aa96ff1fdf3110667a5130f6ee) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [CurrentGovernorTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#ad84e3124dfb8d6090130d2ce9c6784d2) `[get, set]` |
| [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) | [CurrentGovernor](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a98c67299d43f83d9a2761f28680b3e7a) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [ConsumptionTooltip](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a51a2fb6da784f991b5beb84b5841055e) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#adad89c1a0897dbe9c26df945425251ed)TownManagementVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.TownManagementVM | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#af5d1203900530eb82a26a3d22331907c)RefreshValues()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a3f969150026efd299bfe1ddd6e474ce4)ExecuteDone()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.ExecuteDone | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a0071d1fd392957af8d24ffca7a60da5a)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a84eec4799141ca78681259d871a3bbff)SetDoneInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a2d09aa416be31299ed5d2cfb8a58a197)DoneInputKey
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a20c404b01c8dc9dfb5380da825d64d0e)CompletionText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.CompletionText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#af67d597906f86b8dbc3efe91ca55465a)GovernorText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.GovernorText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#adf917af2025044c19d51bae5cff9a936)ManageText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.ManageText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a3455f4942b790c060bad22aac06759ce)DoneText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.DoneText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a98a246bd1879854ecf92a1bac52763f4)WallsText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.WallsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a8f020043bbe216d3d6484e2254a2dd25)CurrentProjectText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.CurrentProjectText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a84bb6ced2899d9ce9c8123549cbd7fe4)TitleText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.TitleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a16055730c537bdfab57c2f2ab390432f)HasGovernor
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.HasGovernor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a85e32c21192e193812aae92d6a7d8582)IsGovernorSelectionEnabled
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.IsGovernorSelectionEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#aa4231b905ee1770f331f4988b0a0b799)IsTown
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.IsTown | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#ae6053b0bbc8231a0ef11607d2849c7a7)Show
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.Show | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a48cf40fce2199ebb49dee58534234a24)IsThereCurrentProject
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.IsThereCurrentProject | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#ad13ea6e583c5666826bcfb7a77c3ecda)IsSelectingGovernor
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.IsSelectingGovernor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#ab4c5426ad2a15c27091ecc8a6c8b756a)MiddleFirstTextList
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[TownManagementDescriptionItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemena5ad8a54e7c9d65fbf57462861e2a05d.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.MiddleFirstTextList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a962bfc5136b0a33bb2e8074886fbfcb4)MiddleSecondTextList
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[TownManagementDescriptionItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemena5ad8a54e7c9d65fbf57462861e2a05d.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.MiddleSecondTextList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a7fdbfec57030df7ccfc875280225465c)Shops
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[TownManagementShopItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemen5a86bea8eaec7a328393c8734fa47bdc.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.Shops | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#ab467cab6d6733991c5167fdde89be267)Villages
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[TownManagementVillageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemen3a32d6774d55aaa042a7aaafff55445e.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.Villages | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a8a60f9d543b3a12adde8c3fb9c0b08e1)GovernorSelectionDisabledHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.GovernorSelectionDisabledHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a01f8c3a24b55441cb9dab1dbded780ed)VillagesText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.VillagesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#abd868aca8430be2d272add4af64e2378)ShopsInSettlementText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.ShopsInSettlementText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a3572a73b1fab2b61b97cc64e243ad0d5)IsCurrentProjectDaily
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.IsCurrentProjectDaily | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a8e94868447da4005bd7c9542a816a16b)CurrentProjectProgress
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.CurrentProjectProgress | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#aa09694ace443440ab28e26889e9c083f)ProjectSelection
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SettlementProjectSelectionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemenfd9bc948df03949d947126ede2893357.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.ProjectSelection | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#aad0d904511a23f0bb86925baa1d84cc5)GovernorSelection
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SettlementGovernorSelectionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemen1c7f9ac287af2d6cb164de2993217f04.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.GovernorSelection | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a4953a4aa96ff1fdf3110667a5130f6ee)ReserveControl
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [TownManagementReserveControlVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_managemen683d22e7e7be8764b79a1208ac13f080.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.ReserveControl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#ad84e3124dfb8d6090130d2ce9c6784d2)CurrentGovernorTooltip
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.CurrentGovernorTooltip | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a98c67299d43f83d9a2761f28680b3e7a)CurrentGovernor
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.CurrentGovernor | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_town_management_1_1_town_management_v_m.html#a51a2fb6da784f991b5beb84b5841055e)ConsumptionTooltip
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.TownManagement.TownManagementVM.ConsumptionTooltip | | getset |

