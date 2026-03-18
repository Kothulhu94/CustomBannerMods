--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

Inherited by [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html), [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html), and [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a264046749ec6f45a89d1e93765ce43e3) () |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a4eaeef846d85c6c1abd876ad5029a7fc) () |
|  | Used for updating localized texts. |
| virtual void | [ExecuteOnOverlayClosed](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#aadd70e26359f4cbc31e2cd131a53d873) () |
|  | Fires when player clicks close button on overlay. Does not capture other exits. |
| virtual void | [ExecuteOnOverlayOpened](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ae6437c00a0734966e96a27beb2f358d7) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ac93783b694a67eece3dba96fcde9a32e) () |
| virtual void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#aece0c5e255bf1ad69b54ea4b7916aba6) () |
| virtual void | [UpdateOverlayType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#af4715c6a9ad71d9742753782ff2b5585) ([GameMenus.GameMenu.MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) newType) |
| virtual void | [OnFrameTick](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ab1bdc7db4034fee29d2d71267f020d56) (float dt) |
| void | [HourlyTick](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ac2a12abbf1ca7d65378b9757cac5fd00) () |
| void | [SetExitInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a8674c192ea2b7ff0f5694b43ba5419b2) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| string | [GameMenuOverlayName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a9d018491ba6b39ac3491ca3067baeeee) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| virtual void | [ExecuteOnSetAsActiveContextMenuItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#abbee9db91eb0ea433ec51722297211b5) ([GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) troop) |
| void | [ExecuteTroopAction](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a9a5c9e92ce8ec5b3d43326edfad2939f) (object o) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Protected Attributes | |
| [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) | [\_contextMenuItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a0ca354df0d1c57f14dde033baa1d64d3) |

|  |  |
| --- | --- |
| Properties | |
| bool | [IsContextMenuEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a627d4c5072b0bddf743f4c0d677a1da4) `[get, set]` |
| bool | [IsInitializationOver](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ab601e93bcdc8a59dabbe91960fb64f3e) `[get, set]` |
| bool | [IsInfoBarExtended](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a0411ce1bc6790bd4f955421a0213ad4f) `[get, set]` |
| MBBindingList< [StringItemWithEnabledAndHintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_item_with_enabled_and_hint_v_m.html) > | [ContextList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a0e5afd8629e820f5a19ba71cabe5a345) `[get, set]` |
| int | [CurrentOverlayType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ac152dc0b2012d42a54df4d6b0c06e66b) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [ExitInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ab83b6c3cf442bf6b4994f620801bb146) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a264046749ec6f45a89d1e93765ce43e3)GameMenuOverlay()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.GameMenuOverlay | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a4eaeef846d85c6c1abd876ad5029a7fc)RefreshValues()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

Reimplemented in [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#af40a0e1c708a5aaaaf13c0d3fbc47e57).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#abbee9db91eb0ea433ec51722297211b5)ExecuteOnSetAsActiveContextMenuItem()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.ExecuteOnSetAsActiveContextMenuItem | ( | [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) | *troop* | ) |  | | protectedvirtual |

Reimplemented in [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#ae3bdd53861801a31e4e4686760ebf164), and [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a8237f3ade076c14a178f7dbd3c81d019).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#aadd70e26359f4cbc31e2cd131a53d873)ExecuteOnOverlayClosed()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.ExecuteOnOverlayClosed | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a3051e8ac7a7d2561db32d4c1043ef8eb).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ae6437c00a0734966e96a27beb2f358d7)ExecuteOnOverlayOpened()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.ExecuteOnOverlayOpened | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ac93783b694a67eece3dba96fcde9a32e)OnFinalize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Reimplemented in [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a408356114f195d28714f6895f6d8287b).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a9a5c9e92ce8ec5b3d43326edfad2939f)ExecuteTroopAction()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.ExecuteTroopAction | ( | object | *o* | ) |  | | protected |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#aece0c5e255bf1ad69b54ea4b7916aba6)Refresh()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.Refresh | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a7b799b661ea217235d90027da44afceb), [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a3e571519dca2ef0464dade35bee3ff56), and [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#afa750f85800729919c32fc9a5f1a1468).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#af4715c6a9ad71d9742753782ff2b5585)UpdateOverlayType()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.UpdateOverlayType | ( | [GameMenus.GameMenu.MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) | *newType* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a72bcb1b09a2f84cab9c152a30d25c47e).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ab1bdc7db4034fee29d2d71267f020d56)OnFrameTick()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.OnFrameTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a46c6561831c4bc8a43170edf6901ec6a), and [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ad0135220a5e3108bb9185f23fae5ac2f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ac2a12abbf1ca7d65378b9757cac5fd00)HourlyTick()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.HourlyTick | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a8674c192ea2b7ff0f5694b43ba5419b2)SetExitInputKey()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.SetExitInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a9d018491ba6b39ac3491ca3067baeeee)GameMenuOverlayName
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.GameMenuOverlayName |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a0ca354df0d1c57f14dde033baa1d64d3)\_contextMenuItem
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.\_contextMenuItem | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a627d4c5072b0bddf743f4c0d677a1da4)IsContextMenuEnabled
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.IsContextMenuEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ab601e93bcdc8a59dabbe91960fb64f3e)IsInitializationOver
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.IsInitializationOver | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a0411ce1bc6790bd4f955421a0213ad4f)IsInfoBarExtended
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.IsInfoBarExtended | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a0e5afd8629e820f5a19ba71cabe5a345)ContextList
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[StringItemWithEnabledAndHintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_item_with_enabled_and_hint_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.ContextList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ac152dc0b2012d42a54df4d6b0c06e66b)CurrentOverlayType
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.CurrentOverlayType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ab83b6c3cf442bf6b4994f620801bb146)ExitInputKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay.ExitInputKey | | getset |

