--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

Inherited by [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.EncyclopediaHomeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_encyclopedia_home_v_m.html), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.List.EncyclopediaListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_list_1_1_encyclopedia_list_v_m.html), and [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaContentPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
| virtual string | [GetName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a89872222719c01def061de2224683b0f) () |
| virtual string | [GetNavigationBarURL](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#afd5532720c28b5d4473cfc16acf49be0) () |
| virtual void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a6f83056351eecdb0eb0cff17ec9401f4) () |
|  | [EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#ac5ed41ac12fbfd00a10c6a631a12a1e0) ([EncyclopediaPageArgs](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_args.html) args) |
| virtual void | [OnTick](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#ab5970630dc31e6c1ec1dc406d8dd5fc9) () |
| virtual void | [ExecuteSwitchBookmarkedState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a558d6802a153ec6ee3e2ebc1276d532c) () |
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
| virtual void | [RefreshValues](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd) () |
|  | Used for updating localized texts. |

|  |  |
| --- | --- |
| Protected Member Functions | |
| void | [UpdateBookmarkHintText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a5a2b6379421382a54d3f58e5ba267679) () |
| Protected Member Functions inherited from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html) | |
|  | [ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa7ebef6752dad8cfe2fc8d327365ee17) () |
| bool | [SetField< T >](class_tale_worlds_1_1_library_1_1_view_model.html#a97fe93429d4e1d7ad6e5645f2b542d38) (ref T field, T value, string propertyName) |

|  |  |
| --- | --- |
| Properties | |
| object | [Obj](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a30603b59d0c1b74ec8cd36e0db7892c7) `[get]` |
| bool | [IsLoadingOver](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#ac2a2668a4acfaa960c36e91851814830) `[get, set]` |
| bool | [IsBookmarked](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a4470990997344d7f161845e99f3ebd9a) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [BookmarkHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#ae5cfd871818f19466a6a5526db1ab251) `[get, set]` |
| virtual MBBindingList< [EncyclopediaListItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_list_1_1_encyclopedia_list_item_v_m.html) > | [Items](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#acd7b12066b987898b1538d6ca365c66f) `[get, set]` |
| virtual MBBindingList< [EncyclopediaFilterGroupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_list_1_1_encyclopedia_filter_group_v_m.html) > | [FilterGroups](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#aded4dd8f670fc8d0cde10fa2204a3bd4) `[get, set]` |
| virtual [EncyclopediaListSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_list_1_1_enf365e289fdebd0485798ede4cbfe4492.html) | [SortController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a641dee8b62b50d65e7f3c463f8ed5c10) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#ac5ed41ac12fbfd00a10c6a631a12a1e0)EncyclopediaPageVM()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.EncyclopediaPageVM | ( | [EncyclopediaPageArgs](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_args.html) | *args* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a89872222719c01def061de2224683b0f)GetName()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.GetName | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.EncyclopediaHomeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_encyclopedia_home_v_m.html#a7e940c1eb6bf1a6e328346d1f981ad3e), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.List.EncyclopediaListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_list_1_1_encyclopedia_list_v_m.html#a1f85c490329dfe1bb76839575836e4fc), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaClanPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_clan_page_v_m.html#a9312fae7ba5a0c419204da8484910845), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaConceptPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_concept_page_v_m.html#a4c332e66d8f92bc122fe5ea370464aa0), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a819868976855a8bd55a4768c6226b6c2), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#acb33e1f846e64e2ae223216342040065), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaSettlementPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_settlement_page_v_m.html#a4e169a7842a1fa9eccbf936f27520712), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaShipPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_ship_page_v_m.html#a6cbe113420482a396fd2ba8a3768db32), and [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#ac6e517e02f81987217027579fdf20581).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#afd5532720c28b5d4473cfc16acf49be0)GetNavigationBarURL()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.GetNavigationBarURL | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.EncyclopediaHomeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_encyclopedia_home_v_m.html#a928067d18ba02fcc827f8e21db114481), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.List.EncyclopediaListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_list_1_1_encyclopedia_list_v_m.html#a279b8a985be2505d1fbe08c0fe45c3d2), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaClanPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_clan_page_v_m.html#a47e5816ee4e1773fc1ec4b2157fe1935), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaConceptPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_concept_page_v_m.html#a4816ec0a72cd201f64d784d868bb2d4d), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a8f29ea6260557ef334f46d04d68d9690), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a0fd6fc84397994efc3c7ef6b5f0e5eba), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaSettlementPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_settlement_page_v_m.html#a7a635e6f4aac80d333be03862ee345dc), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaShipPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_ship_page_v_m.html#a6d037421f467a0e39e2460b07814725d), and [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#acb1a571075684b509457cc3536b02d87).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a6f83056351eecdb0eb0cff17ec9401f4)Refresh()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.Refresh | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.EncyclopediaHomeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_encyclopedia_home_v_m.html#a18701d2056099e3552cce41076db08e3), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.List.EncyclopediaListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_list_1_1_encyclopedia_list_v_m.html#a543338799cb16367fbefc8ce9fb82e61), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaClanPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_clan_page_v_m.html#afdde371a1ce8fee7d737917b316eafe4), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaConceptPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_concept_page_v_m.html#a6abde995cf332af58feb080d918c7b00), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a2307d0a64d56a2b80ded62ee7775ae10), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a5ccf65ecb10667fee1b738152c61b614), and [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaSettlementPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_settlement_page_v_m.html#a83c23fe00c98e41a48629a6d5f4f7b21).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#ab5970630dc31e6c1ec1dc406d8dd5fc9)OnTick()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.OnTick | ( |  | ) |  | | virtual |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a558d6802a153ec6ee3e2ebc1276d532c)ExecuteSwitchBookmarkedState()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | virtual void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.ExecuteSwitchBookmarkedState | ( |  | ) |  | | virtual |

Reimplemented in [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaClanPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_clan_page_v_m.html#ac84dd333a6aaa7091dd2dddbe604c075), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaConceptPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_concept_page_v_m.html#a0a6d391134fcf0f754db4eabec33de01), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a573ae90d60f18dc548d96ea9d53d8ce2), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a66cc1393c32774e29563b87b0f51b255), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaSettlementPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_settlement_page_v_m.html#a841fdeea1e01f9193a9aa673a375e332), [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaShipPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_ship_page_v_m.html#accf4ffffc6892671b9b65eb0f911eda7), and [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a6abf9bcd40e6d4b28a200e6368ed2877).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a5a2b6379421382a54d3f58e5ba267679)UpdateBookmarkHintText()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.UpdateBookmarkHintText | ( |  | ) |  | | protected |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a30603b59d0c1b74ec8cd36e0db7892c7)Obj
-------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | object TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.Obj | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#ac2a2668a4acfaa960c36e91851814830)IsLoadingOver
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.IsLoadingOver | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a4470990997344d7f161845e99f3ebd9a)IsBookmarked
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.IsBookmarked | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#ae5cfd871818f19466a6a5526db1ab251)BookmarkHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.BookmarkHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#acd7b12066b987898b1538d6ca365c66f)Items
---------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual MBBindingList<[EncyclopediaListItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_list_1_1_encyclopedia_list_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.Items | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#aded4dd8f670fc8d0cde10fa2204a3bd4)FilterGroups
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual MBBindingList<[EncyclopediaFilterGroupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_list_1_1_encyclopedia_filter_group_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.FilterGroups | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a641dee8b62b50d65e7f3c463f8ed5c10)SortController
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | virtual [EncyclopediaListSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_list_1_1_enf365e289fdebd0485798ede4cbfe4492.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM.SortController | | getset |

