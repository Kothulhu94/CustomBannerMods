--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [SettlementMenuOverlayVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a23c7ee7b1a6d24521cefbdd1db60e866) ([GameMenus.GameMenu.MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) type) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#af40a0e1c708a5aaaaf13c0d3fbc47e57) () |
|  | Used for updating localized texts. |
| override void | [ExecuteOnOverlayClosed](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a3051e8ac7a7d2561db32d4c1043ef8eb) () |
|  | Fires when player clicks close button on overlay. Does not capture other exits. |
| override void | [UpdateOverlayType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a72bcb1b09a2f84cab9c152a30d25c47e) ([GameMenus.GameMenu.MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) newType) |
| override void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#afa750f85800729919c32fc9a5f1a1468) () |
| void | [ExecuteAddCompanion](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a0c5822c14c544f862775695a228c99b3) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a408356114f195d28714f6895f6d8287b) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html) | |
|  | [GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a264046749ec6f45a89d1e93765ce43e3) () |
| virtual void | [ExecuteOnOverlayOpened](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ae6437c00a0734966e96a27beb2f358d7) () |
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
| Protected Member Functions | |
| override void | [ExecuteOnSetAsActiveContextMenuItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a8237f3ade076c14a178f7dbd3c81d019) ([GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) troop) |
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html) | |
| void | [ExecuteTroopAction](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a9a5c9e92ce8ec5b3d43326edfad2939f) (object o) |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Protected Attributes | |
| readonly [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | [\_settlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aefd40679dc17525b90eeb179e367db93) |
| Protected Attributes inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html) | |
| [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) | [\_contextMenuItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a0ca354df0d1c57f14dde033baa1d64d3) |

|  |  |
| --- | --- |
| Properties | |
| string | [RemainingFoodText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a113cb66ba82601e21a81da4113166fbb) `[get, set]` |
| int | [ProsperityChangeAmount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a4f6bc6451670606f6cdfd37fb4f950c0) `[get, set]` |
| int | [MilitiaChangeAmount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a2eae99ba39a650d04e9a917f2c4d484c) `[get, set]` |
| int | [GarrisonChangeAmount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aee94ecf1f35aa0d203988664fb3a14c7) `[get, set]` |
| int | [GarrisonAmount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#ad8d84d1dabf58ea501ab2d8f73e508a0) `[get, set]` |
| int | [CrimeChangeAmount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#ac740e1b583b8cabe4a237724fc0a4fb0) `[get, set]` |
| int | [LoyaltyChangeAmount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#ab845a701a8f76527c7877f60c97eff90) `[get, set]` |
| int | [SecurityChangeAmount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a1254e0cd10cddce2daf45e017ad8ea4f) `[get, set]` |
| int | [FoodChangeAmount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a09e2a33ab5caca7302f94d837869fb1d) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [RemainingFoodHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a8847697ef14a99f2ea4849ec7e65082c) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [SecurityHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a488dc6036adbb4ad2335636b70d18a82) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [PartyFilterHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a903381e7595577e8a595807e5d79e704) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [CharacterFilterHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#abf20009025c6029f41a3de75a7dd998e) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [MilitasHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aadee57f3a48f1ce193c5af9d25c038f9) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [GarrisonHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aa2154e7e56943f4549938554013b07df) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [ProsperityHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a7d7331e0fc2836f25de32f0f52349d8c) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [LoyaltyHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a1db49cd53b0c853c5ab07808d94016f4) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [WallsHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a2976ec400d20d41326bece28a916242d) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [CrimeHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a4043463e1a2ef64b090e649b8deb0fce) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [LeaveMembersHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#ad85698e5276853528e9db588dd497be1) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [SettlementOwnerBanner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a9ccdd3257989248b8fc45b38d63326a2) `[get, set]` |
| MBBindingList< [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) > | [CharacterList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a092c8f532fabc11127f419f97a88594a) `[get, set]` |
| MBBindingList< [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) > | [PartyList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a3a42ed80a6af559dfb0eacb21d992c13) `[get, set]` |
| MBBindingList< [StringItemWithHintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_item_with_hint_v_m.html) > | [IssueList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aad8b0378d3215fb933fadd6c4d1878cf) `[get, set]` |
| string | [MilitasLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a93ed4f6663121fd012ce0c4ffff0725d) `[get, set]` |
| string | [GarrisonLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a7bcaff758912533bcb4e32a8eb171c27) `[get, set]` |
| string | [CrimeLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a70e2ddd827a367a23a0e53aa7888fb4a) `[get, set]` |
| bool | [CanLeaveMembers](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a3f737faf5758f85fc1cae64fc68b26be) `[get, set]` |
| string | [ProsperityLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a08c5a5be060d22ed6b1d698baa830557) `[get, set]` |
| string | [LoyaltyLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aa9b4cf28d6f5f6ead748cba8f1584fe5) `[get, set]` |
| string | [SecurityLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aec5c0daa5c8589de7a82d5ad10b4c8ce) `[get, set]` |
| string | [WallsLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a0cf270d96ab26c479133a26656b9ed70) `[get, set]` |
| int | [WallsLevel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#ac997ecab5321cd4506ce340006ecdb97) `[get, set]` |
| string | [SettlementNameLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a6aa865859a247ecd9c7d8a6a89f90026) `[get, set]` |
| bool | [IsFortification](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#adf37ebc057303b1c19c3bf3e842c7c14) `[get, set]` |
| bool | [IsCrimeEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a563956a969d71620574e97bdd2aaed2c) `[get, set]` |
| bool | [IsNoGarrisonWarning](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a36fdac696afd09c2b05f6efedeacad13) `[get, set]` |
| bool | [IsCrimeLabelHighlightEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a812502772c22d49be546e1dddb2b0206) `[get, set]` |
| bool | [IsLoyaltyRebellionWarning](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#af4b8b018235a44c404f27547d788c38e) `[get, set]` |
| bool | [IsShipyardEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a8a8a0c386f68e078b871f2668876a57e) `[get, set]` |
| string | [ShipyardLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a1f7b86b65ade871ec1abb6ffe98fec03) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [ShipyardHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a897ed7e3676d0948dd1a60a7551cc9a1) `[get, set]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a23c7ee7b1a6d24521cefbdd1db60e866)SettlementMenuOverlayVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.SettlementMenuOverlayVM | ( | [GameMenus.GameMenu.MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) | *type* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#af40a0e1c708a5aaaaf13c0d3fbc47e57)RefreshValues()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#a4eaeef846d85c6c1abd876ad5029a7fc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a8237f3ade076c14a178f7dbd3c81d019)ExecuteOnSetAsActiveContextMenuItem()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.ExecuteOnSetAsActiveContextMenuItem | ( | [GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html) | *troop* | ) |  | | protectedvirtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#abbee9db91eb0ea433ec51722297211b5).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a3051e8ac7a7d2561db32d4c1043ef8eb)ExecuteOnOverlayClosed()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.ExecuteOnOverlayClosed | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#aadd70e26359f4cbc31e2cd131a53d873).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a72bcb1b09a2f84cab9c152a30d25c47e)UpdateOverlayType()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.UpdateOverlayType | ( | [GameMenus.GameMenu.MenuOverlayType](class_tale_worlds_1_1_campaign_system_1_1_game_menus_1_1_game_menu.html#a105216128b909e180a28a34f96df0b78) | *newType* | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#af4715c6a9ad71d9742753782ff2b5585).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#afa750f85800729919c32fc9a5f1a1468)Refresh()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.Refresh | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#aece0c5e255bf1ad69b54ea4b7916aba6).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a0c5822c14c544f862775695a228c99b3)ExecuteAddCompanion()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.ExecuteAddCompanion | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a408356114f195d28714f6895f6d8287b)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.GameMenuOverlay](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_overlay.html#ac93783b694a67eece3dba96fcde9a32e).

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aefd40679dc17525b90eeb179e367db93)\_settlement
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | readonly [Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.\_settlement | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a113cb66ba82601e21a81da4113166fbb)RemainingFoodText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.RemainingFoodText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a4f6bc6451670606f6cdfd37fb4f950c0)ProsperityChangeAmount
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.ProsperityChangeAmount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a2eae99ba39a650d04e9a917f2c4d484c)MilitiaChangeAmount
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.MilitiaChangeAmount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aee94ecf1f35aa0d203988664fb3a14c7)GarrisonChangeAmount
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.GarrisonChangeAmount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#ad8d84d1dabf58ea501ab2d8f73e508a0)GarrisonAmount
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.GarrisonAmount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#ac740e1b583b8cabe4a237724fc0a4fb0)CrimeChangeAmount
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.CrimeChangeAmount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#ab845a701a8f76527c7877f60c97eff90)LoyaltyChangeAmount
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.LoyaltyChangeAmount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a1254e0cd10cddce2daf45e017ad8ea4f)SecurityChangeAmount
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.SecurityChangeAmount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a09e2a33ab5caca7302f94d837869fb1d)FoodChangeAmount
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.FoodChangeAmount | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a8847697ef14a99f2ea4849ec7e65082c)RemainingFoodHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.RemainingFoodHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a488dc6036adbb4ad2335636b70d18a82)SecurityHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.SecurityHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a903381e7595577e8a595807e5d79e704)PartyFilterHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.PartyFilterHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#abf20009025c6029f41a3de75a7dd998e)CharacterFilterHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.CharacterFilterHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aadee57f3a48f1ce193c5af9d25c038f9)MilitasHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.MilitasHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aa2154e7e56943f4549938554013b07df)GarrisonHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.GarrisonHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a7d7331e0fc2836f25de32f0f52349d8c)ProsperityHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.ProsperityHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a1db49cd53b0c853c5ab07808d94016f4)LoyaltyHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.LoyaltyHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a2976ec400d20d41326bece28a916242d)WallsHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.WallsHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a4043463e1a2ef64b090e649b8deb0fce)CrimeHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.CrimeHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#ad85698e5276853528e9db588dd497be1)LeaveMembersHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.LeaveMembersHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a9ccdd3257989248b8fc45b38d63326a2)SettlementOwnerBanner
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.SettlementOwnerBanner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a092c8f532fabc11127f419f97a88594a)CharacterList
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.CharacterList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a3a42ed80a6af559dfb0eacb21d992c13)PartyList
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[GameMenuPartyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_game_menu_party_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.PartyList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aad8b0378d3215fb933fadd6c4d1878cf)IssueList
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[StringItemWithHintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_item_with_hint_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.IssueList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a93ed4f6663121fd012ce0c4ffff0725d)MilitasLbl
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.MilitasLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a7bcaff758912533bcb4e32a8eb171c27)GarrisonLbl
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.GarrisonLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a70e2ddd827a367a23a0e53aa7888fb4a)CrimeLbl
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.CrimeLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a3f737faf5758f85fc1cae64fc68b26be)CanLeaveMembers
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.CanLeaveMembers | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a08c5a5be060d22ed6b1d698baa830557)ProsperityLbl
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.ProsperityLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aa9b4cf28d6f5f6ead748cba8f1584fe5)LoyaltyLbl
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.LoyaltyLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#aec5c0daa5c8589de7a82d5ad10b4c8ce)SecurityLbl
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.SecurityLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a0cf270d96ab26c479133a26656b9ed70)WallsLbl
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.WallsLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#ac997ecab5321cd4506ce340006ecdb97)WallsLevel
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.WallsLevel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a6aa865859a247ecd9c7d8a6a89f90026)SettlementNameLbl
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.SettlementNameLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#adf37ebc057303b1c19c3bf3e842c7c14)IsFortification
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.IsFortification | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a563956a969d71620574e97bdd2aaed2c)IsCrimeEnabled
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.IsCrimeEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a36fdac696afd09c2b05f6efedeacad13)IsNoGarrisonWarning
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.IsNoGarrisonWarning | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a812502772c22d49be546e1dddb2b0206)IsCrimeLabelHighlightEnabled
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.IsCrimeLabelHighlightEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#af4b8b018235a44c404f27547d788c38e)IsLoyaltyRebellionWarning
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.IsLoyaltyRebellionWarning | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a8a8a0c386f68e078b871f2668876a57e)IsShipyardEnabled
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.IsShipyardEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a1f7b86b65ade871ec1abb6ffe98fec03)ShipyardLbl
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.ShipyardLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_game_menu_1_1_overlay_1_1_settlement_menu_overlay_v_m.html#a897ed7e3676d0948dd1a60a7551cc9a1)ShipyardHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.GameMenu.Overlay.SettlementMenuOverlayVM.ShipyardHint | | getset |

