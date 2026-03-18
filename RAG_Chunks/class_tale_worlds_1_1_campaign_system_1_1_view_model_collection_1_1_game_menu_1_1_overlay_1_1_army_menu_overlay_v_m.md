--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ArmyMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#aa7795f577cf083d074bcbd0bf671c60c) () |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a66c104ebe7c488ae8f70d35f4ab5c632) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a589c2d9fcb3bb1eb8460f1dffb5bd783) () |
| override void | [OnFrameTick](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a46c6561831c4bc8a43170edf6901ec6a) (float dt) |
| override void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a7b799b661ea217235d90027da44afceb) () |
| void | [ExecuteOpenArmyManagement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a90ad2046b9396a1a253ed38f8ffd78c6) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html) | |
|  | [GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a264046749ec6f45a89d1e93765ce43e3) () |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a4eaeef846d85c6c1abd876ad5029a7fc) () |
|  | Used for updating localized texts. |
| virtual void | [ExecuteOnOverlayClosed](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#aadd70e26359f4cbc31e2cd131a53d873) () |
|  | Fires when player clicks close button on overlay. Does not capture other exits. |
| virtual void | [ExecuteOnOverlayOpened](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ae6437c00a0734966e96a27beb2f358d7) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ac93783b694a67eece3dba96fcde9a32e) () |
| virtual void | [UpdateOverlayType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#af4715c6a9ad71d9742753782ff2b5585) ([GameMenus.GameMenu.MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) newType) |
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
| Action | [OpenArmyManagement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#ac986890cf5ea945d8dd5a87b58cc342d) |
| [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) | [\_tutorialNotification](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#ae810e4c5fe3d690a36ff4f2cd7bafdb8) |
| Public Attributes inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html) | |
| string | [GameMenuOverlayName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a9d018491ba6b39ac3491ca3067baeeee) |

|  |  |
| --- | --- |
| Protected Member Functions | |
| override void | [ExecuteOnSetAsActiveContextMenuItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#ae3bdd53861801a31e4e4686760ebf164) ([GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) troop) |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html) | |
| void | [ExecuteTroopAction](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a9a5c9e92ce8ec5b3d43326edfad2939f) (object o) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Properties | |
| [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) | [TutorialNotification](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#acb68d202bc32c62495366d610c53a70e) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ManageArmyHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#aae67c5e61f5ab3e2e32af6b3d79e638b) `[get, set]` |
| int | [Cohesion](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a64cc61e4a6c29bfb6b024fddae4ffafd) `[get, set]` |
| bool | [IsCohesionWarningEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a03fad5224b2f599218fdcf07c770fd87) `[get, set]` |
| bool | [CanManageArmy](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#aa1b147b7a56c890c57b47a55b426637d) `[get, set]` |
| bool | [IsPlayerArmyLeader](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#aec31e8edaa79f3f90bbfba2965103f67) `[get, set]` |
| string | [ManCountText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#abc6a38c813e9446ea53850522f9314e2) `[get, set]` |
| int | [Food](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#ad6537f03d28a1b39be1bee022efdbfc4) `[get, set]` |
| MBBindingList< [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) > | [PartyList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#aa2bda80abbd893cf58ed589a7d2bb79a) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [CohesionHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a6e814edb302d3f114cdd7b8d97be376a) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [ManCountHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a93a518ad5f1816a72d15b7bc6e9f5656) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [FoodHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a6f4ea3a641e70cbd5dc7414e906dc8a6) `[get, set]` |
| MBBindingList< [StringItemWithHintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_item_with_hint_v_m.html) > | [IssueList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#ab5793d0be6163649bab0c2a8978c374d) `[get]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html) | |
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
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html) | |
| [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) | [\_contextMenuItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a0ca354df0d1c57f14dde033baa1d64d3) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#aa7795f577cf083d074bcbd0bf671c60c)ArmyMenuOverlayVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.ArmyMenuOverlayVM | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a66c104ebe7c488ae8f70d35f4ab5c632)RefreshValues()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a589c2d9fcb3bb1eb8460f1dffb5bd783)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#ae3bdd53861801a31e4e4686760ebf164)ExecuteOnSetAsActiveContextMenuItem()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.ExecuteOnSetAsActiveContextMenuItem | ( | [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) | *troop* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#abbee9db91eb0ea433ec51722297211b5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a46c6561831c4bc8a43170edf6901ec6a)OnFrameTick()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.OnFrameTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ab1bdc7db4034fee29d2d71267f020d56).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a7b799b661ea217235d90027da44afceb)Refresh()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.Refresh | ( |  | ) |  | | sealedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#aece0c5e255bf1ad69b54ea4b7916aba6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a90ad2046b9396a1a253ed38f8ffd78c6)ExecuteOpenArmyManagement()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.ExecuteOpenArmyManagement | ( |  | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#ac986890cf5ea945d8dd5a87b58cc342d)OpenArmyManagement
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| Action TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.OpenArmyManagement |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#ae810e4c5fe3d690a36ff4f2cd7bafdb8)\_tutorialNotification
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.\_tutorialNotification |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#acb68d202bc32c62495366d610c53a70e)TutorialNotification
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.TutorialNotification | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#aae67c5e61f5ab3e2e32af6b3d79e638b)ManageArmyHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.ManageArmyHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a64cc61e4a6c29bfb6b024fddae4ffafd)Cohesion
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.Cohesion | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a03fad5224b2f599218fdcf07c770fd87)IsCohesionWarningEnabled
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.IsCohesionWarningEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#aa1b147b7a56c890c57b47a55b426637d)CanManageArmy
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.CanManageArmy | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#aec31e8edaa79f3f90bbfba2965103f67)IsPlayerArmyLeader
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.IsPlayerArmyLeader | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#abc6a38c813e9446ea53850522f9314e2)ManCountText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.ManCountText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#ad6537f03d28a1b39be1bee022efdbfc4)Food
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.Food | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#aa2bda80abbd893cf58ed589a7d2bb79a)PartyList
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.PartyList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a6e814edb302d3f114cdd7b8d97be376a)CohesionHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.CohesionHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a93a518ad5f1816a72d15b7bc6e9f5656)ManCountHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.ManCountHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#a6f4ea3a641e70cbd5dc7414e906dc8a6)FoodHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.FoodHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_army_menu_overlay_v_m.html#ab5793d0be6163649bab0c2a8978c374d)IssueList
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[StringItemWithHintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_item_with_hint_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.ArmyMenuOverlayVM.IssueList | | get |

