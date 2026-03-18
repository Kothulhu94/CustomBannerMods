--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [ClanMembersVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a7ffda5e3611ee7c66105c87911ed4794) (Action onRefresh, Action< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > showHeroOnMap) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a16fc5fca68500248ee2129e0303ab253) () |
|  | Used for updating localized texts. |
| void | [RefreshMembersList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#aae2c8c780721e07d1c97308371ad2ada) () |
| void | [SelectMember](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a214eb0363f3c72b21127a0451249d7de) ([Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) hero) |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a4506734569ff7d1ac226f48af84fdc1a) () |
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
| bool | [IsAnyValidMemberSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#ac3f07b5674ba465cf64115151e48c3d0) `[get, set]` |
| bool | [IsSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#ab0f9c949fa40c6f6726cc4c23f5c063b) `[get, set]` |
| string | [FamilyText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a99f94a00aa02c80014a78f4d396436c9) `[get, set]` |
| string | [TraitsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a8893347ef6efb7b16398b1f2bf9adfc4) `[get, set]` |
| string | [SkillsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#abf9e4fed7d35d39984c6ea912120d3ff) `[get, set]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a5696ae7c34e37b57356409c62bc2d54d) `[get, set]` |
| string | [LocationText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a0d8c6abd21e46e5f34375f8023c9979c) `[get, set]` |
| string | [CompanionsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a6bcd90c90361d010d0f98564ea1e62df) `[get, set]` |
| MBBindingList< [ClanLordItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html) > | [Companions](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a90addf3dd66f9db6f8bde762f72f1dad) `[get, set]` |
| MBBindingList< [ClanLordItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html) > | [Family](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a582a997d5259905e799d48082cb3ee20) `[get, set]` |
| [ClanLordItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html) | [CurrentSelectedMember](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#ab97c494872783b3df555a535181e0377) `[get, set]` |
| [ClanMembersSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categorie61ddd5e0a40bb6a28423c150252a65c.html) | [SortController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a0e4db605105f937e0e2d73d7c7ec025d) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a7ffda5e3611ee7c66105c87911ed4794)ClanMembersVM()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |
| --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.ClanMembersVM | ( | Action | *onRefresh*, |
|  |  | Action< [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) > | *showHeroOnMap* ) |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a16fc5fca68500248ee2129e0303ab253)RefreshValues()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#aae2c8c780721e07d1c97308371ad2ada)RefreshMembersList()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.RefreshMembersList | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a214eb0363f3c72b21127a0451249d7de)SelectMember()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.SelectMember | ( | [Hero](class_tale_worlds_1_1_campaign_system_1_1_hero.html) | *hero* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a4506734569ff7d1ac226f48af84fdc1a)OnFinalize()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#ac3f07b5674ba465cf64115151e48c3d0)IsAnyValidMemberSelected
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.IsAnyValidMemberSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#ab0f9c949fa40c6f6726cc4c23f5c063b)IsSelected
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.IsSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a99f94a00aa02c80014a78f4d396436c9)FamilyText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.FamilyText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a8893347ef6efb7b16398b1f2bf9adfc4)TraitsText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.TraitsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#abf9e4fed7d35d39984c6ea912120d3ff)SkillsText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.SkillsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a5696ae7c34e37b57356409c62bc2d54d)NameText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a0d8c6abd21e46e5f34375f8023c9979c)LocationText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.LocationText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a6bcd90c90361d010d0f98564ea1e62df)CompanionsText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.CompanionsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a90addf3dd66f9db6f8bde762f72f1dad)Companions
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ClanLordItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.Companions | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a582a997d5259905e799d48082cb3ee20)Family
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[ClanLordItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.Family | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#ab97c494872783b3df555a535181e0377)CurrentSelectedMember
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ClanLordItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_clan_lord_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.CurrentSelectedMember | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categories_1_1_clan_members_v_m.html#a0e4db605105f937e0e2d73d7c7ec025d)SortController
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [ClanMembersSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_clan_management_1_1_categorie61ddd5e0a40bb6a28423c150252a65c.html) TaleWorlds.CampaignSystem.ViewModelCollection.ClanManagement.Categories.ClanMembersVM.SortController | | getset |

