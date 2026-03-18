--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Classes | |
| class | [PieceTierComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_db41aab0d49233261c345d77fd9fb43e1.html) |
| class | [TemplateComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_d29d252ff93b5617c4ab787c774e7cd79.html) |
| class | [WeaponPropertyComparer](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_d946a7a5b71bd6e2c0c75521e49105f75.html) |

|  |  |
| --- | --- |
| Public Types | |
| enum | [CraftingPieceTierFilter](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0634f3122ce84e616a0b90136d24d3e9) {     [None](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0634f3122ce84e616a0b90136d24d3e9a6adf97f83acf6453d4a6a4b1070f3754) = 0 ,     [Tier1](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0634f3122ce84e616a0b90136d24d3e9a0fdf99ebbdcd0198744caa9b8c5c6ca4) = 1 ,     [Tier2](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0634f3122ce84e616a0b90136d24d3e9ad167d667548ae1364f67b9ce0b6918a5) = 2 ,     [Tier3](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0634f3122ce84e616a0b90136d24d3e9a1fee01fe8bbe05778f82f32df56b0061) = 4 ,     [Tier4](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0634f3122ce84e616a0b90136d24d3e9a7aac5960e1b9dacecffcf57aa0926010) = 8 ,     [Tier5](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0634f3122ce84e616a0b90136d24d3e9a1f71693058d07557f02a29e50746f1aa) = 16 ,     [All](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0634f3122ce84e616a0b90136d24d3e9ab1c94ca2fbc3e78fc30069c8d0f01680) = Tier1 | Tier2 | Tier3 | Tier4 | Tier5   } |

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [WeaponDesignVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a4615d0690ffef29f0947be6bbc69f8a0) ([Crafting](class_tale_worlds_1_1_core_1_1_crafting.html) crafting, [ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html) craftingBehavior, Action onRefresh, Action onWeaponCrafted, Func< [CraftingAvailableHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_available_hero_item_v_m.html) > getCurrentCraftingHero, Action< [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) > refreshHeroAvailabilities, Func< [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html), [ItemObject.ItemUsageSetFlags](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22) > getItemUsageSetFlags) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ace28e9c5651ac0a1821be3df26abf920) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab1197b912b7bb8c0999f9500118c6e53) () |
| void | [SetPieceNewlyUnlocked](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#abdce93978ea2845e11c01504dcd20c2f) ([CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) piece) |
| void | [SelectPrimaryWeaponClass](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ac679a16640dc9e445f625ab89cabd490) ([CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) template) |
| void | [ExecuteOpenOrderPopup](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a7b52e48977bf752bfce6214dac85bbec) () |
| void | [ExecuteCloseOrderPopup](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a52f1f954095a09f1d98e4d8d71e33b62) () |
| void | [ExecuteOpenOrdersTab](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a7589101c0bd0244ed8b379f961def82f) () |
| void | [ExecuteOpenWeaponClassSelectionPopup](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a29088dcaa5a539269a6cab6ccbf38f26) () |
| void | [ExecuteOpenFreeBuildTab](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab26148ca75dad4b3bfd71218272b2f2b) () |
| void | [CreateCraftingResultPopup](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a23e885fb549a9694c231f4045de8abca) () |
| void | [ExecuteToggleShowOnlyUnlockedPieces](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a3e293e16cbdba2a2af7bb5b93de810b3) () |
| void | [ExecuteUndo](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a6a941f958e22d5fad37ec8d8cc48758e) () |
| void | [ExecuteRedo](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a496af88968bf97ff788c6bef44e2260b) () |
| void | [ChangeModeIfHeroIsUnavailable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0d3bc492501de86d0a373edc78f56167) () |
| void | [ExecuteBeginHeroHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a55938b600565dfaeaaf3cd48b3bb6cfd) () |
| void | [ExecuteEndHeroHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a6cb5ee3414174fd9471074d8ab874b89) () |
| void | [ExecuteRandomize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a5f5ca0d6dea06913dd08b85e51076567) () |
| void | [ExecuteChangeScabbardVisibility](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a894ac4e8fed258f796a806df2ae18d41) () |
| void | [SelectWeapon](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab5636d52e68b1f3e462902d1717632cf) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) itemObject) |
| bool | [CanCompleteOrder](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ad34e45863fa34ed66969721d75257299) () |
| void | [ExecuteFinalizeCrafting](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a46c255f16aa8bc77dcd92f22e150eaa5) () |
| void | [RefreshItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a97a55e636f63a2d53761bdd87e717565) () |
| bool | [HaveUnlockedAllSelectedPieces](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a46f086c6b24d72635d2185c6814ed564) () |
| void | [SwitchToPiece](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#aecda3ffeb823463c0dfb510985bd5d4c) ([WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html) usedPiece) |
| void | [DebugTick](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a41add828a1276d6606e561f766f654b9) (float dt) |
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
| Static Public Member Functions | |
| static string | [SetCraftingDebugMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a2022e4bcf3a81357dd8d4a065b988c2c) (List< string > arguments) |
| Static Public Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static void | [RefreshPropertyAndMethodInfos](class_tale_worlds_1_1_library_1_1_view_model.html#af97f39f16f411d47a799f0544f96ede1) () |

|  |  |
| --- | --- |
| Public Attributes | |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | [CraftedItemObject](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a36624cd6282d898efe6e65d98b4e4b6a) |
| SelectorVM< [CraftingSecondaryUsageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_secondary_usage_item_v_m.html) > | [\_secondaryUsageSelector](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#aa18d37c7e0ea94169e50fbe01f368482) |

|  |  |
| --- | --- |
| Static Public Attributes | |
| const int | [MAX\_SKILL\_LEVEL](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a886f470f42644627fba902ce675ae981) = 300 |
| Static Public Attributes inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
| static bool | [UIDebugMode](class_tale_worlds_1_1_library_1_1_view_model.html#a14668e8bcc887c0a2edfa9593be97fe5) |

|  |  |
| --- | --- |
| Properties | |
| MBBindingList< [TierFilterTypeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_tier_filter_type_v_m.html) > | [TierFilters](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a60aebb40b1ea1aa3d7f72ddb06e3fe70) `[get, set]` |
| string | [CurrentCraftedWeaponTemplateId](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a331c88673f93ec8e55b37006285d29cc) `[get, set]` |
| string | [ChooseOrderText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#aef5c04927428bc60f28e55ef5c15bb27) `[get, set]` |
| string | [ChooseWeaponTypeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a28549f2007115d30a26e51384eeb9fa5) `[get, set]` |
| string | [CurrentCraftedWeaponTypeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab5c36d860286793aee12e0ace30dab5e) `[get, set]` |
| MBBindingList< [CraftingPieceListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de3d1a18ac56143f775e88b02d87a5809.html) > | [PieceLists](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a7d61901cf4fcbc6a29dc4b8ffa90d634) `[get, set]` |
| int | [SelectedPieceTypeIndex](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ad0576bf51a9424fcdbed78fc63e8bdb7) `[get, set]` |
| bool | [ShowOnlyUnlockedPieces](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0c1fd7dae9150ab17bd2d2edba8cf301) `[get, set]` |
| string | [MissingPropertyWarningText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#adf1d80a6a27dd8a539490dfa6ba9b171) `[get, set]` |
| [WeaponDesignResultPopupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html) | [CraftingResultPopup](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#abf1b79f0963a94be019a1ee400364445) `[get, set]` |
| bool | [IsOrderButtonActive](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a392c9c3ff77727685d98a991d496edfb) `[get, set]` |
| bool | [IsInOrderMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a441479b296b156544f6baaca1aff7b41) `[get, set]` |
| bool | [IsInFreeMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab7184bec1275ba62e4421fe59ad92338) `[get, set]` |
| string | [FreeModeButtonText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a037c9430938abf094a0a06e07e6780e0) `[get, set]` |
| [CraftingOrderItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html) | [ActiveCraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a93d71fc4eee02f35ac776c903672d30e) `[get, set]` |
| [CraftingOrderPopupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_d391d57781214727040acae94f7dbf164.html) | [CraftingOrderPopup](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a6e319b0047f62c9350924121075fc2cf) `[get, set]` |
| [WeaponClassSelectionPopupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_db2fc7d9bb7137e6d15d19ef7e1677fb8.html) | [WeaponClassSelectionPopup](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0cb5851c579f4d667f05c4c1e6e7bf4c) `[get, set]` |
| MBBindingList< [CraftingListPropertyItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_list_property_item.html) > | [PrimaryPropertyList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a1bba154714d3839d4399bff8c98fa0dd) `[get, set]` |
| MBBindingList< [WeaponDesignResultPropertyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_d442000a32ba2387ee48040dfc6db3f19.html) > | [DesignResultPropertyList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a9e0843733885f749f28d84ee8f60f66e) `[get, set]` |
| SelectorVM< [CraftingSecondaryUsageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_secondary_usage_item_v_m.html) > | [SecondaryUsageSelector](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#aa24a72a7426de81ca284d1a9ca6d17bb) `[get, set]` |
| [ItemCollectionElementViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_collection_element_view_model.html) | [CraftedItemVisual](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a7d0adadb206266dc78ec0ca12dd6596a) `[get, set]` |
| bool | [IsInFinalCraftingStage](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a319bbaf762382dda78f13a6f45bc153c) `[get, set]` |
| string | [ItemName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ae400af4a805d2d821bfa44372e917aac) `[get, set]` |
| bool | [IsScabbardVisible](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#afe43921d6711758bcb45362ac875404c) `[get, set]` |
| bool | [CurrentWeaponHasScabbard](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0419e3d1c2d1aee117e0fa5a4528ed8d) `[get, set]` |
| int | [CurrentDifficulty](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab4d466cc76b2491123a0b040c8a62887) `[get, set]` |
| int | [CurrentOrderDifficulty](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a179fc073de1e1be3b8b37e83663a25bb) `[get, set]` |
| int | [MaxDifficulty](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a661a0ece4b1b57f848f5df140bea5660) `[get, set]` |
| bool | [IsCurrentHeroAtMaxCraftingSkill](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a07ec76efb8f6f2d219f8ba9194e79ce2) `[get, set]` |
| int | [CurrentHeroCraftingSkill](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#aca72ca758c5a792a5dd71ddd488414ea) `[get, set]` |
| string | [CurrentDifficultyText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a3a7fc84c0199f5c557d94f1a258f8e00) `[get, set]` |
| string | [CurrentOrderDifficultyText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ad53e980e754d00fc83e8ec8459caaba6) `[get, set]` |
| string | [CurrentCraftingSkillValueText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a1349dd8429aaffe1d1bdda934d56cf99) `[get, set]` |
| string | [DifficultyText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab6a16d33d3aa24a3c645f8705ae39854) `[get, set]` |
| string | [DefaultUsageText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#aaedfad40fdc71910645604f5ee7a1c50) `[get, set]` |
| string | [AlternativeUsageText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a12ebb0fbed0c8194a77f6fa40e637f71) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [OrderDisabledReasonHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a83a17366e7f840ccdb38ebb9d5c2d54a) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ShowOnlyUnlockedPiecesHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ad1de5d39231346f409dc5ac99547e19f) `[get, set]` |
| [CraftingPieceListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de3d1a18ac56143f775e88b02d87a5809.html) | [ActivePieceList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a63d1392e8bce665cf23278d40f7262f7) `[get, set]` |
| [CraftingPieceListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de3d1a18ac56143f775e88b02d87a5809.html) | [BladePieceList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#acae450a11652c92de73f15f2ecc54aa5) `[get, set]` |
| [CraftingPieceListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de3d1a18ac56143f775e88b02d87a5809.html) | [GuardPieceList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#adb39b83953d62ba160209058eb84567a) `[get, set]` |
| [CraftingPieceListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de3d1a18ac56143f775e88b02d87a5809.html) | [HandlePieceList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a528dddbc11b5b7ac7e6a01bbf870f5d4) `[get, set]` |
| [CraftingPieceListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de3d1a18ac56143f775e88b02d87a5809.html) | [PommelPieceList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a2eb1e4bbbaa054d4954711d31d794ecf) `[get, set]` |
| [CraftingPieceVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_piece_v_m.html) | [SelectedBladePiece](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a8efd4506a06e102462c6088ad34c43fa) `[get, set]` |
| [CraftingPieceVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_piece_v_m.html) | [SelectedGuardPiece](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a57bdc611d35089ca470c9d52029b1da2) `[get, set]` |
| [CraftingPieceVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_piece_v_m.html) | [SelectedHandlePiece](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a76fc1343bcbc380da5b51d9588742d8c) `[get, set]` |
| [CraftingPieceVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_piece_v_m.html) | [SelectedPommelPiece](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ae8c01fbf533e01249eb2b737312987e4) `[get, set]` |
| int | [ActivePieceSize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a2d652d7f1750b4d260615627bb72d197) `[get, set]` |
| int | [BladeSize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a39d1513b6b271855ff36014d57bda3be) `[get, set]` |
| int | [GuardSize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ac98e26b2f9be6003447ee09c0c1b9358) `[get, set]` |
| int | [HandleSize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a3c718fedf4604f24b8f8d1005bd43bc3) `[get, set]` |
| int | [PommelSize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a370f275bcaf31ab1e005230eb20f6cfb) `[get, set]` |
| string | [ComponentSizeLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ae098943f830ed4de07ba1de4e8f0618c) `[get, set]` |
| bool | [IsWeaponCivilian](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ad4bf0052ecb0e9b6fa755d80a6a2c040) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ScabbardHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a124ff5716a9e9ad6dd8cb2bfb83aafde) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RandomizeHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#afd254c7e2b4c844a428b3a5f723c5037) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [UndoHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#af53fb60976cdede94c6032165435a340) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [RedoHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ae8869db1d87af343b6062db10a349531) `[get, set]` |
| MBBindingList< [ItemFlagVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_flag_v_m.html) > | [WeaponFlagIconsList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0725dab1d475d656e3362c3efe5875c0) `[get, set]` |
| [CraftingHistoryVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html) | [CraftingHistory](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a1dbe22add649b4d1c7f9bddabbf402ce) `[get, set]` |

|  |  |
| --- | --- |
| Additional Inherited Members | |
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

Member Enumeration Documentation
--------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0634f3122ce84e616a0b90136d24d3e9)CraftingPieceTierFilter
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| enum TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CraftingPieceTierFilter |

| Enumerator | |
| --- | --- |
| None |  |
| Tier1 |  |
| Tier2 |  |
| Tier3 |  |
| Tier4 |  |
| Tier5 |  |
| All |  |

Constructor & Destructor Documentation
--------------------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a4615d0690ffef29f0947be6bbc69f8a0)WeaponDesignVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.WeaponDesignVM | ( | [Crafting](class_tale_worlds_1_1_core_1_1_crafting.html) | *crafting*, |
|  |  | [ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html) | *craftingBehavior*, |
|  |  | Action | *onRefresh*, |
|  |  | Action | *onWeaponCrafted*, |
|  |  | Func< [CraftingAvailableHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_available_hero_item_v_m.html) > | *getCurrentCraftingHero*, |
|  |  | Action< [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) > | *refreshHeroAvailabilities*, |
|  |  | Func< [WeaponComponentData](class_tale_worlds_1_1_core_1_1_weapon_component_data.html), [ItemObject.ItemUsageSetFlags](class_tale_worlds_1_1_core_1_1_item_object.html#aa70dbfec5035754721873468a3526c22) > | *getItemUsageSetFlags* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ace28e9c5651ac0a1821be3df26abf920)RefreshValues()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab1197b912b7bb8c0999f9500118c6e53)OnFinalize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#abdce93978ea2845e11c01504dcd20c2f)SetPieceNewlyUnlocked()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.SetPieceNewlyUnlocked | ( | [CraftingPiece](class_tale_worlds_1_1_core_1_1_crafting_piece.html) | *piece* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ac679a16640dc9e445f625ab89cabd490)SelectPrimaryWeaponClass()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.SelectPrimaryWeaponClass | ( | [CraftingTemplate](class_tale_worlds_1_1_core_1_1_crafting_template.html) | *template* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a7b52e48977bf752bfce6214dac85bbec)ExecuteOpenOrderPopup()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ExecuteOpenOrderPopup | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a52f1f954095a09f1d98e4d8d71e33b62)ExecuteCloseOrderPopup()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ExecuteCloseOrderPopup | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a7589101c0bd0244ed8b379f961def82f)ExecuteOpenOrdersTab()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ExecuteOpenOrdersTab | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a29088dcaa5a539269a6cab6ccbf38f26)ExecuteOpenWeaponClassSelectionPopup()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ExecuteOpenWeaponClassSelectionPopup | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab26148ca75dad4b3bfd71218272b2f2b)ExecuteOpenFreeBuildTab()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ExecuteOpenFreeBuildTab | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a23e885fb549a9694c231f4045de8abca)CreateCraftingResultPopup()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CreateCraftingResultPopup | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a3e293e16cbdba2a2af7bb5b93de810b3)ExecuteToggleShowOnlyUnlockedPieces()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ExecuteToggleShowOnlyUnlockedPieces | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a6a941f958e22d5fad37ec8d8cc48758e)ExecuteUndo()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ExecuteUndo | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a496af88968bf97ff788c6bef44e2260b)ExecuteRedo()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ExecuteRedo | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0d3bc492501de86d0a373edc78f56167)ChangeModeIfHeroIsUnavailable()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ChangeModeIfHeroIsUnavailable | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a55938b600565dfaeaaf3cd48b3bb6cfd)ExecuteBeginHeroHint()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ExecuteBeginHeroHint | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a6cb5ee3414174fd9471074d8ab874b89)ExecuteEndHeroHint()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ExecuteEndHeroHint | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a5f5ca0d6dea06913dd08b85e51076567)ExecuteRandomize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ExecuteRandomize | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a894ac4e8fed258f796a806df2ae18d41)ExecuteChangeScabbardVisibility()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ExecuteChangeScabbardVisibility | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab5636d52e68b1f3e462902d1717632cf)SelectWeapon()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.SelectWeapon | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *itemObject* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ad34e45863fa34ed66969721d75257299)CanCompleteOrder()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CanCompleteOrder | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a46c255f16aa8bc77dcd92f22e150eaa5)ExecuteFinalizeCrafting()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ExecuteFinalizeCrafting | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a97a55e636f63a2d53761bdd87e717565)RefreshItem()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.RefreshItem | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a46f086c6b24d72635d2185c6814ed564)HaveUnlockedAllSelectedPieces()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.HaveUnlockedAllSelectedPieces | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#aecda3ffeb823463c0dfb510985bd5d4c)SwitchToPiece()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.SwitchToPiece | ( | [WeaponDesignElement](class_tale_worlds_1_1_core_1_1_weapon_design_element.html) | *usedPiece* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a2022e4bcf3a81357dd8d4a065b988c2c)SetCraftingDebugMode()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  |  | | --- | --- | --- | --- | --- | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.SetCraftingDebugMode | ( | List< string > | *arguments* | ) |  | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a41add828a1276d6606e561f766f654b9)DebugTick()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.DebugTick | ( | float | *dt* | ) |  |

Member Data Documentation
-------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a886f470f42644627fba902ce675ae981)MAX\_SKILL\_LEVEL
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | const int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.MAX\_SKILL\_LEVEL = 300 | | static |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a36624cd6282d898efe6e65d98b4e4b6a)CraftedItemObject
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CraftedItemObject |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#aa18d37c7e0ea94169e50fbe01f368482)\_secondaryUsageSelector
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |
| --- |
| SelectorVM<[CraftingSecondaryUsageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_secondary_usage_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.\_secondaryUsageSelector |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a60aebb40b1ea1aa3d7f72ddb06e3fe70)TierFilters
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[TierFilterTypeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_tier_filter_type_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.TierFilters | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a331c88673f93ec8e55b37006285d29cc)CurrentCraftedWeaponTemplateId
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CurrentCraftedWeaponTemplateId | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#aef5c04927428bc60f28e55ef5c15bb27)ChooseOrderText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ChooseOrderText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a28549f2007115d30a26e51384eeb9fa5)ChooseWeaponTypeText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ChooseWeaponTypeText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab5c36d860286793aee12e0ace30dab5e)CurrentCraftedWeaponTypeText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CurrentCraftedWeaponTypeText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a7d61901cf4fcbc6a29dc4b8ffa90d634)PieceLists
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[CraftingPieceListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de3d1a18ac56143f775e88b02d87a5809.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.PieceLists | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ad0576bf51a9424fcdbed78fc63e8bdb7)SelectedPieceTypeIndex
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.SelectedPieceTypeIndex | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0c1fd7dae9150ab17bd2d2edba8cf301)ShowOnlyUnlockedPieces
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ShowOnlyUnlockedPieces | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#adf1d80a6a27dd8a539490dfa6ba9b171)MissingPropertyWarningText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.MissingPropertyWarningText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#abf1b79f0963a94be019a1ee400364445)CraftingResultPopup
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponDesignResultPopupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CraftingResultPopup | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a392c9c3ff77727685d98a991d496edfb)IsOrderButtonActive
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.IsOrderButtonActive | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a441479b296b156544f6baaca1aff7b41)IsInOrderMode
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.IsInOrderMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab7184bec1275ba62e4421fe59ad92338)IsInFreeMode
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.IsInFreeMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a037c9430938abf094a0a06e07e6780e0)FreeModeButtonText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.FreeModeButtonText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a93d71fc4eee02f35ac776c903672d30e)ActiveCraftingOrder
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingOrderItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ActiveCraftingOrder | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a6e319b0047f62c9350924121075fc2cf)CraftingOrderPopup
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingOrderPopupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_d391d57781214727040acae94f7dbf164.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CraftingOrderPopup | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0cb5851c579f4d667f05c4c1e6e7bf4c)WeaponClassSelectionPopup
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponClassSelectionPopupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_db2fc7d9bb7137e6d15d19ef7e1677fb8.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.WeaponClassSelectionPopup | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a1bba154714d3839d4399bff8c98fa0dd)PrimaryPropertyList
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[CraftingListPropertyItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_list_property_item.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.PrimaryPropertyList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a9e0843733885f749f28d84ee8f60f66e)DesignResultPropertyList
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[WeaponDesignResultPropertyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_d442000a32ba2387ee48040dfc6db3f19.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.DesignResultPropertyList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#aa24a72a7426de81ca284d1a9ca6d17bb)SecondaryUsageSelector
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[CraftingSecondaryUsageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_secondary_usage_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.SecondaryUsageSelector | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a7d0adadb206266dc78ec0ca12dd6596a)CraftedItemVisual
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemCollectionElementViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_collection_element_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CraftedItemVisual | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a319bbaf762382dda78f13a6f45bc153c)IsInFinalCraftingStage
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.IsInFinalCraftingStage | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ae400af4a805d2d821bfa44372e917aac)ItemName
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ItemName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#afe43921d6711758bcb45362ac875404c)IsScabbardVisible
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.IsScabbardVisible | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0419e3d1c2d1aee117e0fa5a4528ed8d)CurrentWeaponHasScabbard
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CurrentWeaponHasScabbard | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab4d466cc76b2491123a0b040c8a62887)CurrentDifficulty
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CurrentDifficulty | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a179fc073de1e1be3b8b37e83663a25bb)CurrentOrderDifficulty
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CurrentOrderDifficulty | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a661a0ece4b1b57f848f5df140bea5660)MaxDifficulty
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.MaxDifficulty | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a07ec76efb8f6f2d219f8ba9194e79ce2)IsCurrentHeroAtMaxCraftingSkill
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.IsCurrentHeroAtMaxCraftingSkill | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#aca72ca758c5a792a5dd71ddd488414ea)CurrentHeroCraftingSkill
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CurrentHeroCraftingSkill | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a3a7fc84c0199f5c557d94f1a258f8e00)CurrentDifficultyText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CurrentDifficultyText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ad53e980e754d00fc83e8ec8459caaba6)CurrentOrderDifficultyText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CurrentOrderDifficultyText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a1349dd8429aaffe1d1bdda934d56cf99)CurrentCraftingSkillValueText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CurrentCraftingSkillValueText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ab6a16d33d3aa24a3c645f8705ae39854)DifficultyText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.DifficultyText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#aaedfad40fdc71910645604f5ee7a1c50)DefaultUsageText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.DefaultUsageText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a12ebb0fbed0c8194a77f6fa40e637f71)AlternativeUsageText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.AlternativeUsageText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a83a17366e7f840ccdb38ebb9d5c2d54a)OrderDisabledReasonHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.OrderDisabledReasonHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ad1de5d39231346f409dc5ac99547e19f)ShowOnlyUnlockedPiecesHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ShowOnlyUnlockedPiecesHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a63d1392e8bce665cf23278d40f7262f7)ActivePieceList
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingPieceListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de3d1a18ac56143f775e88b02d87a5809.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ActivePieceList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#acae450a11652c92de73f15f2ecc54aa5)BladePieceList
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingPieceListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de3d1a18ac56143f775e88b02d87a5809.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.BladePieceList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#adb39b83953d62ba160209058eb84567a)GuardPieceList
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingPieceListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de3d1a18ac56143f775e88b02d87a5809.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.GuardPieceList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a528dddbc11b5b7ac7e6a01bbf870f5d4)HandlePieceList
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingPieceListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de3d1a18ac56143f775e88b02d87a5809.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.HandlePieceList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a2eb1e4bbbaa054d4954711d31d794ecf)PommelPieceList
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingPieceListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de3d1a18ac56143f775e88b02d87a5809.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.PommelPieceList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a8efd4506a06e102462c6088ad34c43fa)SelectedBladePiece
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingPieceVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_piece_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.SelectedBladePiece | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a57bdc611d35089ca470c9d52029b1da2)SelectedGuardPiece
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingPieceVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_piece_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.SelectedGuardPiece | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a76fc1343bcbc380da5b51d9588742d8c)SelectedHandlePiece
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingPieceVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_piece_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.SelectedHandlePiece | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ae8c01fbf533e01249eb2b737312987e4)SelectedPommelPiece
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingPieceVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_piece_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.SelectedPommelPiece | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a2d652d7f1750b4d260615627bb72d197)ActivePieceSize
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ActivePieceSize | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a39d1513b6b271855ff36014d57bda3be)BladeSize
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.BladeSize | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ac98e26b2f9be6003447ee09c0c1b9358)GuardSize
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.GuardSize | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a3c718fedf4604f24b8f8d1005bd43bc3)HandleSize
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.HandleSize | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a370f275bcaf31ab1e005230eb20f6cfb)PommelSize
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.PommelSize | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ae098943f830ed4de07ba1de4e8f0618c)ComponentSizeLbl
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ComponentSizeLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ad4bf0052ecb0e9b6fa755d80a6a2c040)IsWeaponCivilian
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.IsWeaponCivilian | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a124ff5716a9e9ad6dd8cb2bfb83aafde)ScabbardHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.ScabbardHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#afd254c7e2b4c844a428b3a5f723c5037)RandomizeHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.RandomizeHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#af53fb60976cdede94c6032165435a340)UndoHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.UndoHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#ae8869db1d87af343b6062db10a349531)RedoHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.RedoHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a0725dab1d475d656e3362c3efe5875c0)WeaponFlagIconsList
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ItemFlagVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_flag_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.WeaponFlagIconsList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_design_v_m.html#a1dbe22add649b4d1c7f9bddabbf402ce)CraftingHistory
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CraftingHistoryVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignVM.CraftingHistory | | getset |

