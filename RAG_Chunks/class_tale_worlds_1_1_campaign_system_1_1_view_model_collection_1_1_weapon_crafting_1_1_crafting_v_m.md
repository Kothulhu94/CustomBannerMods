--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| delegate void | [OnItemRefreshedDelegate](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a07a0d8272a241c211a9a3b9d30c496ce) (bool isItemVisible) |
|  | [CraftingVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a1836e49784cdfcc8b3a3f28edf126c4c) ([Crafting](class_tale_worlds_1_1_core_1_1_crafting.html) crafting, Action onClose, Action resetCamera, Action onWeaponCrafted, Func< [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html), [ItemObject.ItemUsageSetFlags](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22) > getItemUsageSetFlags) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ae860bb25e1ba52acbdddb68d379df066) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a45dffa807dbfa1ee919830767975fdd5) () |
| void | [DebugTick](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ad31ee7b9e3faa2e47a3745d3a926e9ec) (float dt) |
| void | [OnCraftingLogicRefreshed](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a8b63ccf2f5e788ae90732e709e5c0bf6) ([Crafting](class_tale_worlds_1_1_core_1_1_crafting.html) newCraftingLogic) |
| void | [UpdateCraftingHero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#acf1368823984cf59c1b7c5fb945bfb95) ([CraftingAvailableHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_available_hero_item_v_m.html) newHero) |
| bool bool isMainActionExecuted | [ExecuteConfirm](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ae56464e32898dc7fd584bf69df3f055a) () |
| void | [ExecuteCancel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aa2e8700be8f20d19f57e8188f3b589f7) () |
| void | [ExecuteMainAction](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aa714654c76071b5535e5b3355b46a841) () |
| void | [ExecuteResetCamera](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a51969781fcf84a5cdc53f07362ce9b2a) () |
| void | [SetConfirmInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a66d22b551dfc8d5711e82a694137461e) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetExitInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a30bc9fccf8650d00cb308971e3f15635) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetPreviousTabInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a6d7363e7dc8ee97fc4990b188aca092a) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetNextTabInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#af188be93629e30f4e365550949ba7960) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a7603e80b5a1a02b5cf2040d55788a15c) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a82d4c1e31e3215c7a883f4b9a848810b) ([GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) gameKey) |
| void | [AddCameraControlInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a9c6026c1870194aba6035eff865c3fdc) ([GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) gameAxisKey) |
| void | [ExecuteSwitchToCrafting](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aa3dbf1dce846c50645250ae6f39982fd) () |
| void | [ExecuteSwitchToSmelting](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a1207480009e1707fe426f0484b4736fa) () |
| void | [ExecuteSwitchToRefinement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ab0b8000633e6d3feb2ff21d2c4e4cbef) () |
| void | [SetCurrentDesignManually](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a8fb0a4d2e45a14dbb7a80a364c6f54ef) ([CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) craftingTemplate,([CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html), int)[] pieces) |
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
| [OnItemRefreshedDelegate](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a07a0d8272a241c211a9a3b9d30c496ce) | [OnItemRefreshed](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ab0ec2d7877c735e65acfdbf38a3e2d08) |
| bool | [isConfirmSuccessful](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a44d3b64d60887304257b27faa4600af1) |
| [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) | [\_tutorialNotification](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ab6b392f932e6b1ac498b4a3ac98004e8) |

|  |  |
| --- | --- |
| Properties | |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [ConfirmInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a53d5e9e98cd8cce214fbe8ee5848756c) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [ExitInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a87f9a752eb7397d18d94af98332a3aaa) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [PreviousTabInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a641a4ee7072158d5909874f403f8e383) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [NextTabInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a71f493915035dc8c5ed4bf1f81b5c021) `[get, set]` |
| MBBindingList< [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) > | [CameraControlKeys](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ab2c20a36179c7e744832fa474605e1ed) `[get, set]` |
| bool | [CanSwitchTabs](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a3ceae2098aeaa7696526459a96218ea6) `[get, set]` |
| bool | [AreGamepadControlHintsEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ae61eafd2dd1fc2f25874d55f63f16f1b) `[get, set]` |
| MBBindingList< [CraftingResourceItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_resource_item_v_m.html) > | [PlayerCurrentMaterials](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ac97f534fb84e12b1c3bea1e0977d2e65) `[get, set]` |
| MBBindingList< [CraftingAvailableHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_available_hero_item_v_m.html) > | [AvailableCharactersForSmithing](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a389a28cb7f60a9f04ce43513f19a11a0) `[get, set]` |
| [CraftingAvailableHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_available_hero_item_v_m.html) | [CurrentCraftingHero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ac9592a572a5789da64115194c16453be) `[get, set]` |
| [CraftingHeroPopupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_hero_popup_v_m.html) | [CraftingHeroPopup](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a9e76e49b260b8a323b428ab506b254bf) `[get, set]` |
| string | [CurrentCategoryText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a8770448cf40e9fe21d931c40582f0e6c) `[get, set]` |
| string | [CraftingText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a329809230fd0be157b212a7f3e718ad0) `[get, set]` |
| string | [SmeltingText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a02e47be59dd3d80f757fd390d132f4a7) `[get, set]` |
| string | [RefinementText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aedb3999883990756241a1c91725c65d0) `[get, set]` |
| string | [MainActionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a138cdb85fea1090c2312075eb399c26c) `[get, set]` |
| bool | [IsMainActionEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a4b16c97da5a2b02f1611121dbbd75289) `[get, set]` |
| int | [ItemValue](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ad5d1d0a88f36b89e57d3ee5436b28630) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [CraftingHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aa9a12731248424195ddc1d88630dfa43) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RefiningHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#af7abc4376bbd0c6b11842e8e5ef75edf) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [SmeltingHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ad093da316c14327b130731a7f6c706bf) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ResetCameraHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a6378d547a511977c92e9e17dcbe1dc58) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [MainActionHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a167ec45d337108cabf0522e81e6edaa5) `[get, set]` |
| string | [DoneLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ac05bd5ab4e509404f95d9f7a60c9b6a9) `[get, set]` |
| string | [CancelLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a208e0b5f394c908d62103beb3fc1e90d) `[get, set]` |
| [SmeltingVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting_1_1_smelting_v_m.html) | [Smelting](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a715f653108f60af588eea2839647128c) `[get, set]` |
| [WeaponDesignVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html) | [WeaponDesign](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ae283b19a1fed627bd63b2fe9713f0834) `[get, set]` |
| [RefinementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_refinement_1_1_refinement_v_m.html) | [Refinement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a35d9c2f1cdae0572ef9a6ce70e372b5b) `[get, set]` |
| bool | [IsInCraftingMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a0a8bd214ab41171fc67fbefa73df48c7) `[get, set]` |
| bool | [IsInSmeltingMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ae6ce24836becea2db60ebe82a3166945) `[get, set]` |
| bool | [IsInRefinementMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aeaf1f783331d4e3b314595b23cc5976e) `[get, set]` |
| bool | [IsSmeltingItemSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#acdc8eb96581a80eea77151f10eef9031) `[get, set]` |
| bool | [IsRefinementItemSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a09550e2a5565645e9c38112c7ef669d1) `[get, set]` |
| string | [SelectItemToSmeltText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a5fb02abe78812daa3d735b0bdf06d8a2) `[get, set]` |
| string | [SelectItemToRefineText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a6e684651ba9826375b130a4dd59c6409) `[get, set]` |
| [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) | [TutorialNotification](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aae02a14e45df00bd3639a3c691df96c9) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a1836e49784cdfcc8b3a3f28edf126c4c)CraftingVM()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.CraftingVM | ( | [Crafting](class_tale_worlds_1_1_core_1_1_crafting.html) | *crafting*, |
|  |  | Action | *onClose*, |
|  |  | Action | *resetCamera*, |
|  |  | Action | *onWeaponCrafted*, |
|  |  | Func< [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html), [ItemObject.ItemUsageSetFlags](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22) > | *getItemUsageSetFlags* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a07a0d8272a241c211a9a3b9d30c496ce)OnItemRefreshedDelegate()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| delegate void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.OnItemRefreshedDelegate | ( | bool | *isItemVisible* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ae860bb25e1ba52acbdddb68d379df066)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a45dffa807dbfa1ee919830767975fdd5)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ad31ee7b9e3faa2e47a3745d3a926e9ec)DebugTick()
-----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.DebugTick | ( | float | *dt* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a8b63ccf2f5e788ae90732e709e5c0bf6)OnCraftingLogicRefreshed()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.OnCraftingLogicRefreshed | ( | [Crafting](class_tale_worlds_1_1_core_1_1_crafting.html) | *newCraftingLogic* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#acf1368823984cf59c1b7c5fb945bfb95)UpdateCraftingHero()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.UpdateCraftingHero | ( | [CraftingAvailableHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_available_hero_item_v_m.html) | *newHero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ae56464e32898dc7fd584bf69df3f055a)ExecuteConfirm()
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool bool isMainActionExecuted TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.ExecuteConfirm | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aa2e8700be8f20d19f57e8188f3b589f7)ExecuteCancel()
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.ExecuteCancel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aa714654c76071b5535e5b3355b46a841)ExecuteMainAction()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.ExecuteMainAction | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a51969781fcf84a5cdc53f07362ce9b2a)ExecuteResetCamera()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.ExecuteResetCamera | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a66d22b551dfc8d5711e82a694137461e)SetConfirmInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.SetConfirmInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a30bc9fccf8650d00cb308971e3f15635)SetExitInputKey()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.SetExitInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a6d7363e7dc8ee97fc4990b188aca092a)SetPreviousTabInputKey()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.SetPreviousTabInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#af188be93629e30f4e365550949ba7960)SetNextTabInputKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.SetNextTabInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a7603e80b5a1a02b5cf2040d55788a15c)AddCameraControlInputKey() [1/3]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.AddCameraControlInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a82d4c1e31e3215c7a883f4b9a848810b)AddCameraControlInputKey() [2/3]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.AddCameraControlInputKey | ( | [GameKey](class_tale_worlds_1_1_input_system_1_1_game_key.html) | *gameKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a9c6026c1870194aba6035eff865c3fdc)AddCameraControlInputKey() [3/3]
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.AddCameraControlInputKey | ( | [GameAxisKey](class_tale_worlds_1_1_input_system_1_1_game_axis_key.html) | *gameAxisKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aa3dbf1dce846c50645250ae6f39982fd)ExecuteSwitchToCrafting()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.ExecuteSwitchToCrafting | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a1207480009e1707fe426f0484b4736fa)ExecuteSwitchToSmelting()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.ExecuteSwitchToSmelting | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ab0b8000633e6d3feb2ff21d2c4e4cbef)ExecuteSwitchToRefinement()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.ExecuteSwitchToRefinement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a8fb0a4d2e45a14dbb7a80a364c6f54ef)SetCurrentDesignManually()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.SetCurrentDesignManually | ( | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) | *craftingTemplate*, |
|  |  | ([CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html), int)[] | *pieces* ) |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ab0ec2d7877c735e65acfdbf38a3e2d08)OnItemRefreshed
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [OnItemRefreshedDelegate](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a07a0d8272a241c211a9a3b9d30c496ce) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.OnItemRefreshed |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a44d3b64d60887304257b27faa4600af1)isConfirmSuccessful
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.isConfirmSuccessful |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ab6b392f932e6b1ac498b4a3ac98004e8)\_tutorialNotification
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.\_tutorialNotification |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a53d5e9e98cd8cce214fbe8ee5848756c)ConfirmInputKey
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.ConfirmInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a87f9a752eb7397d18d94af98332a3aaa)ExitInputKey
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.ExitInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a641a4ee7072158d5909874f403f8e383)PreviousTabInputKey
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.PreviousTabInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a71f493915035dc8c5ed4bf1f81b5c021)NextTabInputKey
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.NextTabInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ab2c20a36179c7e744832fa474605e1ed)CameraControlKeys
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.CameraControlKeys | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a3ceae2098aeaa7696526459a96218ea6)CanSwitchTabs
-------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.CanSwitchTabs | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ae61eafd2dd1fc2f25874d55f63f16f1b)AreGamepadControlHintsEnabled
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.AreGamepadControlHintsEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ac97f534fb84e12b1c3bea1e0977d2e65)PlayerCurrentMaterials
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[CraftingResourceItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_resource_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.PlayerCurrentMaterials | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a389a28cb7f60a9f04ce43513f19a11a0)AvailableCharactersForSmithing
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[CraftingAvailableHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_available_hero_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.AvailableCharactersForSmithing | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ac9592a572a5789da64115194c16453be)CurrentCraftingHero
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingAvailableHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_available_hero_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.CurrentCraftingHero | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a9e76e49b260b8a323b428ab506b254bf)CraftingHeroPopup
-----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingHeroPopupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_hero_popup_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.CraftingHeroPopup | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a8770448cf40e9fe21d931c40582f0e6c)CurrentCategoryText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.CurrentCategoryText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a329809230fd0be157b212a7f3e718ad0)CraftingText
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.CraftingText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a02e47be59dd3d80f757fd390d132f4a7)SmeltingText
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.SmeltingText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aedb3999883990756241a1c91725c65d0)RefinementText
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.RefinementText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a138cdb85fea1090c2312075eb399c26c)MainActionText
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.MainActionText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a4b16c97da5a2b02f1611121dbbd75289)IsMainActionEnabled
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.IsMainActionEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ad5d1d0a88f36b89e57d3ee5436b28630)ItemValue
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.ItemValue | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aa9a12731248424195ddc1d88630dfa43)CraftingHint
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.CraftingHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#af7abc4376bbd0c6b11842e8e5ef75edf)RefiningHint
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.RefiningHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ad093da316c14327b130731a7f6c706bf)SmeltingHint
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.SmeltingHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a6378d547a511977c92e9e17dcbe1dc58)ResetCameraHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.ResetCameraHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a167ec45d337108cabf0522e81e6edaa5)MainActionHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.MainActionHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ac05bd5ab4e509404f95d9f7a60c9b6a9)DoneLbl
-------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.DoneLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a208e0b5f394c908d62103beb3fc1e90d)CancelLbl
---------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.CancelLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a715f653108f60af588eea2839647128c)Smelting
--------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [SmeltingVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_smelting_1_1_smelting_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.Smelting | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ae283b19a1fed627bd63b2fe9713f0834)WeaponDesign
------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponDesignVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.WeaponDesign | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a35d9c2f1cdae0572ef9a6ce70e372b5b)Refinement
----------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [RefinementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_refinement_1_1_refinement_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.Refinement | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a0a8bd214ab41171fc67fbefa73df48c7)IsInCraftingMode
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.IsInCraftingMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#ae6ce24836becea2db60ebe82a3166945)IsInSmeltingMode
----------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.IsInSmeltingMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aeaf1f783331d4e3b314595b23cc5976e)IsInRefinementMode
------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.IsInRefinementMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#acdc8eb96581a80eea77151f10eef9031)IsSmeltingItemSelected
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.IsSmeltingItemSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a09550e2a5565645e9c38112c7ef669d1)IsRefinementItemSelected
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.IsRefinementItemSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a5fb02abe78812daa3d735b0bdf06d8a2)SelectItemToSmeltText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.SelectItemToSmeltText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#a6e684651ba9826375b130a4dd59c6409)SelectItemToRefineText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.SelectItemToRefineText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_v_m.html#aae02a14e45df00bd3639a3c691df96c9)TutorialNotification
--------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ElementNotificationVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_tutorial_1_1_element_notification_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.CraftingVM.TutorialNotification | | getset |

