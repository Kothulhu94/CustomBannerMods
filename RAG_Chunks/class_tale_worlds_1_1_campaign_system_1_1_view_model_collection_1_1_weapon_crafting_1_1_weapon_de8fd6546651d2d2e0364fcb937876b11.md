--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [CraftingOrderItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a98e1423ce55ee2b1273755840947ec0c) ([CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a89b8e981f201686a20e4d52a943ced9d) order, Action< CraftingOrderItemVM > onSelection, Func< [CraftingAvailableHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_available_hero_item_v_m.html) > getCurrentCraftingHero, List< [CraftingStatData](struct_tale_worlds_1_1_core_1_1_crafting_stat_data.html) > orderStatDatas, [CampaignUIHelper.IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_u_i_helper.html#a3852b52bbf0e4b69bec10268df346439) questFlags=[CampaignUIHelper.IssueQuestFlags.None](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_u_i_helper.html#a3852b52bbf0e4b69bec10268df346439a6adf97f83acf6453d4a6a4b1070f3754)) |
| void | [RefreshStats](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#aa72165d230eded933097ff61aa20b9c3) () |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a5113191448b3665031befdd1c186a0f2) () |
|  | Used for updating localized texts. |
| void | [ExecuteSelectOrder](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a98fde45705cf6f15ae94b8e27b1628fa) () |
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
| virtual void | [OnFinalize](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc) () |
| void | [ExecuteCommand](class_tale_worlds_1_1_library_1_1_view_model.html#a857f69ffddc4dc222280b3e2b3c206bb) (string commandName, object[] parameters) |

|  |  |
| --- | --- |
| Properties | |
| CraftingOrder | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a89b8e981f201686a20e4d52a943ced9d) `[get]` |
| bool | [IsEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#aaf1c3ad8ca9abda2ae62e5b7e3933686) `[get, set]` |
| bool | [IsSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#ae9acac904b32175cf71a89f3bb0e53d0) `[get, set]` |
| bool | [HasAvailableHeroes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a8731430c60c26257ce82005ea5a6b006) `[get, set]` |
| bool | [IsDifficultySuitableForHero](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a0d3a84c7a151f3ead3a9ddb02a715d6c) `[get, set]` |
| bool | [IsQuestOrder](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a6c4523ab0d4ffcd215dff344f91d515a) `[get, set]` |
| int | [OrderPrice](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#ab0d6c08d5a4538820be49704c193f41c) `[get, set]` |
| string | [OrderDifficultyLabelText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a325d5603189ba6cc36186821406914bd) `[get, set]` |
| string | [OrderDifficultyValueText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a59990ff4818a7a71817bbcce74b281a5) `[get, set]` |
| string | [OrderNumberText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a984ca5e115c0003a7b62e58b0554efc7) `[get, set]` |
| string | [OrderWeaponType](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a32a94a16f47ebc8ca1233315b6b50645) `[get, set]` |
| string | [OrderWeaponTypeCode](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a6c275081922c534f09242cf7e2b96f35) `[get, set]` |
| [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) | [OrderOwnerData](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a1ae8343c24a084d78b0af4086834cc24) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [DisabledReasonHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a8a9cf5e305b5ed11f4b8ab835c05dd15) `[get, set]` |
| MBBindingList< [QuestMarkerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_marker_v_m.html) > | [Quests](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a120fc704dc15e857908d4dcf8276fc56) `[get, set]` |
| MBBindingList< [WeaponAttributeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_attribute_v_m.html) > | [WeaponAttributes](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#ae0d5e362636aa3e7f93996aa0663da18) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a98e1423ce55ee2b1273755840947ec0c)CraftingOrderItemVM()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.CraftingOrderItemVM | ( | [CraftingOrder](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a89b8e981f201686a20e4d52a943ced9d) | *order*, |
|  |  | Action< CraftingOrderItemVM > | *onSelection*, |
|  |  | Func< [CraftingAvailableHeroItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_crafting_available_hero_item_v_m.html) > | *getCurrentCraftingHero*, |
|  |  | List< [CraftingStatData](struct_tale_worlds_1_1_core_1_1_crafting_stat_data.html) > | *orderStatDatas*, |
|  |  | [CampaignUIHelper.IssueQuestFlags](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_u_i_helper.html#a3852b52bbf0e4b69bec10268df346439) | *questFlags* = [CampaignUIHelper::IssueQuestFlags::None](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_campaign_u_i_helper.html#a3852b52bbf0e4b69bec10268df346439a6adf97f83acf6453d4a6a4b1070f3754) ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#aa72165d230eded933097ff61aa20b9c3)RefreshStats()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.RefreshStats | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a5113191448b3665031befdd1c186a0f2)RefreshValues()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a98fde45705cf6f15ae94b8e27b1628fa)ExecuteSelectOrder()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.ExecuteSelectOrder | ( |  | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a89b8e981f201686a20e4d52a943ced9d)CraftingOrder
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | CraftingOrder TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.CraftingOrder | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#aaf1c3ad8ca9abda2ae62e5b7e3933686)IsEnabled
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.IsEnabled | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#ae9acac904b32175cf71a89f3bb0e53d0)IsSelected
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.IsSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a8731430c60c26257ce82005ea5a6b006)HasAvailableHeroes
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.HasAvailableHeroes | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a0d3a84c7a151f3ead3a9ddb02a715d6c)IsDifficultySuitableForHero
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.IsDifficultySuitableForHero | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a6c4523ab0d4ffcd215dff344f91d515a)IsQuestOrder
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.IsQuestOrder | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#ab0d6c08d5a4538820be49704c193f41c)OrderPrice
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.OrderPrice | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a325d5603189ba6cc36186821406914bd)OrderDifficultyLabelText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.OrderDifficultyLabelText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a59990ff4818a7a71817bbcce74b281a5)OrderDifficultyValueText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.OrderDifficultyValueText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a984ca5e115c0003a7b62e58b0554efc7)OrderNumberText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.OrderNumberText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a32a94a16f47ebc8ca1233315b6b50645)OrderWeaponType
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.OrderWeaponType | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a6c275081922c534f09242cf7e2b96f35)OrderWeaponTypeCode
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.OrderWeaponTypeCode | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a1ae8343c24a084d78b0af4086834cc24)OrderOwnerData
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.OrderOwnerData | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a8a9cf5e305b5ed11f4b8ab835c05dd15)DisabledReasonHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.DisabledReasonHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#a120fc704dc15e857908d4dcf8276fc56)Quests
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[QuestMarkerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_quests_1_1_quest_marker_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.Quests | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_de8fd6546651d2d2e0364fcb937876b11.html#ae0d5e362636aa3e7f93996aa0663da18)WeaponAttributes
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[WeaponAttributeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_weapon_crafting_1_1_weapon_design_1_1_weapon_attribute_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.WeaponCrafting.WeaponDesign.Order.CraftingOrderItemVM.WeaponAttributes | | getset |

