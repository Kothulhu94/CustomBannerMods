--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaContentPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [EncyclopediaHeroPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#af171bfd97d2f6bb7e30d12080952910f) ([EncyclopediaPageArgs](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_args.html) args) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a2b06b2b2c7025116dce3ed465760cdd5) () |
|  | Used for updating localized texts. |
| override void | [Refresh](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a5ccf65ecb10667fee1b738152c61b614) () |
| override string | [GetName](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#acb33e1f846e64e2ae223216342040065) () |
| override string | [GetNavigationBarURL](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a0fd6fc84397994efc3c7ef6b5f0e5eba) () |
| void | [ExecuteLink](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a750a112096eb28ddb9b45799ea2a023b) (string link) |
| override void | [ExecuteSwitchBookmarkedState](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a66cc1393c32774e29563b87b0f51b255) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a8b4a907ac1f2c7a30c2cbb3d809a1fa9) () |
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
| void | [ExecuteCommand](class_tale_worlds_1_1_library_1_1_view_model.html#a857f69ffddc4dc222280b3e2b3c206bb) (string commandName, object[] parameters) |

|  |  |
| --- | --- |
| Properties | |
| [EncyclopediaFactionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_faction_v_m.html) | [Faction](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a1bedf71b1df0b347d9c6c13cf270e62a) `[get, set]` |
| bool | [IsCompanion](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a51e02057454c0ff7c9290e23b1e12dc6) `[get, set]` |
| bool | [IsPregnant](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#af2cc525da5d3f0e915ae4faea4c562c9) `[get, set]` |
| [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) | [Master](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#ab8cd2fe484f67c1ca67c9641d83367d0) `[get, set]` |
| string | [ClanText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#addaaaf75da1995e6bc3e9bc29893bffa) `[get, set]` |
| string | [InfoText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a5e5288be18172e1c3b5d673179273314) `[get, set]` |
| string | [TraitsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#ac39b155ed871f89c9bf2ca5271ebe85c) `[get, set]` |
| string | [MasterText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#aaeb0d94e4db6fb092aa37c899f822876) `[get, set]` |
| string | [KingdomRankText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a6fb8bf3d5f78d445faebe86676b028f6) `[get, set]` |
| string | [InfoHiddenReasonText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a20989993a0734e6806fb803796a3889c) `[get]` |
| string | [SkillsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a0ca5fca080abcd105df4329582ea7d60) `[get, set]` |
| [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) | [HeroCharacter](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#acbca5c805949b598983828852695a58e) `[get, set]` |
| string | [LastSeenText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#ac590c2643770929b2142ec04ec4826ff) `[get, set]` |
| string | [DeceasedText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a393446476b383d8dce17879ce4479e8b) `[get, set]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#af9b91b316f44845af4aa74580ebd0c2f) `[get, set]` |
| string | [SettlementsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a5e3a90744f339f9d5fce23e3d26ea4ce) `[get, set]` |
| string | [DwellingsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a4723ee1352eb3d8c699a629ab43e0d76) `[get, set]` |
| string | [CompanionsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a5af81069c158df45643774b8c73cd538) `[get, set]` |
| string | [AlliesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#aea4b6aca3418625109776a2a957250bd) `[get, set]` |
| string | [EnemiesText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a889ba6ce330655c37dd19488f013daed) `[get, set]` |
| string | [FamilyText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a4de86e7d52844509c071da8b316ad39a) `[get, set]` |
| MBBindingList< [StringPairItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_pair_item_v_m.html) > | [Stats](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a25f9c450a2573a78516c8242844c7d37) `[get, set]` |
| MBBindingList< [EncyclopediaTraitItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_trait_item_v_m.html) > | [Traits](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a475289f545c6f95cf93ad4da92ed3a1d) `[get, set]` |
| MBBindingList< [EncyclopediaSkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_skill_v_m.html) > | [Skills](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a9e7bb70f647a5e192892325d4865063a) `[get, set]` |
| MBBindingList< [EncyclopediaDwellingVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_dwelling_v_m.html) > | [Dwellings](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a41b958fdfaf294670f8f327546dafadf) `[get, set]` |
| MBBindingList< [EncyclopediaSettlementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_settlement_v_m.html) > | [Settlements](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#aa14a6d1b167396128ee984a4ca99a8e2) `[get, set]` |
| MBBindingList< [EncyclopediaFamilyMemberVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_family_member_v_m.html) > | [Family](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a671afe6ceb6f77182ad0d380c24e9f18) `[get, set]` |
| MBBindingList< [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) > | [Companions](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#af2c4842c5523c57e971b134c633cb047) `[get, set]` |
| MBBindingList< [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) > | [Enemies](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a0e142c8e4dc17e298fd075d2cb991b85) `[get, set]` |
| MBBindingList< [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) > | [Allies](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a59f584ecbe9b1edee5d52a47bad1848b) `[get, set]` |
| MBBindingList< [EncyclopediaHistoryEventVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_history_event_v_m.html) > | [History](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a871088cc0e60821ea7cfabdf994cc9d2) `[get, set]` |
| bool | [HasNeutralClan](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a6cd765265ab9ee187c40462a5bd994c7) `[get, set]` |
| bool | [IsDead](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a97cbf3fb5169d321f8af0fe7cb1bfe1a) `[get, set]` |
| bool | [IsInformationHidden](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a0f3d17329b4e198051052013fb3f1e2c) `[get, set]` |
| string | [InformationText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a9ee99b5b061431b274cce781c1f98fdb) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [PregnantHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a8cd6e658031afa09873ee8ed886a05cb) `[get, set]` |
| bool | [HasAnySkills](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a00566a7a64ef169d10e6b7e1e66d1157) `[get, set]` |
| MBBindingList< [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) > | [AdditionalEnemies](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#abdf85ab392d7d18fd3b6390933e7c082) `[get, set]` |
| MBBindingList< [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) > | [AdditionalAllies](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a2657560925c21c45ff26eb7e25da8ced) `[get, set]` |
| bool | [AnyAdditionalAllies](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a32ab9fa5ce0c3c5e6622b60e13686b0e) `[get, set]` |
| bool | [AnyAdditionalEnemies](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#acc06ea444e3c20631ddd28fd7f16e195) `[get, set]` |
| string | [AdditionalAlliesString](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a7e54484c4c68967438aa8e5fb65bad70) `[get, set]` |
| string | [AdditionalEnemiesString](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a39d250b989d26e81a67bef7aff2074f9) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [AdditionalAlliesHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a2d99bff9d0242fb062c4f500a7446669) `[get, set]` |
| [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) | [AdditionalEnemiesHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a43ad8ef240691c8a302eebd4e155455c) `[get, set]` |
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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#af171bfd97d2f6bb7e30d12080952910f)EncyclopediaHeroPageVM()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.EncyclopediaHeroPageVM | ( | [EncyclopediaPageArgs](struct_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_args.html) | *args* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a2b06b2b2c7025116dce3ed465760cdd5)RefreshValues()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaContentPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_content_page_v_m.html#a3325a10e854806eca734c4af9c3d2dcd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a5ccf65ecb10667fee1b738152c61b614)Refresh()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.Refresh | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a6f83056351eecdb0eb0cff17ec9401f4).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#acb33e1f846e64e2ae223216342040065)GetName()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.GetName | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a89872222719c01def061de2224683b0f).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a0fd6fc84397994efc3c7ef6b5f0e5eba)GetNavigationBarURL()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.GetNavigationBarURL | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#afd5532720c28b5d4473cfc16acf49be0).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a750a112096eb28ddb9b45799ea2a023b)ExecuteLink()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.ExecuteLink | ( | string | *link* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a66cc1393c32774e29563b87b0f51b255)ExecuteSwitchBookmarkedState()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.ExecuteSwitchBookmarkedState | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaPageVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_page_v_m.html#a558d6802a153ec6ee3e2ebc1276d532c).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a8b4a907ac1f2c7a30c2cbb3d809a1fa9)OnFinalize()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a1bedf71b1df0b347d9c6c13cf270e62a)Faction
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [EncyclopediaFactionVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_faction_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.Faction | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a51e02057454c0ff7c9290e23b1e12dc6)IsCompanion
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.IsCompanion | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#af2cc525da5d3f0e915ae4faea4c562c9)IsPregnant
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.IsPregnant | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#ab8cd2fe484f67c1ca67c9641d83367d0)Master
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.Master | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#addaaaf75da1995e6bc3e9bc29893bffa)ClanText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.ClanText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a5e5288be18172e1c3b5d673179273314)InfoText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.InfoText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#ac39b155ed871f89c9bf2ca5271ebe85c)TraitsText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.TraitsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#aaeb0d94e4db6fb092aa37c899f822876)MasterText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.MasterText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a6fb8bf3d5f78d445faebe86676b028f6)KingdomRankText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.KingdomRankText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a20989993a0734e6806fb803796a3889c)InfoHiddenReasonText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.InfoHiddenReasonText | | get |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a0ca5fca080abcd105df4329582ea7d60)SkillsText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.SkillsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#acbca5c805949b598983828852695a58e)HeroCharacter
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HeroViewModel](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.HeroCharacter | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#ac590c2643770929b2142ec04ec4826ff)LastSeenText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.LastSeenText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a393446476b383d8dce17879ce4479e8b)DeceasedText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.DeceasedText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#af9b91b316f44845af4aa74580ebd0c2f)NameText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a5e3a90744f339f9d5fce23e3d26ea4ce)SettlementsText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.SettlementsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a4723ee1352eb3d8c699a629ab43e0d76)DwellingsText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.DwellingsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a5af81069c158df45643774b8c73cd538)CompanionsText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.CompanionsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#aea4b6aca3418625109776a2a957250bd)AlliesText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.AlliesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a889ba6ce330655c37dd19488f013daed)EnemiesText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.EnemiesText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a4de86e7d52844509c071da8b316ad39a)FamilyText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.FamilyText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a25f9c450a2573a78516c8242844c7d37)Stats
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[StringPairItemVM](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_generic_1_1_string_pair_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.Stats | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a475289f545c6f95cf93ad4da92ed3a1d)Traits
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaTraitItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_trait_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.Traits | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a9e7bb70f647a5e192892325d4865063a)Skills
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaSkillVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_skill_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.Skills | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a41b958fdfaf294670f8f327546dafadf)Dwellings
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaDwellingVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_dwelling_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.Dwellings | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#aa14a6d1b167396128ee984a4ca99a8e2)Settlements
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaSettlementVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_settlement_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.Settlements | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a671afe6ceb6f77182ad0d380c24e9f18)Family
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaFamilyMemberVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_family_member_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.Family | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#af2c4842c5523c57e971b134c633cb047)Companions
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.Companions | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a0e142c8e4dc17e298fd075d2cb991b85)Enemies
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.Enemies | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a59f584ecbe9b1edee5d52a47bad1848b)Allies
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.Allies | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a871088cc0e60821ea7cfabdf994cc9d2)History
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[EncyclopediaHistoryEventVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_items_1_1_encyclopedia_history_event_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.History | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a6cd765265ab9ee187c40462a5bd994c7)HasNeutralClan
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.HasNeutralClan | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a97cbf3fb5169d321f8af0fe7cb1bfe1a)IsDead
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.IsDead | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a0f3d17329b4e198051052013fb3f1e2c)IsInformationHidden
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.IsInformationHidden | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a9ee99b5b061431b274cce781c1f98fdb)InformationText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.InformationText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a8cd6e658031afa09873ee8ed886a05cb)PregnantHint
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.PregnantHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a00566a7a64ef169d10e6b7e1e66d1157)HasAnySkills
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.HasAnySkills | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#abdf85ab392d7d18fd3b6390933e7c082)AdditionalEnemies
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.AdditionalEnemies | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a2657560925c21c45ff26eb7e25da8ced)AdditionalAllies
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[HeroVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_hero_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.AdditionalAllies | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a32ab9fa5ce0c3c5e6622b60e13686b0e)AnyAdditionalAllies
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.AnyAdditionalAllies | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#acc06ea444e3c20631ddd28fd7f16e195)AnyAdditionalEnemies
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.AnyAdditionalEnemies | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a7e54484c4c68967438aa8e5fb65bad70)AdditionalAlliesString
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.AdditionalAlliesString | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a39d250b989d26e81a67bef7aff2074f9)AdditionalEnemiesString
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.AdditionalEnemiesString | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a2d99bff9d0242fb062c4f500a7446669)AdditionalAlliesHint
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.AdditionalAlliesHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_encyclopedia_1_1_pages_1_1_encyclopedia_hero_page_v_m.html#a43ad8ef240691c8a302eebd4e155455c)AdditionalEnemiesHint
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [BasicTooltipViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_basic_tooltip_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.Encyclopedia.Pages.EncyclopediaHeroPageVM.AdditionalEnemiesHint | | getset |

