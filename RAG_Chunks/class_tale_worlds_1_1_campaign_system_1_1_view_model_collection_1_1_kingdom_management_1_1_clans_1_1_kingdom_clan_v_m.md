--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM Class ReferenceInherits [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomCategoryVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [KingdomClanVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a5f99e83f89e798867e4bd66e5a27807c) (Action< [Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) > forceDecide) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a042cc98288db695f59eb6179c9ae3807) () |
|  | Used for updating localized texts. |
| void | [RefreshClan](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a1ad93cfdadd9bbe181ce9712dabe3c9b) () |
| void | [SelectClan](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a73d0b5e445d382e1afd16330f2510592) ([Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) clan) |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a050bcc37dc4aaebffb1840303b165323) () |
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
| [KingdomClanSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans660d8637592afa41fef839649dc05117.html) | [ClanSortController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a52010e92ee74f11cc3012d84b0b2dc9e) `[get, set]` |
| [KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) | [CurrentSelectedClan](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a8f2608107ca7c09acb7a9259cad45b0e) `[get, set]` |
| string | [ExpelActionExplanationText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#ac64169e9df793a4714b3d2074e3dcc1c) `[get, set]` |
| string | [SupportActionExplanationText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#aefc6239eb8b952af48fb8ce6a4fea51a) `[get, set]` |
| string | [BannerText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#aa18d7c7ccaf9c87918fa43c908f9a016) `[get, set]` |
| string | [TypeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a9b3d3049a4d48d2ad208edd92904aa3f) `[get, set]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a7a9904cb98befdf0aa5bee89977ff9e9) `[get, set]` |
| string | [InfluenceText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#ab95224862a6c6abaff627fc5df363631) `[get, set]` |
| string | [FiefsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a02a7ec288c19c0e7c883b901c01c29b1) `[get, set]` |
| string | [MembersText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a1fdd0c6af23ef30143926956b77af8f1) `[get, set]` |
| MBBindingList< [KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) > | [Clans](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#ad0c349cdd098eb357ce514a3a19f877f) `[get, set]` |
| bool | [CanSupportCurrentClan](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a5027cdd408cc75754fdb17e597f63890) `[get, set]` |
| bool | [CanExpelCurrentClan](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#ae6b0cc20739c66093ad6013de9ff8307) `[get, set]` |
| string | [SupportText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a334625ca61df79310d41dd01216810eb) `[get, set]` |
| string | [ExpelActionText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a63e1acd6423c5195495866e96e8a1cd6) `[get, set]` |
| int | [SupportCost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a6ce81ba42ef7fef0be4c0df7b7b0af31) `[get, set]` |
| int | [ExpelCost](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#acdd3c3dd347150f507a5da58c7f811fb) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [ExpelHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a7038805900c9136e5d2b5ceddc5b621b) `[get, set]` |
| [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) | [SupportHint](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#aed75f0c2ca25268bd730465e20e742e3) `[get, set]` |
| Properties inherited from [TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomCategoryVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html) | |
| string | [CategoryNameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html#a39ebbe6e4aa358f72380bc6242b66ee7) `[get, set]` |
| string | [NoItemSelectedText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html#a07caab2d24921773e2671b0b62ff05e7) `[get, set]` |
| bool | [IsAcceptableItemSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html#ad356c7c5dde14c373e0f9a7496841aed) `[get, set]` |
| int | [NotificationCount](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html#acbb69f1cce2a1eda032628ac2a09cd18) `[get, set]` |
| bool | [Show](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_category_v_m.html#a88680ce85dd8c95901bed6bf9c6877f8) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a5f99e83f89e798867e4bd66e5a27807c)KingdomClanVM()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.KingdomClanVM | ( | Action< [Election.KingdomDecision](class_tale_worlds_1_1_campaign_system_1_1_election_1_1_kingdom_decision.html) > | *forceDecide* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a042cc98288db695f59eb6179c9ae3807)RefreshValues()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a1ad93cfdadd9bbe181ce9712dabe3c9b)RefreshClan()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.RefreshClan | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a73d0b5e445d382e1afd16330f2510592)SelectClan()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.SelectClan | ( | [Clan](class_tale_worlds_1_1_campaign_system_1_1_clan.html) | *clan* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a050bcc37dc4aaebffb1840303b165323)OnFinalize()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a52010e92ee74f11cc3012d84b0b2dc9e)ClanSortController
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [KingdomClanSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans660d8637592afa41fef839649dc05117.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.ClanSortController | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a8f2608107ca7c09acb7a9259cad45b0e)CurrentSelectedClan
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.CurrentSelectedClan | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#ac64169e9df793a4714b3d2074e3dcc1c)ExpelActionExplanationText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.ExpelActionExplanationText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#aefc6239eb8b952af48fb8ce6a4fea51a)SupportActionExplanationText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.SupportActionExplanationText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#aa18d7c7ccaf9c87918fa43c908f9a016)BannerText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.BannerText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a9b3d3049a4d48d2ad208edd92904aa3f)TypeText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.TypeText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a7a9904cb98befdf0aa5bee89977ff9e9)NameText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#ab95224862a6c6abaff627fc5df363631)InfluenceText
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.InfluenceText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a02a7ec288c19c0e7c883b901c01c29b1)FiefsText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.FiefsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a1fdd0c6af23ef30143926956b77af8f1)MembersText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.MembersText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#ad0c349cdd098eb357ce514a3a19f877f)Clans
----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.Clans | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a5027cdd408cc75754fdb17e597f63890)CanSupportCurrentClan
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.CanSupportCurrentClan | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#ae6b0cc20739c66093ad6013de9ff8307)CanExpelCurrentClan
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.CanExpelCurrentClan | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a334625ca61df79310d41dd01216810eb)SupportText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.SupportText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a63e1acd6423c5195495866e96e8a1cd6)ExpelActionText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.ExpelActionText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a6ce81ba42ef7fef0be4c0df7b7b0af31)SupportCost
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.SupportCost | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#acdd3c3dd347150f507a5da58c7f811fb)ExpelCost
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | int TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.ExpelCost | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#a7038805900c9136e5d2b5ceddc5b621b)ExpelHint
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.ExpelHint | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_v_m.html#aed75f0c2ca25268bd730465e20e742e3)SupportHint
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [HintViewModel](class_tale_worlds_1_1_core_1_1_view_model_collection_1_1_information_1_1_hint_view_model.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.Clans.KingdomClanVM.SupportHint | | getset |

