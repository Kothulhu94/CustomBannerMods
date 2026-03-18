--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [WeaponDesignResultPopupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#af84dbbeb297638a64496701165fd28ab) ([ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) craftedItem, [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) itemName, Action onFinalize, [Crafting](class_tale_worlds_1_1_core_1_1_crafting.html) crafting, [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) completedOrder, [ItemCollectionElementViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_collection_element_view_model.html) itemVisualModel, MBBindingList< [ItemFlagVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_flag_v_m.html) > weaponFlagIconsList, Func< [CraftingSecondaryUsageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_secondary_usage_item_v_m.html), MBBindingList< [WeaponDesignResultPropertyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_d442000a32ba2387ee48040dfc6db3f19.html) > > onGetPropertyList, Action< [CraftingSecondaryUsageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_secondary_usage_item_v_m.html) > onUsageSelected) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a8c52be1ffa9821c62c822d7c23e5a79b) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a933808d93f86704c42a56c12424e09fd) () |
| void | [ExecuteFinalizeCrafting](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#ab7cd4a15d4a5a504a1fe25b3c01613f5) () |
| void | [ExecuteRandomCraftName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a783fdbc331fab5d0ef674bdee0fbe5eb) () |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a3b3c44bba4847e2f18b771c1ec60ab8a) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
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
| MBBindingList< [ItemFlagVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_flag_v_m.html) > | [WeaponFlagIconsList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a4ffdada1ec0a3e30324e61dfc5a53348) `[get, set]` |
| bool | [IsInOrderMode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a3189ce7985db6578b3aa4132b783fd3e) `[get, set]` |
| int | [CraftedWeaponFinalWorth](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a2d609b58ba754ce16d1650c244238e33) `[get, set]` |
| int | [CraftedWeaponPriceDifference](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a5c736990464f0045bf22ddd7875ba930) `[get, set]` |
| int | [CraftedWeaponInitialWorth](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#ae67aa8cff3e79975fa455b57e2dc514a) `[get, set]` |
| string | [CraftedWeaponWorthText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a12867deacdcbab485b07770e49c36fc4) `[get, set]` |
| bool | [IsOrderSuccessful](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#acc2351cc5fa40ace0c222b8723c30376) `[get, set]` |
| bool | [CanConfirm](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a72f917ea61de23d5f36f746f53594ffb) `[get, set]` |
| string | [OrderResultText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a5f3ca38da57264c262ea0d7ba023e26e) `[get, set]` |
| string | [OrderOwnerRemarkText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a8ba22ad49eed34316ff718401f88a086) `[get, set]` |
| string | [WeaponCraftedText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#ad8a61f11fad7211cbd3cac9340eaddc8) `[get, set]` |
| string | [DoneLbl](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#affebe526d6539e4d0cf11f51fa6075f6) `[get, set]` |
| MBBindingList< [WeaponDesignResultPropertyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_d442000a32ba2387ee48040dfc6db3f19.html) > | [DesignResultPropertyList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a0535b0d17213774299be7ca3775363da) `[get, set]` |
| string | [ItemName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a042732f1c2ae404ca1aadd263fb4edb8) `[get, set]` |
| [ItemCollectionElementViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_collection_element_view_model.html) | [ItemVisualModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a7c5eb0ae3765568a5dea209ab6510386) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ConfirmDisabledReasonHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#ac78299083d8f04d18bf87244dae2abaf) `[get, set]` |
| SelectorVM< [CraftingSecondaryUsageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_secondary_usage_item_v_m.html) > | [SecondaryUsageSelector](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a63fe22f15700c1ccd323626b1fc00d81) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a1974da67cf42aff29de3dc02667bea72) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#af84dbbeb297638a64496701165fd28ab)WeaponDesignResultPopupVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.WeaponDesignResultPopupVM | ( | [ItemObject](class_tale_worlds_1_1_core_1_1_item_object.html) | *craftedItem*, |
|  |  | [TextObject](class_tale_worlds_1_1_localization_1_1_text_object.html) | *itemName*, |
|  |  | Action | *onFinalize*, |
|  |  | [Crafting](class_tale_worlds_1_1_core_1_1_crafting.html) | *crafting*, |
|  |  | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) | *completedOrder*, |
|  |  | [ItemCollectionElementViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_collection_element_view_model.html) | *itemVisualModel*, |
|  |  | MBBindingList< [ItemFlagVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_flag_v_m.html) > | *weaponFlagIconsList*, |
|  |  | Func< [CraftingSecondaryUsageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_secondary_usage_item_v_m.html), MBBindingList< [WeaponDesignResultPropertyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_d442000a32ba2387ee48040dfc6db3f19.html) > > | *onGetPropertyList*, |
|  |  | Action< [CraftingSecondaryUsageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_secondary_usage_item_v_m.html) > | *onUsageSelected* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a8c52be1ffa9821c62c822d7c23e5a79b)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a933808d93f86704c42a56c12424e09fd)OnFinalize()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#ab7cd4a15d4a5a504a1fe25b3c01613f5)ExecuteFinalizeCrafting()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.ExecuteFinalizeCrafting | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a783fdbc331fab5d0ef674bdee0fbe5eb)ExecuteRandomCraftName()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.ExecuteRandomCraftName | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a3b3c44bba4847e2f18b771c1ec60ab8a)SetDoneInputKey()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a4ffdada1ec0a3e30324e61dfc5a53348)WeaponFlagIconsList
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ItemFlagVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_inventory_1_1_item_flag_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.WeaponFlagIconsList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a3189ce7985db6578b3aa4132b783fd3e)IsInOrderMode
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.IsInOrderMode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a2d609b58ba754ce16d1650c244238e33)CraftedWeaponFinalWorth
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.CraftedWeaponFinalWorth | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a5c736990464f0045bf22ddd7875ba930)CraftedWeaponPriceDifference
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.CraftedWeaponPriceDifference | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#ae67aa8cff3e79975fa455b57e2dc514a)CraftedWeaponInitialWorth
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.CraftedWeaponInitialWorth | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a12867deacdcbab485b07770e49c36fc4)CraftedWeaponWorthText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.CraftedWeaponWorthText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#acc2351cc5fa40ace0c222b8723c30376)IsOrderSuccessful
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.IsOrderSuccessful | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a72f917ea61de23d5f36f746f53594ffb)CanConfirm
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.CanConfirm | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a5f3ca38da57264c262ea0d7ba023e26e)OrderResultText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.OrderResultText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a8ba22ad49eed34316ff718401f88a086)OrderOwnerRemarkText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.OrderOwnerRemarkText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#ad8a61f11fad7211cbd3cac9340eaddc8)WeaponCraftedText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.WeaponCraftedText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#affebe526d6539e4d0cf11f51fa6075f6)DoneLbl
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.DoneLbl | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a0535b0d17213774299be7ca3775363da)DesignResultPropertyList
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[WeaponDesignResultPropertyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_d442000a32ba2387ee48040dfc6db3f19.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.DesignResultPropertyList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a042732f1c2ae404ca1aadd263fb4edb8)ItemName
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.ItemName | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a7c5eb0ae3765568a5dea209ab6510386)ItemVisualModel
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ItemCollectionElementViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_item_collection_element_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.ItemVisualModel | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#ac78299083d8f04d18bf87244dae2abaf)ConfirmDisabledReasonHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.ConfirmDisabledReasonHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a63fe22f15700c1ccd323626b1fc00d81)SecondaryUsageSelector
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[CraftingSecondaryUsageItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_secondary_usage_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.SecondaryUsageSelector | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dd5de87c39cb2a354b54765f041e6207d.html#a1974da67cf42aff29de3dc02667bea72)DoneInputKey
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.WeaponDesignResultPopupVM.DoneInputKey | | getset |

