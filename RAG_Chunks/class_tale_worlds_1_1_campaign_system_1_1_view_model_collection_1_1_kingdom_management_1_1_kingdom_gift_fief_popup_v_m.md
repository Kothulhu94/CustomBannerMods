--- SOURCE: class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html ---

TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM Class ReferenceInherits [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html).

|  |  |
| --- | --- |
| Public Member Functions | |
|  | [KingdomGiftFiefPopupVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#aef4ddcd2ba74f7b97f42aec4f0fcc130) (Action onSettlementGranted) |
| override void | [RefreshValues](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#ad0f3f35c594f9601444ff052ed8debbb) () |
|  | Used for updating localized texts. |
| void | [OpenWith](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a01a2fc6289b53f20eef622f555f139e4) ([CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) settlement) |
| void | [ExecuteGiftSettlement](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#afd4a963841890349e5f895800a773b50) () |
| void | [ExecuteClose](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#aa6fbf0074b3d2dd9364cc0106d257503) () |
| override void | [OnFinalize](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a94412ca0e6ca49bc454d48617b72b5d4) () |
| void | [SetDoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a4dca2a1a00a9829935aa69f25a7cb0e0) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
| void | [SetCancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a64b1b964f679c19a396d2c53ca557b9b) ([HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) hotKey) |
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
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [DoneInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#ad7bd6e9d710a250e16ba4919e5612a78) `[get, set]` |
| [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) | [CancelInputKey](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a5b3342406a9eee526f39f59bcbca105a) `[get, set]` |
| bool | [IsAnyClanSelected](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a9309522a5206c3e4ef99071bfb01a440) `[get, set]` |
| MBBindingList< [KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) > | [Clans](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a44da802b4a3dee89dd4edb5ecd6999e4) `[get, set]` |
| [KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) | [CurrentSelectedClan](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#aaeae201a665834761af2d3b148858d4f) `[get, set]` |
| [KingdomClanSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans660d8637592afa41fef839649dc05117.html) | [ClanSortController](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#aa72a1386aff886f3fe32d471170063bc) `[get, set]` |
| bool | [IsOpen](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#adc9ad498550ed9188221be7088141c96) `[get, set]` |
| string | [TitleText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#afd3267473ab51df5b278fe71fa48f9b0) `[get, set]` |
| string | [GiftText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#ad8a3a4dd891494b9d7575c6e44532c1e) `[get, set]` |
| string | [CancelText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a08f4dc6be7323c961abb3e7a7bfda3b7) `[get, set]` |
| string | [BannerText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#aa4fb0313161db836c3d3656ecaeccc14) `[get, set]` |
| string | [TypeText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a390ce2c9bab8ca72d87fbaa70fb7bca0) `[get, set]` |
| string | [NameText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a0957a2006268f7079c580deae5cf2ee9) `[get, set]` |
| string | [InfluenceText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a8665eb8d6c6c1f3f88a8c0ce40e1465e) `[get, set]` |
| string | [FiefsText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a844bdb85c2556bb3b012d41f2e00e06b) `[get, set]` |
| string | [MembersText](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a24e067fd958ab31bdb110ec04a84e844) `[get, set]` |

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

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#aef4ddcd2ba74f7b97f42aec4f0fcc130)KingdomGiftFiefPopupVM()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.KingdomGiftFiefPopupVM | ( | Action | *onSettlementGranted* | ) |  |

Member Function Documentation
-----------------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#ad0f3f35c594f9601444ff052ed8debbb)RefreshValues()
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.RefreshValues | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#adce37fa80ac41d8a728654a41092b4fd).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a01a2fc6289b53f20eef622f555f139e4)OpenWith()
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.OpenWith | ( | [CampaignSystem.Settlements.Settlement](class_tale_worlds_1_1_campaign_system_1_1_settlements_1_1_settlement.html) | *settlement* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#afd4a963841890349e5f895800a773b50)ExecuteGiftSettlement()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.ExecuteGiftSettlement | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#aa6fbf0074b3d2dd9364cc0106d257503)ExecuteClose()
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |
| --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.ExecuteClose | ( |  | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a94412ca0e6ca49bc454d48617b72b5d4)OnFinalize()
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- | --- |
| |  |  |  |  |  | | --- | --- | --- | --- | --- | | override void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.OnFinalize | ( |  | ) |  | | virtual |

Reimplemented from [TaleWorlds.Library.ViewModel](class_tale_worlds_1_1_library_1_1_view_model.html#aa1963470736282e176720fde075db7cc).

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a4dca2a1a00a9829935aa69f25a7cb0e0)SetDoneInputKey()
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.SetDoneInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a64b1b964f679c19a396d2c53ca557b9b)SetCancelInputKey()
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |  |  |  |
| --- | --- | --- | --- | --- | --- |
| void TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.SetCancelInputKey | ( | [HotKey](class_tale_worlds_1_1_input_system_1_1_hot_key.html) | *hotKey* | ) |  |

Property Documentation
----------------------

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#ad7bd6e9d710a250e16ba4919e5612a78)DoneInputKey
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.DoneInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a5b3342406a9eee526f39f59bcbca105a)CancelInputKey
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [InputKeyItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_input_1_1_input_key_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.CancelInputKey | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a9309522a5206c3e4ef99071bfb01a440)IsAnyClanSelected
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.IsAnyClanSelected | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a44da802b4a3dee89dd4edb5ecd6999e4)Clans
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | MBBindingList<[KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html)> TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.Clans | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#aaeae201a665834761af2d3b148858d4f)CurrentSelectedClan
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [KingdomClanItemVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans_1_1_kingdom_clan_item_v_m.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.CurrentSelectedClan | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#aa72a1386aff886f3fe32d471170063bc)ClanSortController
------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | [KingdomClanSortControllerVM](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_clans660d8637592afa41fef839649dc05117.html) TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.ClanSortController | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#adc9ad498550ed9188221be7088141c96)IsOpen
------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | bool TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.IsOpen | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#afd3267473ab51df5b278fe71fa48f9b0)TitleText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.TitleText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#ad8a3a4dd891494b9d7575c6e44532c1e)GiftText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.GiftText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a08f4dc6be7323c961abb3e7a7bfda3b7)CancelText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.CancelText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#aa4fb0313161db836c3d3656ecaeccc14)BannerText
----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.BannerText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a390ce2c9bab8ca72d87fbaa70fb7bca0)TypeText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.TypeText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a0957a2006268f7079c580deae5cf2ee9)NameText
--------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.NameText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a8665eb8d6c6c1f3f88a8c0ce40e1465e)InfluenceText
-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.InfluenceText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a844bdb85c2556bb3b012d41f2e00e06b)FiefsText
---------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.FiefsText | | getset |

[◆](class_tale_worlds_1_1_campaign_system_1_1_view_model_collection_1_1_kingdom_management_1_1_kingdom_gift_fief_popup_v_m.html#a24e067fd958ab31bdb110ec04a84e844)MembersText
-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------

|  |  |  |
| --- | --- | --- |
| |  | | --- | | string TaleWorlds.CampaignSystem.ViewModelCollection.KingdomManagement.KingdomGiftFiefPopupVM.MembersText | | getset |

