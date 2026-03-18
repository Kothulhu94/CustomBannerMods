--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaContentPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [EncyclopediaUnitPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#ab7588748c49251d0f66df1503e11349d) ([EncyclopediaPageArgs](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_args.html) args) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a46b3656680dbfadffa2289305bd90da7) () |
|  | Used for updating localized texts. |
| override string | [GetName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#ac6e517e02f81987217027579fdf20581) () |
| override string | [GetNavigationBarURL](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#acb1a571075684b509457cc3536b02d87) () |
| override void | [ExecuteSwitchBookmarkedState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a6abf9bcd40e6d4b28a200e6368ed2877) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaContentPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html) | |
|  | [EncyclopediaContentPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#a650209c90c00e431bfc3eceba1bcaf92) ([EncyclopediaPageArgs](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_args.html) args) |
| void | [InitializeQuickNavigation](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#ad69030fea6d875034c3c9d97d5eb5220) ([EncyclopediaListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_list_1_1_encyclopedia_list_v_m.html) list) |
| void | [ExecuteGoToNextItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#a8059de43b34abd7826425e692a657a24) () |
| void | [ExecuteGoToPreviousItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#a71f6e48bbd0eca95bf9bced06665d07f) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html) | |
| virtual void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a6f83056351eecdb0eb0cff17ec9401f4) () |
|  | [EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#ac5ed41ac12fbfd00a10c6a631a12a1e0) ([EncyclopediaPageArgs](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_args.html) args) |
| virtual void | [OnTick](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#ab5970630dc31e6c1ec1dc406d8dd5fc9) () |
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
| MBBindingList< [EncyclopediaSkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_skill_v_m.html) > | [Skills](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a7ad8789cb47a73c013c7371e3dca1e91) `[get, set]` |
| MBBindingList< [StringItemWithHintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_item_with_hint_v_m.html) > | [PropertiesList](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a64340022cfbf17a8b9484cecbcdcdda8) `[get, set]` |
| SelectorVM< [EncyclopediaUnitEquipmentSetSelectorItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_e0abea598f98f4eeacb7fdf99689d9fae.html) > | [EquipmentSetSelector](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a9a920e268208f989aaa1ccee1759bae7) `[get, set]` |
| [EncyclopediaUnitEquipmentSetSelectorItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_e0abea598f98f4eeacb7fdf99689d9fae.html) | [CurrentSelectedEquipmentSet](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a8bef83ebab180052e0a7dee8e7338c45) `[get, set]` |
| [CharacterViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html) | [UnitCharacter](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a63ffdd019d86ecbf01077e07c26a2232) `[get, set]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a7d70be319d1bd60f5b4a27297f3a9c81) `[get, set]` |
| string | [DescriptionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a8dda78c838c1404a9acab7aa565409f1) `[get, set]` |
| [EncyclopediaTroopTreeNodeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_troop_tree_node_v_m.html) | [Tree](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a0301d9c9600c36edc87f996234953d35) `[get, set]` |
| string | [TreeDisplayErrorText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#ad51347b3aa55e393ba5765897667ecf4) `[get, set]` |
| string | [EquipmentSetText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a796b3b2cabb22aa51317ad9da7b64072) `[get, set]` |
| bool | [HasErrors](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#adb09bed0e7c1ef93dd00f7d95dc4e5d6) `[get, set]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaContentPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html) | |
| bool | [IsPreviousButtonEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#a9d461147a626ae37adb9f10335d91b7c) `[get, set]` |
| bool | [IsNextButtonEnabled](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#ac1a581ad20b6a78a38816a141b4fe7aa) `[get, set]` |
| string | [PreviousButtonLabel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#adab16b8eef9d5e9ccd815b9ea3831070) `[get, set]` |
| string | [NextButtonLabel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#a1f8c054b2e5863a46d281a92ee89b565) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [PreviousButtonHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#aeb419021c2fa1329d1529546f56bfa40) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [NextButtonHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#a54357195bef2de686c882fe38bb45514) `[get, set]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html) | |
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
| Protected Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html) | |
| void | [UpdateBookmarkHintText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a5a2b6379421382a54d3f58e5ba267679) () |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#ab7588748c49251d0f66df1503e11349d)EncyclopediaUnitPageVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.EncyclopediaUnitPageVM | ( | [EncyclopediaPageArgs](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_args.html) | *args* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a46b3656680dbfadffa2289305bd90da7)RefreshValues()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaContentPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#a3325a10e854806eca734c4af9c3d2dcd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#ac6e517e02f81987217027579fdf20581)GetName()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a89872222719c01def061de2224683b0f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#acb1a571075684b509457cc3536b02d87)GetNavigationBarURL()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.GetNavigationBarURL | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#afd5532720c28b5d4473cfc16acf49be0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a6abf9bcd40e6d4b28a200e6368ed2877)ExecuteSwitchBookmarkedState()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.ExecuteSwitchBookmarkedState | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a558d6802a153ec6ee3e2ebc1276d532c).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a7ad8789cb47a73c013c7371e3dca1e91)Skills
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaSkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_skill_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.Skills | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a64340022cfbf17a8b9484cecbcdcdda8)PropertiesList
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[StringItemWithHintVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_item_with_hint_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.PropertiesList | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a9a920e268208f989aaa1ccee1759bae7)EquipmentSetSelector
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | SelectorVM<[EncyclopediaUnitEquipmentSetSelectorItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_e0abea598f98f4eeacb7fdf99689d9fae.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.EquipmentSetSelector | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a8bef83ebab180052e0a7dee8e7338c45)CurrentSelectedEquipmentSet
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EncyclopediaUnitEquipmentSetSelectorItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_e0abea598f98f4eeacb7fdf99689d9fae.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.CurrentSelectedEquipmentSet | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a63ffdd019d86ecbf01077e07c26a2232)UnitCharacter
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [CharacterViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_character_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.UnitCharacter | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a7d70be319d1bd60f5b4a27297f3a9c81)NameText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a8dda78c838c1404a9acab7aa565409f1)DescriptionText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.DescriptionText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a0301d9c9600c36edc87f996234953d35)Tree
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EncyclopediaTroopTreeNodeVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_troop_tree_node_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.Tree | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#ad51347b3aa55e393ba5765897667ecf4)TreeDisplayErrorText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.TreeDisplayErrorText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#a796b3b2cabb22aa51317ad9da7b64072)EquipmentSetText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.EquipmentSetText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_unit_page_v_m.html#adb09bed0e7c1ef93dd00f7d95dc4e5d6)HasErrors
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaUnitPageVM.HasErrors | | getset |

