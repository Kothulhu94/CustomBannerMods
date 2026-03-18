--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CraftingHistoryVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#ac351cdbdd4545fb48710e5b85546e88a) ([Crafting](class_tale_worlds_1_1_core_1_1_crafting.html) crafting, [ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html) craftingBehavior, Func< [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) > getActiveOrder, Action< [WeaponDesignSelectorVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dccf2683e8d7e6971989a95489ed2b927.html) > onDone) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a2100c35c522a8b8aaa44187273c6df93) () |
|  | Used for updating localized texts. |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a8a47288affe29274463a54144ecefdb8) () |
| void | [RefreshAvailability](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a09e8496035f07f90e86d532dde123bcd) () |
| void | [ExecuteOpen](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a22503e576077ee27921808cfae1515c5) () |
| void | [ExecuteCancel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#adb0a0000c596e6ed36555cde0cd5dcd8) () |
| void | [ExecuteDone](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a18f4f1bcb2656b0b35fa45f30eecf096) () |
| void | [SetDoneKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a4eeb969dec0c1365e306335cb316b392) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
| void | [SetCancelKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#af5b848f83616b843c4cd71db670ac763) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotkey) |
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
| bool | [IsDoneAvailable](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#af22d0eb34c14809b7a6cb2e0d11155b0) `[get, set]` |
| bool | [IsVisible](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a8bdf5931f769a36aa6ca96bb7679e62c) `[get, set]` |
| bool | [HasItemsInHistory](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#ae14222037f173dedac24a4a7e3e81d20) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [HistoryHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a72e47286a317d0be38d51844c9ab664c) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [HistoryDisabledHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a206db82cb21d4b477b6b20dc978ce7f0) `[get, set]` |
| MBBindingList< [WeaponDesignSelectorVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dccf2683e8d7e6971989a95489ed2b927.html) > | [CraftingHistory](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#afa20a4a949bfe44d7f30f96dec085371) `[get, set]` |
| [WeaponDesignSelectorVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dccf2683e8d7e6971989a95489ed2b927.html) | [SelectedDesign](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#ac528d9663de84c9c0cf1ac37a4bbe5d3) `[get, set]` |
| string | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#ae69d10b0ca2471a992ba334a8da4c55c) `[get, set]` |
| string | [DoneText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a8658376b9dccce90eacfc9c902bde6b0) `[get, set]` |
| string | [CancelText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#ae19031b64537995c65439d5ff4fc6f63) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#ad0f264749dbc63971d5b0b89ac907e3b) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a12295b9f0adf7e70069c194b9ad633d9) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#ac351cdbdd4545fb48710e5b85546e88a)CraftingHistoryVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.CraftingHistoryVM | ( | [Crafting](class_tale_worlds_1_1_core_1_1_crafting.html) | *crafting*, |
|  |  | [ICraftingCampaignBehavior](interface_tale_worlds_1_1_campaign_system_1_1_campaign_behaviors_1_1_i_crafting_campaign_behavior.html) | *craftingBehavior*, |
|  |  | Func< [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_crafting_system_1_1_crafting_order.html) > | *getActiveOrder*, |
|  |  | Action< [WeaponDesignSelectorVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dccf2683e8d7e6971989a95489ed2b927.html) > | *onDone* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a2100c35c522a8b8aaa44187273c6df93)RefreshValues()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a8a47288affe29274463a54144ecefdb8)OnFinalize()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a09e8496035f07f90e86d532dde123bcd)RefreshAvailability()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.RefreshAvailability | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a22503e576077ee27921808cfae1515c5)ExecuteOpen()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.ExecuteOpen | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#adb0a0000c596e6ed36555cde0cd5dcd8)ExecuteCancel()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.ExecuteCancel | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a18f4f1bcb2656b0b35fa45f30eecf096)ExecuteDone()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.ExecuteDone | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a4eeb969dec0c1365e306335cb316b392)SetDoneKey()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.SetDoneKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#af5b848f83616b843c4cd71db670ac763)SetCancelKey()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.SetCancelKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotkey* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#af22d0eb34c14809b7a6cb2e0d11155b0)IsDoneAvailable
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.IsDoneAvailable | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a8bdf5931f769a36aa6ca96bb7679e62c)IsVisible
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.IsVisible | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#ae14222037f173dedac24a4a7e3e81d20)HasItemsInHistory
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.HasItemsInHistory | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a72e47286a317d0be38d51844c9ab664c)HistoryHint
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.HistoryHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a206db82cb21d4b477b6b20dc978ce7f0)HistoryDisabledHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.HistoryDisabledHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#afa20a4a949bfe44d7f30f96dec085371)CraftingHistory
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[WeaponDesignSelectorVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dccf2683e8d7e6971989a95489ed2b927.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.CraftingHistory | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#ac528d9663de84c9c0cf1ac37a4bbe5d3)SelectedDesign
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [WeaponDesignSelectorVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_dccf2683e8d7e6971989a95489ed2b927.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.SelectedDesign | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#ae69d10b0ca2471a992ba334a8da4c55c)TitleText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.TitleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a8658376b9dccce90eacfc9c902bde6b0)DoneText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.DoneText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#ae19031b64537995c65439d5ff4fc6f63)CancelText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.CancelText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#ad0f264749dbc63971d5b0b89ac907e3b)CancelKey
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.CancelKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_crafting_history_v_m.html#a12295b9f0adf7e70069c194b9ad633d9)DoneKey
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.CraftingHistoryVM.DoneKey | | getset |

