--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [EncounterMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#abec8dfa26311080e6faed07252e59cdd) () |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a58c13ae76bc9be044330f5d6ac233384) () |
|  | Used for updating localized texts. |
| override void | [OnFrameTick](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ad0135220a5e3108bb9185f23fae5ac2f) (float dt) |
| override void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a3e571519dca2ef0464dade35bee3ff56) () |
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
| Properties | |
| string | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#af84a124bd750b44105c108300d09bd5c) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [DefenderPartyBanner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a930e5c61810e19b03a045a3a19d2e618) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [AttackerPartyBanner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a04806da9642a26f3c75f26a8f2f4ca32) `[get, set]` |
| [PowerLevelComparer](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_power_level_comparer.html) | [PowerComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a057dbf64dbb47c96e379a5ac0c553ffa) `[get, set]` |
| MBBindingList< [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) > | [AttackerPartyList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a5cee31c737fc32da25df3f5a614a8098) `[get, set]` |
| MBBindingList< [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) > | [DefenderPartyList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a94434dfe3ec12995944a393b6cc04718) `[get, set]` |
| string | [DefenderPartyMorale](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a0f342b8cbb6fe5d2758f63d19af6c992) `[get, set]` |
| string | [AttackerPartyMorale](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a3c371c933d5f3703254f5ed81b952041) `[get, set]` |
| int | [DefenderPartyCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a9386e375a887ef32bfb3dcb247dbedcb) `[get, set]` |
| int | [AttackerPartyCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a486f27a820f63ab9e4e66d395a4b8548) `[get, set]` |
| int | [DefenderShipCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a17bde1e07c3623ee1d0324f48c0ab7f5) `[get, set]` |
| int | [AttackerShipCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ad6b66f6645b175eeda8f17dd0af124ec) `[get, set]` |
| string | [DefenderPartyFood](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ad227ee052d1d1113dacf773414f35531) `[get, set]` |
| string | [AttackerPartyFood](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ac14e78e84d6f3069d2d2ed574322c385) `[get, set]` |
| string | [DefenderWallHitPoints](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a67bde8b6a280b201b02107b3c807b32b) `[get, set]` |
| bool | [IsNaval](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a35a2adbc22beeab2dcc15b515464b89f) `[get, set]` |
| bool | [IsSiege](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ad96ece45f49123f82a5aa70de2ce0af3) `[get, set]` |
| string | [DefenderPartyCountLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a27e3058a01748ea26eea350f404f889b) `[get, set]` |
| string | [AttackerPartyCountLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a113080bb62b5c7dc91549c9aa99f1979) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [AttackerBannerHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ad8ec5a94218600bc10b6d74491fa955d) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DefenderBannerHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ab9850db136fa59443bb32199f9808df7) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [AttackerTroopNumHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a8bff17cc8f25e25d494aca8d0105e06c) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DefenderTroopNumHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a74f83a970beea98b93f3547a4fad692f) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [AttackerShipNumHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a3fe29f3fc75a6e8296e35d960a60d613) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [DefenderShipNumHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a3ff13b0a908ecaaee032c8efdb37590b) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [DefenderWallHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a98aa185976c050ac322b88c66fbb6e79) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [DefenderFoodHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a65dd2ee6b610c0ecae10e39a99e026d6) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [AttackerFoodHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a8c17f2ab4b35b411e19f8cd2eb7d4a2a) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [AttackerMoraleHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a775c3b7ce19a59e60fa5b684af9a08d4) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [DefenderMoraleHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ab887284d0fe1d95377ea96e93e4b1665) `[get, set]` |
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
| Public Attributes inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html) | |
| string | [GameMenuOverlayName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a9d018491ba6b39ac3491ca3067baeeee) |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html) | |
| virtual void | [ExecuteOnSetAsActiveContextMenuItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#abbee9db91eb0ea433ec51722297211b5) ([GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) troop) |
| void | [ExecuteTroopAction](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a9a5c9e92ce8ec5b3d43326edfad2939f) (object o) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#abec8dfa26311080e6faed07252e59cdd)EncounterMenuOverlayVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.EncounterMenuOverlayVM | ( |  | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a58c13ae76bc9be044330f5d6ac233384)RefreshValues()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ad0135220a5e3108bb9185f23fae5ac2f)OnFrameTick()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.OnFrameTick | ( | float | *dt* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ab1bdc7db4034fee29d2d71267f020d56).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a3e571519dca2ef0464dade35bee3ff56)Refresh()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.Refresh | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#aece0c5e255bf1ad69b54ea4b7916aba6).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#af84a124bd750b44105c108300d09bd5c)TitleText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.TitleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a930e5c61810e19b03a045a3a19d2e618)DefenderPartyBanner
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderPartyBanner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a04806da9642a26f3c75f26a8f2f4ca32)AttackerPartyBanner
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.AttackerPartyBanner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a057dbf64dbb47c96e379a5ac0c553ffa)PowerComparer
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [PowerLevelComparer](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_power_level_comparer.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.PowerComparer | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a5cee31c737fc32da25df3f5a614a8098)AttackerPartyList
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.AttackerPartyList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a94434dfe3ec12995944a393b6cc04718)DefenderPartyList
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderPartyList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a0f342b8cbb6fe5d2758f63d19af6c992)DefenderPartyMorale
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderPartyMorale | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a3c371c933d5f3703254f5ed81b952041)AttackerPartyMorale
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.AttackerPartyMorale | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a9386e375a887ef32bfb3dcb247dbedcb)DefenderPartyCount
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderPartyCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a486f27a820f63ab9e4e66d395a4b8548)AttackerPartyCount
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.AttackerPartyCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a17bde1e07c3623ee1d0324f48c0ab7f5)DefenderShipCount
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderShipCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ad6b66f6645b175eeda8f17dd0af124ec)AttackerShipCount
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.AttackerShipCount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ad227ee052d1d1113dacf773414f35531)DefenderPartyFood
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderPartyFood | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ac14e78e84d6f3069d2d2ed574322c385)AttackerPartyFood
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.AttackerPartyFood | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a67bde8b6a280b201b02107b3c807b32b)DefenderWallHitPoints
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderWallHitPoints | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a35a2adbc22beeab2dcc15b515464b89f)IsNaval
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.IsNaval | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ad96ece45f49123f82a5aa70de2ce0af3)IsSiege
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.IsSiege | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a27e3058a01748ea26eea350f404f889b)DefenderPartyCountLbl
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderPartyCountLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a113080bb62b5c7dc91549c9aa99f1979)AttackerPartyCountLbl
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.AttackerPartyCountLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ad8ec5a94218600bc10b6d74491fa955d)AttackerBannerHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.AttackerBannerHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ab9850db136fa59443bb32199f9808df7)DefenderBannerHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderBannerHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a8bff17cc8f25e25d494aca8d0105e06c)AttackerTroopNumHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.AttackerTroopNumHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a74f83a970beea98b93f3547a4fad692f)DefenderTroopNumHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderTroopNumHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a3fe29f3fc75a6e8296e35d960a60d613)AttackerShipNumHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.AttackerShipNumHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a3ff13b0a908ecaaee032c8efdb37590b)DefenderShipNumHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderShipNumHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a98aa185976c050ac322b88c66fbb6e79)DefenderWallHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderWallHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a65dd2ee6b610c0ecae10e39a99e026d6)DefenderFoodHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderFoodHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a8c17f2ab4b35b411e19f8cd2eb7d4a2a)AttackerFoodHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.AttackerFoodHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#a775c3b7ce19a59e60fa5b684af9a08d4)AttackerMoraleHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.AttackerMoraleHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_encounter_menu_overlay_v_m.html#ab887284d0fe1d95377ea96e93e4b1665)DefenderMoraleHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.EncounterMenuOverlayVM.DefenderMoraleHint | | getset |

