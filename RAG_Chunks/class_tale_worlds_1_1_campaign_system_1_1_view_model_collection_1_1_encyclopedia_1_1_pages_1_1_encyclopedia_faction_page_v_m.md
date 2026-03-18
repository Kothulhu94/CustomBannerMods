--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaContentPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [EncyclopediaFactionPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#aaafcfc898eb19a42da4c89147b3f381b) ([EncyclopediaPageArgs](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_args.html) args) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a54b675cdef606ce4a087becd5584729d) () |
|  | Used for updating localized texts. |
| override void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a2307d0a64d56a2b80ded62ee7775ae10) () |
| override string | [GetName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a819868976855a8bd55a4768c6226b6c2) () |
| override string | [GetNavigationBarURL](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a8f29ea6260557ef334f46d04d68d9690) () |
| override void | [ExecuteSwitchBookmarkedState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a573ae90d60f18dc548d96ea9d53d8ce2) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaContentPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html) | |
|  | [EncyclopediaContentPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#a650209c90c00e431bfc3eceba1bcaf92) ([EncyclopediaPageArgs](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_args.html) args) |
| void | [InitializeQuickNavigation](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#ad69030fea6d875034c3c9d97d5eb5220) ([EncyclopediaListVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_list_1_1_encyclopedia_list_v_m.html) list) |
| void | [ExecuteGoToNextItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#a8059de43b34abd7826425e692a657a24) () |
| void | [ExecuteGoToPreviousItem](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#a71f6e48bbd0eca95bf9bced06665d07f) () |
| Public Member Functions inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html) | |
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
| MBBindingList< [EncyclopediaFactionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_faction_v_m.html) > | [Clans](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a78225568e409ad79a2ec93972ccb3c9d) `[get, set]` |
| MBBindingList< [EncyclopediaFactionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_faction_v_m.html) > | [Enemies](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#aa701eb14c4d8f4bc56468f728b1e187b) `[get, set]` |
| MBBindingList< [EncyclopediaFactionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_faction_v_m.html) > | [TradeAgreements](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a24c74af85f6480742da39a10a1e7d8d2) `[get, set]` |
| MBBindingList< [EncyclopediaFactionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_faction_v_m.html) > | [Alliances](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a586e20ca26046a4f9af353d5be8ced30) `[get, set]` |
| MBBindingList< [EncyclopediaSettlementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_settlement_v_m.html) > | [Settlements](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a78d5e69675852f08b67af8da50ccccbc) `[get, set]` |
| MBBindingList< [EncyclopediaHistoryEventVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_history_event_v_m.html) > | [History](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a660da73d88aa4073135f5b949ab3f185) `[get, set]` |
| [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) | [Leader](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#afa101b0753e20e0846114b3d4ded6ac8) `[get, set]` |
| [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) | [Banner](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a740489ed95f569f73e7b5b1453c2a289) `[get, set]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#aecc78341c90412f0ee9e4e3939855e1c) `[get, set]` |
| string | [MembersText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a1f3bca3bc47af2af745fe645efd1c82c) `[get, set]` |
| string | [EnemiesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#aedad059a946130132d26823aee37696e) `[get, set]` |
| string | [TradeAgreementsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a13ee0a24afedf2ddf93d0c1c2fe95fb2) `[get, set]` |
| string | [AlliancesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a3e3903c0dd93fdbcb98355a64b5911a3) `[get, set]` |
| string | [ClansText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#aac9ab96ee3cc7ddb18b28be41f7aa52b) `[get, set]` |
| string | [SettlementsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a9497f87ffe294149bda92c7173ba3cd9) `[get, set]` |
| string | [VillagesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a439962f15bad5fbf9bb9c7014640f865) `[get, set]` |
| string | [LeaderText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a15f4ec2a300ce4aba2b8030466b49cc9) `[get, set]` |
| string | [DescriptorText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a3f5ff97ccd3493fcf3d443dac41168e1) `[get, set]` |
| string | [InformationText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a6d9441b391d4382c443788898ff63326) `[get, set]` |
| string | [ProsperityText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a6ecbf579bd0e0099c9425d6fe3d8e8bc) `[get, set]` |
| string | [StrengthText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a9b6e30ad6a59d3d3e9dd5b029444a9b6) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ProsperityHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a63ddb38b1845b3fcecb5e7ccf468bff5) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [StrengthHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#aeecce7b4fb97a0b3d79ed8b4ee13454c) `[get, set]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#aaafcfc898eb19a42da4c89147b3f381b)EncyclopediaFactionPageVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.EncyclopediaFactionPageVM | ( | [EncyclopediaPageArgs](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_args.html) | *args* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a54b675cdef606ce4a087becd5584729d)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaContentPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#a3325a10e854806eca734c4af9c3d2dcd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a2307d0a64d56a2b80ded62ee7775ae10)Refresh()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.Refresh | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a6f83056351eecdb0eb0cff17ec9401f4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a819868976855a8bd55a4768c6226b6c2)GetName()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a89872222719c01def061de2224683b0f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a8f29ea6260557ef334f46d04d68d9690)GetNavigationBarURL()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.GetNavigationBarURL | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#afd5532720c28b5d4473cfc16acf49be0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a573ae90d60f18dc548d96ea9d53d8ce2)ExecuteSwitchBookmarkedState()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.ExecuteSwitchBookmarkedState | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a558d6802a153ec6ee3e2ebc1276d532c).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a78225568e409ad79a2ec93972ccb3c9d)Clans
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaFactionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_faction_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.Clans | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#aa701eb14c4d8f4bc56468f728b1e187b)Enemies
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaFactionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_faction_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.Enemies | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a24c74af85f6480742da39a10a1e7d8d2)TradeAgreements
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaFactionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_faction_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.TradeAgreements | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a586e20ca26046a4f9af353d5be8ced30)Alliances
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaFactionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_faction_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.Alliances | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a78d5e69675852f08b67af8da50ccccbc)Settlements
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaSettlementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_settlement_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.Settlements | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a660da73d88aa4073135f5b949ab3f185)History
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaHistoryEventVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_history_event_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.History | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#afa101b0753e20e0846114b3d4ded6ac8)Leader
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.Leader | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a740489ed95f569f73e7b5b1453c2a289)Banner
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BannerImageIdentifierVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_image_identifiers_1_1_banner_image_identifier_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.Banner | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#aecc78341c90412f0ee9e4e3939855e1c)NameText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a1f3bca3bc47af2af745fe645efd1c82c)MembersText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.MembersText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#aedad059a946130132d26823aee37696e)EnemiesText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.EnemiesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a13ee0a24afedf2ddf93d0c1c2fe95fb2)TradeAgreementsText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.TradeAgreementsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a3e3903c0dd93fdbcb98355a64b5911a3)AlliancesText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.AlliancesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#aac9ab96ee3cc7ddb18b28be41f7aa52b)ClansText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.ClansText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a9497f87ffe294149bda92c7173ba3cd9)SettlementsText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.SettlementsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a439962f15bad5fbf9bb9c7014640f865)VillagesText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.VillagesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a15f4ec2a300ce4aba2b8030466b49cc9)LeaderText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.LeaderText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a3f5ff97ccd3493fcf3d443dac41168e1)DescriptorText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.DescriptorText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a6d9441b391d4382c443788898ff63326)InformationText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.InformationText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a6ecbf579bd0e0099c9425d6fe3d8e8bc)ProsperityText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.ProsperityText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a9b6e30ad6a59d3d3e9dd5b029444a9b6)StrengthText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.StrengthText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#a63ddb38b1845b3fcecb5e7ccf468bff5)ProsperityHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.ProsperityHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_faction_page_v_m.html#aeecce7b4fb97a0b3d79ed8b4ee13454c)StrengthHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaFactionPageVM.StrengthHint | | getset |

